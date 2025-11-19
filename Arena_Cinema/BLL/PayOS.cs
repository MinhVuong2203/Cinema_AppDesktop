using DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PayOS
    {
        private readonly string clientId;
        private readonly string apiKey;
        private readonly string checksumKey;

        public PayOS(string clientId, string apiKey, string checksumKey)
        {
            this.clientId = clientId;
            this.apiKey = apiKey;
            this.checksumKey = checksumKey;
        }

        private string Sign(string data, string checksumKey)
        {
            var keyBytes = Encoding.UTF8.GetBytes(checksumKey);
            var dataBytes = Encoding.UTF8.GetBytes(data);

            using (var hmac = new HMACSHA256(keyBytes))
            {
                var hash = hmac.ComputeHash(dataBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }


        public async Task<string> CreatePaymentUrl(PaymentData data)
        {
            // Bước 1: build stringToSign theo tài liệu
            string stringToSign =
                $"amount={data.amount}" +
                $"&cancelUrl={data.cancelUrl}" +
                $"&description={data.description}" +
                $"&orderCode={data.orderCode}" +
                $"&returnUrl={data.returnUrl}";

            // Bước 2: ký signature bằng CHECKSUM_KEY
            string signature = Sign(stringToSign, checksumKey);

            // Bước 3: build body JSON
            var body = new
            {
                orderCode = data.orderCode,
                amount = data.amount,
                description = data.description,
                cancelUrl = data.cancelUrl,
                returnUrl = data.returnUrl,
                items = data.items,
                signature = signature
            };

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("x-client-id", clientId);
                client.DefaultRequestHeaders.Add("x-api-key", apiKey);

                string json = JsonConvert.SerializeObject(body);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var res = await client.PostAsync("https://api-merchant.payos.vn/v2/payment-requests", content);
                var result = await res.Content.ReadAsStringAsync();

                dynamic obj = JsonConvert.DeserializeObject(result);

                string code = obj.code.ToString();
                string desc = obj.desc.ToString();

                if (code == "00")   // Thành công
                {
                    return obj.data.checkoutUrl.ToString();
                }

                throw new Exception(desc);  // Thất bại

            }
        }

    }
}
