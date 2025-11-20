using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DAL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UI.PayOSMethod
{
    public class PayOSWebhookController : ApiController
    {
        private const string CHECKSUM_KEY = "3771898fb26288d7d994ea962f229c3ce279580006278858d244047697b9a9cf";

        [HttpPost]
        [Route("api/payos/webhook")]
        public async Task<HttpResponseMessage> ReceiveWebhook()
        {
            try
            {
                // Đọc raw body
                string webhookData = await Request.Content.ReadAsStringAsync();

                Console.WriteLine($"📨 Webhook received: {webhookData}");

                // Lấy signature từ header
                string signature = Request.Headers.Contains("x-payos-signature")
                    ? Request.Headers.GetValues("x-payos-signature").FirstOrDefault()
                    : null;

                if (string.IsNullOrEmpty(signature))
                {
                    Console.WriteLine("❌ Missing signature header");
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Missing signature");
                }

                // Xử lý webhook
                var handler = new PayOSWebhookHandler(CHECKSUM_KEY);
                bool result = handler.ProcessWebhook(webhookData, signature);

                if (result)
                {
                    Console.WriteLine("✅ Webhook processed successfully");
                    return Request.CreateResponse(HttpStatusCode.OK, new { message = "Success" });
                }
                else
                {
                    Console.WriteLine("❌ Webhook processing failed");
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "Processing failed" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Webhook error: {ex.Message}");
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = ex.Message });
            }
        }

        // Endpoint test
        [HttpGet]
        [Route("api/test")]
        public HttpResponseMessage Test()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { message = "Server is running" });
        }
    }
}