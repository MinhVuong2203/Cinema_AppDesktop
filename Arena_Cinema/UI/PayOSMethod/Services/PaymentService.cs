using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayOS;
using PayOS.Models.Webhooks;
//using Net.PayOS;

namespace UI.PayOSMethod.Services
{
    public class PaymentService
    {
        private readonly PayOSClient _payOS;

        public PaymentService(string clientId, string apiKey, string checksumKey)
        {
            _payOS = new PayOSClient(clientId, apiKey, checksumKey);
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
