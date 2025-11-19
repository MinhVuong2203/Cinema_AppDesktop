using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace UI
{
    public partial class TestPayment : Form
    {
        private readonly BLL.PayOS _payos;

        public TestPayment()
        {
            InitializeComponent();

            // Khởi tạo PayOSService với đầy đủ 3 tham số
            _payos = new BLL.PayOS(
                clientId: "fbfb511c-099a-4a58-b147-9149e5554475",
                apiKey: "0436f5b4-f241-4862-8df9-53f80d89d826",
                checksumKey: "3771898fb26288d7d994ea962f229c3ce279580006278858d244047697b9a9cf"  // <-- THAY BẰNG CHECKSUM KEY THẬT
            );
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var items = new List<PaymentItem>()
            {
                new PaymentItem()
                {
                    name = "Cà phê sữa",
                    price = 20000,
                    quantity = 1
                }
            };

            PaymentData pd = new PaymentData()
            {
                orderCode = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")),
                amount = 20000,
                description = "Thanh toán test WinForms",
                cancelUrl = "https://cancel.com",
                returnUrl = "https://success.com",
                items = items
            };

            string url = await  _payos.CreatePaymentUrl(pd);

            System.Diagnostics.Process.Start(url);
        }

    }
}