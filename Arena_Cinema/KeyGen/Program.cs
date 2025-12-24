using System;
using System.Security.Cryptography;
using System.Text;

namespace KeyGen
{
    internal class Program
    {
        // TODO: dán PRIVATE KEY XML vào đây (chỉ bạn giữ)
        private const string RsaPrivateKeyXml = @"<RSAKeyValue><Modulus>2ZvFj8EoJQGy/i6/LHNZxcOXzezESJmm+qJ/bkXskqR0rTzEG0nnarYaJVV8Dh/Sh7nY0BAzywCxb4EPKlfWmUEtEc1csWoB0PT9jocxRpAbM6jfMPg0Lt7W4t6JZ4C5y8n7a5NBC46BYGxHIZWwsam61m1df+2u4LxeQ6KpMN3wzz2J93te38nB4BBJV7e9Z/Uhw64YjSEcDeYr/jrc0G8YIiRU/EWREU52eCKg6SOkFifvGdQfllJSpKKupDkvqb5lxKgWiuL4FI9EEnhIIvx4Almz2/VJwRybGP0PTi7CnRXIck0avUtLzMbn4JqrB0SBJaV8uqYZ9d9GqnSpbQ==</Modulus><Exponent>AQAB</Exponent><P>4k0yv9RIM3FsxslPFx8UYcLZe5m9/SF+A5F6K2tLFI3OCTeq8d7ZDQnzEOFnH1EiFFqn7wiGBFg65uGN6beO5XcawHr77s71DgZQwBPo7cftScamVZ2yMJpJb1KxXX8Y9lGMnehSMTUI8vetcN6CPrxWI4SkgzObm8ZueAQ0vMs=</P><Q>9iqFocAPOe7u6wzeLDMfI9/e+YPp4/s9DsxSDiYJWaQqrx5XXP9Kn/TvHde6Wvw5z1QAJnHlH4pjM+XswZh6E1BzRIverco94OczNvh4HRGf9kmP4bzwYTe5I8/KZzeuwJqvrOQGCqrGD7XhWzludQIMXN6PbzQBZoqV51bBY6c=</Q><DP>m77lnoBK8JyvcGA7vn31WRLw+s/kocHbKDmHCzrcgVjW5CEb1Tq5xu+CCawXfMYp3jhGO4xyL6tJXnz9XkymW+aM0svRd5mXrf9Ks+b/+CYQeSXudB4D9M86mxMeXmqKk3use0DY0GTfs9gh1fxNRz/3SJqRXnq2LY9zl8XNReE=</DP><DQ>1Fp0MseymuBiHERaeDiVeWYLPKWuI6w8zMI3Wts3H6w94hlDdgcIghpSGCVcLlb9K7wj8QY5iE7iKwgCiDMXxAeXmB8stjEL1jK7/IS1YSYuHtDwnORXXRYr0RfUW9wuFRqbx4JhL9yHxU+6Gu7dOXTN42NeyqhLOQD+NbWiWGs=</DQ><InverseQ>GjpQo1kltWcc/XBCRep5mA7GL+0EjswMuQGlZi0OEbnKT/4JWukoG1gyhorePsj3mTbUGMgP8poj1FAlddBdh1GE54DGv4m9bTYmLrUsvlHirrwR5vMLcmdZqso/pXBr3zhQ43wKh3DCkKFa0pN7g9k3NERtdagmxv5mkR+lV28=</InverseQ><D>UVOLQU+SHkqFR8PWxNkTavrPiDF9phhutGr4rxDI+oEl7fyw2fYD2/jUyrEpHOo9t2X4psH3aV4H8kFMlqmfVUVrf6S9iLyykxKMlLDn9JQ05litmVKZxg6YRs+ekKUmSwhgw3KUM6p9pbix2NZl4/AoGK1k7UO6QNmFbUekbdND8amdT3gGcHaE3f0Pqg4g/cDQUXgvTf2Ej2ETHin8m5Jn+RWaLbbC0zPOmI7oi/3aZZP9lDsbHq0y1591pwgh6uTjsuvRMEd3FDWAAs+6ovBC+2bRyE9O2Lhk03a8ltr3HpAaCmT6ydICTf2dPKBw/7cfS4w9gwz53i3FlwsWTQ==</D></RSAKeyValue>";

        static void Main()
        {
            Console.Write("TenantId: ");
            var tenant = Guid.Parse(Console.ReadLine());

            Console.Write("MaxSeats: ");
            var maxSeats = int.Parse(Console.ReadLine());

            Console.Write("Plan (1Y / 2Y / LIFETIME): ");
            var plan = Console.ReadLine().Trim().ToUpperInvariant();

            var expUnix = GetExpUnix(plan);
            var payload = $"{tenant}|{maxSeats}|{expUnix}|{plan}";
            var payloadBytes = Encoding.UTF8.GetBytes(payload);

            byte[] sig;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(RsaPrivateKeyXml);
                sig = rsa.SignData(payloadBytes, CryptoConfig.MapNameToOID("SHA256"));
            }

            var token = Convert.ToBase64String(payloadBytes) + "." + Convert.ToBase64String(sig);
            Console.WriteLine("\nKEY:");
            Console.WriteLine(token);
        }

        static long GetExpUnix(string plan)
        {
            var now = DateTimeOffset.UtcNow;
            switch (plan)
            {
                case "1Y": return now.AddYears(1).ToUnixTimeSeconds();
                case "2Y": return now.AddYears(2).ToUnixTimeSeconds();
                case "LIFETIME":
                    return new DateTimeOffset(new DateTime(2100, 1, 1, 0, 0, 0, DateTimeKind.Utc)).ToUnixTimeSeconds();
                default:
                    throw new ArgumentException("Plan không hợp lệ.");
            }
        }
    }
}
