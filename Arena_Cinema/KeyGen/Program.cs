using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KeyGen
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            //Console.Write("TenantId: ");
            //var tenant = Guid.Parse(Console.ReadLine());

            //Console.Write("MaxSeats: ");
            //var maxSeats = int.Parse(Console.ReadLine());

            //Console.Write("Plan (1Y / 2Y / LIFETIME): ");
            //var plan = Console.ReadLine().Trim().ToUpperInvariant();

            //var expUnix = GetExpUnix(plan);
            //var payload = $"{tenant}|{maxSeats}|{expUnix}|{plan}";
            //var payloadBytes = Encoding.UTF8.GetBytes(payload);

            //byte[] sig;
            //using (var rsa = new RSACryptoServiceProvider(2048))
            //{
            //    rsa.FromXmlString(RsaPrivateKeyXml);
            //    sig = rsa.SignData(payloadBytes, CryptoConfig.MapNameToOID("SHA256"));
            //}

            //var token = Convert.ToBase64String(payloadBytes) + "." + Convert.ToBase64String(sig);
            //Console.WriteLine("\nKEY:");
            //Console.WriteLine(token);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KeyGenForm());

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
