using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace UI.PayOSMethod.Services
{
    public class PaymentService
    {
        private readonly string _clientId = "fbfb511c-099a-4a58-b147-9149e5554475";
        private readonly string _apiKey = "0436f5b4-f241-4862-8df9-53f80d89d826";
        private readonly string _checksumKey = "3771898fb26288d7d994ea962f229c3ce279580006278858d244047697b9a9cf";
        private readonly HttpClient _httpClient;

        public PaymentService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api-merchant.payos.vn")
            };
            _httpClient.DefaultRequestHeaders.Add("x-client-id", _clientId);
            _httpClient.DefaultRequestHeaders.Add("x-api-key", _apiKey);
        }

        public async Task<string> CreatePaymentLinkAsync(int orderCode, int amount, string description, string returnUrl, string cancelUrl)
        {
            try
            {
                // Format theo đúng PayOS V2 API documentation
                var payloadDict = new Dictionary<string, object>
                {
                    { "orderCode", orderCode },
                    { "amount", amount },
                    { "description", description ?? "Thanh toan" },
                    { "returnUrl", returnUrl ?? "https://example.com/success" },
                    { "cancelUrl", cancelUrl ?? "https://example.com/cancel" }
                };

                var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(payloadDict);

                Console.WriteLine($"=== PayOS Request ===");
                Console.WriteLine($"Payload: {jsonContent}");

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Tạo signature từ sorted payload
                var signature = GenerateSignature(payloadDict);
                content.Headers.Add("x-signature", signature);

                Console.WriteLine($"Signature: {signature}");

                var response = await _httpClient.PostAsync("/v2/payment-requests", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Status: {response.StatusCode}");
                Console.WriteLine($"Response: {responseBody}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"HTTP {response.StatusCode}: {responseBody}");
                }

                var jsonResponse = JObject.Parse(responseBody);
                var code = jsonResponse["code"]?.ToString();

                if (code == "00")
                {
                    var checkoutUrl = jsonResponse["data"]?["checkoutUrl"]?.ToString();
                    if (!string.IsNullOrEmpty(checkoutUrl))
                    {
                        Console.WriteLine($"✅ Success: {checkoutUrl}");
                        return checkoutUrl;
                    }
                }

                var errorDesc = jsonResponse["desc"]?.ToString() ?? "Unknown error";
                throw new Exception($"PayOS error (code {code}): {errorDesc}\nResponse: {responseBody}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
                throw;
            }
        }

        private string GenerateSignature(Dictionary<string, object> data)
        {
            // Sort keys alphabetically và tạo string
            var sortedKeys = new List<string>(data.Keys);
            sortedKeys.Sort();

            var signatureData = new StringBuilder();
            foreach (var key in sortedKeys)
            {
                if (data[key] != null)
                {
                    signatureData.Append($"{key}={data[key]}&");
                }
            }

            // Remove trailing &
            var dataToSign = signatureData.ToString().TrimEnd('&');

            Console.WriteLine($"Data to sign: {dataToSign}");

            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_checksumKey)))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dataToSign));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        public async Task<string> GetPaymentStatusAsync(int orderCode)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/v2/payment-requests/{orderCode}");
                var responseBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode) return "ERROR";

                var jsonResponse = JObject.Parse(responseBody);
                return jsonResponse["data"]?["status"]?.ToString()?.ToUpper() ?? "UNKNOWN";
            }
            catch
            {
                return "ERROR";
            }
        }
    }
}