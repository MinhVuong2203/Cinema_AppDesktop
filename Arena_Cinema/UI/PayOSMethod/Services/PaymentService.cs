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
                if (amount <= 0) throw new ArgumentException("amount phải là số nguyên dương.");
                if (string.IsNullOrWhiteSpace(description)) description = "Thanh toan";
                if (description.Length > 25) description = description.Substring(0, 25);
                if (string.IsNullOrWhiteSpace(returnUrl)) returnUrl = "https://example.com/success";
                if (string.IsNullOrWhiteSpace(cancelUrl)) cancelUrl = "https://example.com/cancel";

                // Thử thêm các trường có thể bắt buộc
                var payloadDict = new Dictionary<string, object>
                {
                    { "orderCode", orderCode },
                    { "amount", amount },
                    { "description", description },
                    { "buyerName", "" },          // Thêm field này
                    { "buyerEmail", "" },         // Thêm field này
                    { "buyerPhone", "" },         // Thêm field này
                    { "buyerAddress", "" },       // Thêm field này
                    { "items", new List<Dictionary<string, object>>  // Thêm items
                        {
                            new Dictionary<string, object>
                            {
                                { "name", description },
                                { "quantity", 1 },
                                { "price", amount }
                            }
                        }
                    },
                    { "returnUrl", returnUrl },
                    { "cancelUrl", cancelUrl },
                    { "expiredAt", (int)(DateTimeOffset.UtcNow.AddMinutes(15).ToUnixTimeSeconds()) } // Thêm expiry
                };

                var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(payloadDict);
                var signature = GenerateSignatureV2(payloadDict);

                Console.WriteLine($"Full Payload: {jsonContent}");
                Console.WriteLine($"Signature: {signature}");

                var request = new HttpRequestMessage(HttpMethod.Post, "/v2/payment-requests")
                {
                    Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
                };
                request.Headers.Add("x-signature", signature);

                var response = await _httpClient.SendAsync(request);
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
                throw new Exception($"PayOS error (code {code}): {errorDesc}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
                throw;
            }
        }

        // Signature generator mới cho format phức tạp hơn
        private string GenerateSignatureV2(Dictionary<string, object> data)
        {
            // Chỉ sign các field cần thiết, không sign nested objects
            var dataToSign = new Dictionary<string, object>();

            foreach (var key in data.Keys)
            {
                // Bỏ qua items và các nested objects
                if (key != "items" && !(data[key] is Dictionary<string, object>) && !(data[key] is List<Dictionary<string, object>>))
                {
                    dataToSign[key] = data[key];
                }
            }

            var sortedKeys = new List<string>(dataToSign.Keys);
            sortedKeys.Sort();

            var signatureData = new StringBuilder();
            foreach (var key in sortedKeys)
            {
                if (dataToSign[key] != null && !string.IsNullOrEmpty(dataToSign[key].ToString()))
                {
                    signatureData.Append($"{key}={dataToSign[key]}&");
                }
            }

            var stringToSign = signatureData.ToString().TrimEnd('&');
            Console.WriteLine($"String to sign: {stringToSign}");

            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_checksumKey)))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
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