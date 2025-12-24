using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Licensing
{
    public sealed class LicenseTokenPayload
    {
        public Guid TenantId { get; set; }
        public int MaxSeats { get; set; }
        public DateTime ExpiresAtUtc { get; set; }
        public string PlanCode { get; set; }
    }

    public static class LicenseToken
    {
        // TODO: thay bằng PUBLIC KEY XML của bạn
        public const string RsaPublicKeyXml = @"<RSAKeyValue><Modulus>2ZvFj8EoJQGy/i6/LHNZxcOXzezESJmm+qJ/bkXskqR0rTzEG0nnarYaJVV8Dh/Sh7nY0BAzywCxb4EPKlfWmUEtEc1csWoB0PT9jocxRpAbM6jfMPg0Lt7W4t6JZ4C5y8n7a5NBC46BYGxHIZWwsam61m1df+2u4LxeQ6KpMN3wzz2J93te38nB4BBJV7e9Z/Uhw64YjSEcDeYr/jrc0G8YIiRU/EWREU52eCKg6SOkFifvGdQfllJSpKKupDkvqb5lxKgWiuL4FI9EEnhIIvx4Almz2/VJwRybGP0PTi7CnRXIck0avUtLzMbn4JqrB0SBJaV8uqYZ9d9GqnSpbQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        public static bool TryParseAndVerify(string token, out LicenseTokenPayload payload, out string error)
        {
            payload = null;
            error = null;

            try
            {
                if (string.IsNullOrWhiteSpace(token)) { error = "Key rỗng."; return false; }

                var parts = token.Trim().Split('.');
                if (parts.Length != 2) { error = "Key sai định dạng."; return false; }

                var payloadBytes = Convert.FromBase64String(parts[0]);
                var sigBytes = Convert.FromBase64String(parts[1]);

                using (var rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(RsaPublicKeyXml);
                    var ok = rsa.VerifyData(payloadBytes, CryptoConfig.MapNameToOID("SHA256"), sigBytes);
                    if (!ok) { error = "Key không hợp lệ (signature sai)."; return false; }
                }

                var s = Encoding.UTF8.GetString(payloadBytes);
                var arr = s.Split('|');
                if (arr.Length < 4) { error = "Payload sai."; return false; }

                if (!Guid.TryParse(arr[0], out var tenantId)) { error = "TenantId sai."; return false; }
                if (!int.TryParse(arr[1], out var maxSeats) || maxSeats <= 0) { error = "MaxSeats sai."; return false; }
                if (!long.TryParse(arr[2], out var expUnix)) { error = "Exp sai."; return false; }

                var expUtc = DateTimeOffset.FromUnixTimeSeconds(expUnix).UtcDateTime;
                var plan = arr[3];

                payload = new LicenseTokenPayload
                {
                    TenantId = tenantId,
                    MaxSeats = maxSeats,
                    ExpiresAtUtc = expUtc,
                    PlanCode = plan
                };
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
