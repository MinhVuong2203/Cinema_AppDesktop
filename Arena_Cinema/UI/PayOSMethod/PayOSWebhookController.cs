using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using DAL;

namespace UI.PayOSMethod
{
    public class PayOSWebhookController : ApiController
    {
        [HttpPost]
        [Route("api/payos/webhook")]
        public IHttpActionResult ReceiveWebhook([FromBody] string webhookData, [FromUri] string signature)
        {
            var handler = new PayOSWebhookHandler("3771898fb26288d7d994ea962f229c3ce279580006278858d244047697b9a9cf");
            bool result = handler.ProcessWebhook(webhookData, signature);

            if (result)
                return Ok("Webhook processed successfully");
            else
                return BadRequest("Webhook processing failed");
        }
    }
}
