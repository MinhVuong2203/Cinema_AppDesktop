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

        /// <summary>
        /// ✅ QUERY trạng thái thanh toán từ PayOS API
        /// </summary>
        public async Task<PaymentQueryResult> GetPaymentStatus(long orderCode)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("x-client-id", clientId);
                    client.DefaultRequestHeaders.Add("x-api-key", apiKey);

                    string url = $"https://api-merchant.payos.vn/v2/payment-requests/{orderCode}";
                    Console.WriteLine($"🔍 Querying payment status: {url}");

                    var response = await client.GetAsync(url);
                    var result = await response.Content.ReadAsStringAsync();

                    Console.WriteLine($"📥 PayOS query response: {result}");

                    dynamic obj = JsonConvert.DeserializeObject(result);
                    string code = obj.code?.ToString();

                    if (code == "00")
                    {
                        var data = obj.data;
                        return new PaymentQueryResult
                        {
                            Success = true,
                            OrderCode = long.Parse(data.orderCode.ToString()),
                            Status = data.status?.ToString(), // PENDING, PROCESSING, PAID, CANCELLED
                            Amount = decimal.Parse(data.amount.ToString()),
                            BuyerName = data.buyerName?.ToString(),
                            TransactionDateTime = data.transactionDateTime?.ToString(),
                            Description = data.description?.ToString()
                        };
                    }
                    else
                    {
                        return new PaymentQueryResult
                        {
                            Success = false,
                            ErrorCode = code,
                            ErrorMessage = obj.desc?.ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error querying payment: {ex.Message}");
                return new PaymentQueryResult
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        /// <summary>
        /// ✅ Tạo payment URL với InvoiceID trong buyerName
        /// </summary>
        public async Task<string> CreatePaymentUrl(PaymentData data, Guid invoiceID)
        {
            // Bước 1: build stringToSign
            string stringToSign =
                $"amount={data.amount}" +
                $"&cancelUrl={data.cancelUrl}" +
                $"&description={data.description}" +
                $"&orderCode={data.orderCode}" +
                $"&returnUrl={data.returnUrl}";

            // Bước 2: ký signature
            string signature = Sign(stringToSign, checksumKey);

            // ✅ Bước 3: Thêm InvoiceID vào buyerName
            var body = new
            {
                orderCode = data.orderCode,
                amount = data.amount,
                description = data.description,
                cancelUrl = data.cancelUrl,
                returnUrl = data.returnUrl,
                items = data.items,
                signature = signature,
                // ✅ TRUYỀN InvoiceID qua buyerName
                buyerName = invoiceID.ToString(),
                buyerEmail = "customer@cinema.com",
                buyerPhone = "0000000000",
                buyerAddress = "Cinema"
            };

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("x-client-id", clientId);
                client.DefaultRequestHeaders.Add("x-api-key", apiKey);

                string json = JsonConvert.SerializeObject(body);
                Console.WriteLine($"📤 Payment request body: {json}");

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var res = await client.PostAsync("https://api-merchant.payos.vn/v2/payment-requests", content);
                var result = await res.Content.ReadAsStringAsync();

                Console.WriteLine($"📥 PayOS response: {result}");

                dynamic obj = JsonConvert.DeserializeObject(result);
                string code = obj.code.ToString();
                string desc = obj.desc.ToString();

                if (code == "00")
                {
                    return obj.data.checkoutUrl.ToString();
                }

                throw new Exception(desc);
            }
        }

    }
    /// <summary>
    /// ✅ DTO cho kết quả query payment
    /// </summary>
    public class PaymentQueryResult
    {
        public bool Success { get; set; }
        public long OrderCode { get; set; }
        public string Status { get; set; } // PENDING, PROCESSING, PAID, CANCELLED
        public decimal Amount { get; set; }
        public string BuyerName { get; set; } // InvoiceID
        public string TransactionDateTime { get; set; }
        public string Description { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
