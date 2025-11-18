using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayOS;
using PayOS.Models.V2.PaymentRequests;
using PayOS.Models.Webhooks;
//using Net.PayOS;

namespace UI.PayOSMethod.Services
{
    public class PaymentService
    {
        private readonly PayOSClient _client;

        public PaymentService()
        {
            // Khởi tạo PayOSClient với ClientId và ApiKey từ cấu hình
            _client = new PayOSClient(new PayOSOptions
            {
                ClientId = Config.PayOSConfig.ClientId,
                ApiKey = Config.PayOSConfig.ApiKey,
                ChecksumKey = Config.PayOSConfig.ChecksumKey
            });
        }

        // Tạo payment link (giữ nguyên, nhưng thêm error handling)
        public async Task<string> CreatePaymentLinkAsync(int orderCode, int amount, string description, string returnUrl, string cancelUrl)
        {
            try
            {
                var request = new CreatePaymentLinkRequest
                {
                    OrderCode = orderCode,
                    Amount = amount,  // Đơn vị VND
                    Description = description,
                    ReturnUrl = returnUrl,
                    CancelUrl = cancelUrl
                };

                var response = await _client.PaymentRequests.CreateAsync(request);
                if (response != null && !string.IsNullOrEmpty(response.CheckoutUrl))
                {
                    return response.CheckoutUrl;
                }
                else
                {
                    throw new Exception("Không tạo được payment link: Unknown error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tạo payment: " + ex.Message);
            }
        }

        // Query trạng thái payment (cho polling trong WinForms)
        public async Task<string> GetPaymentStatusAsync(int orderCode)
        {
            try
            {
                var response = await _client.PaymentRequests.GetAsync(orderCode);
                // Convert nullable PaymentLinkStatus to string, fallback to "UNKNOWN" if null
                return response?.Status != null ? response.Status.ToString().ToUpper() : "UNKNOWN";  // Ví dụ: "PAID", "PENDING", "CANCELLED"
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi query status: " + ex.Message);
            }
        }

        //public class Item
        //{
        //    public string Name { get; set; }
        //    public int Quantity { get; set; }
        //    public int Price { get; set; }
        //}

        //// Sửa lại tên phương thức cho đúng với SDK
        //public async Task<object> CreatePaymentLink(
        //    long orderCode,
        //    int amount,
        //    string description,
        //    string buyerName = "",
        //    string buyerEmail = "",
        //    string buyerPhone = "",
        //    string returnUrl = "https://your-domain.com/success",
        //    string cancelUrl = "https://your-domain.com/cancel")
        //{
        //    try
        //    {
        //        var paymentRequest = new
        //        {
        //            orderCode,
        //            amount,
        //            description,
        //            buyerName,
        //            buyerEmail,
        //            buyerPhone,
        //            returnUrl,
        //            cancelUrl,
        //            items = new List<Item>
        //            {
        //                new Item
        //                {
        //                    Name = $"Đơn hàng #{orderCode}",
        //                    Quantity = 1,
        //                    Price = amount
        //                }
        //            }
        //        };

        //        // Sử dụng phương thức đúng của SDK, ví dụ: CreatePaymentLinkAsync
        //        var result = await _payOS.CreatePaymentLinkAsync(paymentRequest);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi tạo link thanh toán: {ex.Message}", ex);
        //    }
        //}

        //public async Task<object> GetPaymentInfo(long orderCode)
        //{
        //    try
        //    {
        //        // Sử dụng phương thức đúng của SDK, ví dụ: GetPaymentLinkInfoAsync
        //        var paymentInfo = await _payOS.GetPaymentLinkInfoAsync(orderCode);
        //        return paymentInfo;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi kiểm tra trạng thái: {ex.Message}", ex);
        //    }
        //}

        //public async Task<object> CancelPaymentLink(long orderCode, string reason = "Khách hàng yêu cầu hủy")
        //{
        //    try
        //    {
        //        // Sử dụng phương thức đúng của SDK, ví dụ: CancelPaymentLinkAsync
        //        var result = await _payOS.CancelPaymentLinkAsync(orderCode, reason);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi hủy thanh toán: {ex.Message}", ex);
        //    }
        //}

        //public object VerifyWebhookData(string webhookDataJson)
        //{
        //    try
        //    {
        //        // Sử dụng phương thức đúng của SDK, ví dụ: VerifyWebhookAsync
        //        var webhookData = _payOS.VerifyWebhookAsync(webhookDataJson);
        //        return webhookData;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi xác thực webhook: {ex.Message}", ex);
        //    }
        //}

        //public string GetPaymentStatusText(string status)
        //{
        //    switch (status?.ToUpper())
        //    {
        //        case "PENDING":
        //            return "Chờ thanh toán";
        //        case "PAID":
        //        case "PROCESSING":
        //            return "Đã thanh toán";
        //        case "CANCELLED":
        //            return "Đã hủy";
        //        case "EXPIRED":
        //            return "Đã hết hạn";
        //        default:
        //            return status ?? "Không xác định";
        //    }
        //}
    }
}
