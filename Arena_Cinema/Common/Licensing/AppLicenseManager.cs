using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Licensing
{
    public static class AppLicenseManager
    {
        private static readonly string AppDir =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Arena_Cinema");
        private static readonly string InstallIdPath = Path.Combine(AppDir, "install.id");

        public static string GetOrCreateInstallId()
        {
            Directory.CreateDirectory(AppDir);

            if (File.Exists(InstallIdPath))
            {
                try
                {
                    var protectedBytes = File.ReadAllBytes(InstallIdPath);
                    var plainBytes = ProtectedData.Unprotect(protectedBytes, null, DataProtectionScope.LocalMachine);
                    var s = Encoding.UTF8.GetString(plainBytes);
                    if (!string.IsNullOrWhiteSpace(s)) return s.Trim();
                }
                catch { }
            }

            var id = Guid.NewGuid().ToString("N");
            var bytes = Encoding.UTF8.GetBytes(id);
            var protectedOut = ProtectedData.Protect(bytes, null, DataProtectionScope.LocalMachine);
            File.WriteAllBytes(InstallIdPath, protectedOut);
            return id;
        }

        public static LicenseResult CheckAccessAndRegisterSeat(string connectionString, int trialDays = 3)
        {
            try
            {
                var installId = GetOrCreateInstallId();
                var machineName = Environment.MachineName;

                using (var cn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("dbo.usp_License_CheckAccessAndRegisterSeat", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@InstallId", SqlDbType.NVarChar, 64).Value = installId;
                    cmd.Parameters.Add("@MachineName", SqlDbType.NVarChar, 128).Value = (object)machineName ?? DBNull.Value;
                    cmd.Parameters.Add("@TrialDays", SqlDbType.Int).Value = trialDays;

                    cn.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        if (!r.Read())
                            return new LicenseResult { State = LicenseState.Error, Message = "DB không phản hồi." };

                        var code = Convert.ToInt32(r["StateCode"]);
                        return new LicenseResult
                        {
                            State = code == 1 ? LicenseState.Activated :
                                    code == 2 ? LicenseState.Trial :
                                    code == 3 ? LicenseState.Expired :
                                    code == 4 ? LicenseState.SeatLimitReached : LicenseState.Error,
                            Message = Convert.ToString(r["Message"]),
                            TrialDaysLeft = r["TrialDaysLeft"] == DBNull.Value ? 0 : Convert.ToInt32(r["TrialDaysLeft"]),
                            TenantId = (Guid)r["TenantId"],
                            MaxSeats = r["MaxSeats"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["MaxSeats"]),
                            UsedSeats = r["UsedSeats"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["UsedSeats"]),
                            ExpiresAtUtc = r["ExpiresAtUtc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["ExpiresAtUtc"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new LicenseResult { State = LicenseState.Error, Message = ex.Message };
            }
        }

        public static bool ApplyToken(string connectionString, string token, out string error)
        {
            error = null;

            if (!LicenseToken.TryParseAndVerify(token, out var payload, out error))
                return false;

            Guid tenantIdInDb;
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT TOP 1 TenantId FROM dbo.AppSettings ORDER BY SettingId", cn))
            {
                cn.Open();
                var obj = cmd.ExecuteScalar();
                if (obj == null) { error = "DB chưa có AppSettings."; return false; }
                tenantIdInDb = (Guid)obj;
            }

            if (tenantIdInDb != payload.TenantId)
            {
                error = "Key không đúng rạp (TenantId không khớp DB).";
                return false;
            }

            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("dbo.usp_License_ApplyToken", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenantId", SqlDbType.UniqueIdentifier).Value = tenantIdInDb;
                cmd.Parameters.Add("@LicenseToken", SqlDbType.NVarChar).Value = token.Trim();
                cmd.Parameters.Add("@PlanCode", SqlDbType.NVarChar, 50).Value = (object)payload.PlanCode ?? DBNull.Value;
                cmd.Parameters.Add("@MaxSeats", SqlDbType.Int).Value = payload.MaxSeats;
                cmd.Parameters.Add("@ExpiresAtUtc", SqlDbType.DateTime2).Value = payload.ExpiresAtUtc;

                cn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) { error = "Không lưu được key."; return false; }
                    var ok = Convert.ToInt32(r["Ok"]) == 1;
                    if (!ok) error = Convert.ToString(r["Message"]);
                    return ok;
                }
            }
        }
    }
}
