using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PayOS;

namespace UI.PayOSMethod.Services
{
    public class PaymentService
    {
        //private readonly PayOSClient _payOS;

        //public PaymentService(string clientId, string apiKey, string checksumKey)
        //{
        //    _payOS = new PayOSClient(clientId, apiKey, checksumKey);
        //}

        //Tạo link thanh toán
        //public async Task<CreatePaymentResult> CreatePaymentLink(
        //    long orderCode,
        //    int amount,
        //    string description,
        //    string returnUrl,
        //    string cancelUrl)
        //{
        //    try
        //    {
        //        var items = new List<ItemData>
        //        {
        //            new ItemData("Đơn hàng #" + orderCode, 1, amount)
        //        };

        //        var paymentData = new PaymentData(
        //            orderCode: orderCode,
        //            amount: amount,
        //            description: description,
        //            items: items,
        //            returnUrl: returnUrl,
        //            cancelUrl: cancelUrl
        //        );

        //        CreatePaymentResult result = await _payOS.createPaymentLink(paymentData);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi tạo link thanh toán: {ex.Message}");
        //    }
        //}

        ///// <summary>
        ///// Kiểm tra trạng thái thanh toán
        ///// </summary>
        //public async Task<PaymentLinkInformation> GetPaymentInfo(long orderCode)
        //{
        //    try
        //    {
        //        PaymentLinkInformation paymentInfo = await _payOS.getPaymentLinkInformation(orderCode);
        //        return paymentInfo;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi kiểm tra thanh toán: {ex.Message}");
        //    }
        //}

        ///// <summary>
        ///// Hủy link thanh toán
        ///// </summary>
        //public async Task<PaymentLinkInformation> CancelPaymentLink(long orderCode, string reason = null)
        //{
        //    try
        //    {
        //        PaymentLinkInformation result = await _payOS.cancelPaymentLink(orderCode, reason);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi hủy thanh toán: {ex.Message}");
        //    }
        //}

        ///// <summary>
        ///// Xác thực webhook data
        ///// </summary>
        //public WebhookData VerifyWebhookData(string webhookUrl)
        //{
        //    try
        //    {
        //        WebhookData webhookData = _payOS.verifyPaymentWebhookData(webhookUrl);
        //        return webhookData;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi xác thực webhook: {ex.Message}");
        //    }
        //}
    }
}
