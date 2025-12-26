using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class MailHelper
    {
        public static void SendGmail(string fromEmail, string appPassword, string toEmail, string subject, string htmlBody)
        {
            // TLS 1.2 để tránh lỗi handshake trên một số máy
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var message = new MailMessage())
            {
                message.From = new MailAddress(fromEmail, "Cinema");
                message.To.Add(toEmail);
                message.Subject = subject;
                message.Body = htmlBody;
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(fromEmail, appPassword);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Timeout = 20000;

                    smtp.Send(message);
                }
            }
        }
    }
}
