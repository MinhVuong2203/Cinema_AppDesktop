using System;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Threading.Tasks;

namespace UI.PayOSMethod
{
    public class PayOSWebhookServer
    {
        private HttpSelfHostServer _server;
        private readonly string _baseAddress = "http://localhost:3000";

        public async Task StartAsync()
        {
            try
            {
                var config = new HttpSelfHostConfiguration(_baseAddress);

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}",
                    defaults: new { id = RouteParameter.Optional }
                );

                _server = new HttpSelfHostServer(config);
                await _server.OpenAsync();

                Console.WriteLine($"✅ Webhook server started at {_baseAddress}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Failed to start webhook server: {ex.Message}");
                throw;
            }
        }

        public async Task StopAsync()
        {
            if (_server != null)
            {
                await _server.CloseAsync();
                _server.Dispose();
                Console.WriteLine("🛑 Webhook server stopped");
            }
        }
    }
}