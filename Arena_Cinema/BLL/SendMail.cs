using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace BLL
{
    public class SendMail
    {
        public void Send()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Tên của bạn", "yourmail@gmail.com"));
            message.To.Add(new MailboxAddress("", "nguoinhan@example.com"));
            message.Subject = "Test gửi Gmail từ WinForms";

            message.Body = new TextPart("plain")
            {
                Text = "Hello, đây là email gửi từ WinForms!"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                // Email + App Password
                client.Authenticate("yourmail@gmail.com", "APP_PASSWORD_Ở_BƯỚC_1");

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
