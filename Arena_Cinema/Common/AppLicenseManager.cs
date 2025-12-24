using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Common
{
    public enum LicenseState
    {
        Trial,
        Activated,
        Expired,
        Tampered
    }

    public sealed class LicenseInfo
    {
        public LicenseState State { get; set; }
        public int TrialDaysLeft { get; set; }
        public string InstallId { get; set; }
        public string Message { get; set; }
    }

    public static class AppLicenseManager
    {
        private const int TRIAL_DAYS = 0;

        // Đổi tên thư mục theo app của bạn
        private static readonly string AppFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Arena_Cinema");
        private static readonly string LicensePath = Path.Combine(AppFolder, "license.dat");

        // Public key (RSA) để VERIFY key kích hoạt
        // Bạn sẽ tạo cặp key riêng; nhúng PUBLIC vào app.
        // Dạng XML dùng tốt cho .NET Framework.
        private const string RSA_PUBLIC_KEY_XML = @"<RSAKeyValue><Modulus>xsNnGI5LhzcDT6u802aqJazQRw1I0tcRTQL2xR0mTctCMzwlsNjK8S+1SF7O5/7S9N1NqhoCK6E3neDfDZYNg05CjhENYOHMrGjBZoOalMUtq41l0cIr99t3Y4Z5YfesFON0GzU4om8lU7wRdfSlc37dzmXSfLHNCM1ITMXNip+RnZxiAwsbndlGKhQLTDgaRzQFmZE4uMP4+VYUS57FQbVVOs/B6NETzqYP0zuHNKRSGpHD3PgfymeyvXcJc94fer0Ac4ylq5xOFoSpXTAhyOg7Crej7UCIn9MYetEISUMO2fZOlyAGPXKQV5YeccasmtYmDtwlZ35R8VbtaWGBTQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        public static LicenseInfo CheckLicense()
        {
            Directory.CreateDirectory(AppFolder);

            var nowUtc = DateTime.UtcNow;

            var data = LoadState();
            if (data == null)
            {
                data = new LocalState
                {
                    InstallId = Guid.NewGuid().ToString("N"),
                    TrialStartUtc = nowUtc,
                    LastRunUtc = nowUtc,
                    ActivationKey = null
                };
                SaveState(data);
            }

            // Nếu có activation key -> verify
            if (!string.IsNullOrWhiteSpace(data.ActivationKey))
            {
                if (VerifyActivationKey(data.InstallId, data.ActivationKey))
                {
                    // cập nhật last run để giảm gian lận
                    data.LastRunUtc = nowUtc;
                    SaveState(data);

                    return new LicenseInfo
                    {
                        State = LicenseState.Activated,
                        TrialDaysLeft = 0,
                        InstallId = data.InstallId,
                        Message = "Bản quyền đã kích hoạt."
                    };
                }
                else
                {
                    // key trong máy bị sai/hỏng -> coi như tamper
                    return new LicenseInfo
                    {
                        State = LicenseState.Tampered,
                        TrialDaysLeft = 0,
                        InstallId = data.InstallId,
                        Message = "License key không hợp lệ hoặc đã bị chỉnh sửa."
                    };
                }
            }

            // Chống chỉnh lùi thời gian (cơ bản)
            // Cho phép lệch nhỏ 5 phút để tránh lỗi do đồng bộ giờ
            if (nowUtc < data.LastRunUtc.AddMinutes(-5))
            {
                return new LicenseInfo
                {
                    State = LicenseState.Tampered,
                    TrialDaysLeft = 0,
                    InstallId = data.InstallId,
                    Message = "Phát hiện thay đổi thời gian hệ thống."
                };
            }

            // Tính trial
            var usedDays = (nowUtc.Date - data.TrialStartUtc.Date).Days;
            var left = TRIAL_DAYS - usedDays;

            data.LastRunUtc = nowUtc;
            SaveState(data);

            if (left <= 0)
            {
                return new LicenseInfo
                {
                    State = LicenseState.Expired,
                    TrialDaysLeft = 0,
                    InstallId = data.InstallId,
                    Message = "Dùng thử đã hết hạn."
                };
            }

            return new LicenseInfo
            {
                State = LicenseState.Trial,
                TrialDaysLeft = left,
                InstallId = data.InstallId,
                Message = $"Bạn còn {left} ngày dùng thử."
            };
        }

        public static bool Activate(string installId, string key, out string error)
        {
            error = null;

            if (!VerifyActivationKey(installId, key))
            {
                error = "Key không hợp lệ.";
                return false;
            }

            var state = LoadState();
            if (state == null || !string.Equals(state.InstallId, installId, StringComparison.OrdinalIgnoreCase))
            {
                error = "InstallId không khớp trạng thái máy.";
                return false;
            }

            state.ActivationKey = key.Trim();
            state.LastRunUtc = DateTime.UtcNow;
            SaveState(state);
            return true;
        }

        private static bool VerifyActivationKey(string installId, string keyBase64)
        {
            try
            {
                var signature = Convert.FromBase64String(keyBase64.Trim());
                var payload = Encoding.UTF8.GetBytes(installId);

                using (var rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(RSA_PUBLIC_KEY_XML);
                    // SHA256 + PKCS#1 v1.5
                    return rsa.VerifyData(payload, CryptoConfig.MapNameToOID("SHA256"), signature);
                }
            }
            catch
            {
                return false;
            }
        }

        // ===== Persistence (DPAPI + JSON) =====

        [DataContract]
        private sealed class LocalState
        {
            [DataMember] public string InstallId { get; set; }
            [DataMember] public DateTime TrialStartUtc { get; set; }
            [DataMember] public DateTime LastRunUtc { get; set; }
            [DataMember] public string ActivationKey { get; set; }
        }

        private static void SaveState(LocalState state)
        {
            var json = SerializeJson(state);
            var plainBytes = Encoding.UTF8.GetBytes(json);

            // DPAPI LocalMachine: mọi user trên máy đều đọc được (phù hợp app cài đặt)
            var protectedBytes = ProtectedData.Protect(plainBytes, optionalEntropy: null, scope: DataProtectionScope.LocalMachine);
            File.WriteAllBytes(LicensePath, protectedBytes);
        }

        private static LocalState LoadState()
        {
            try
            {
                if (!File.Exists(LicensePath)) return null;

                var protectedBytes = File.ReadAllBytes(LicensePath);
                var plainBytes = ProtectedData.Unprotect(protectedBytes, optionalEntropy: null, scope: DataProtectionScope.LocalMachine);
                var json = Encoding.UTF8.GetString(plainBytes);
                return DeserializeJson<LocalState>(json);
            }
            catch
            {
                return null;
            }
        }

        private static string SerializeJson<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var ser = new DataContractJsonSerializer(typeof(T));
                ser.WriteObject(ms, obj);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        private static T DeserializeJson<T>(string json)
        {
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                var ser = new DataContractJsonSerializer(typeof(T));
                return (T)ser.ReadObject(ms);
            }
        }
    }
}
