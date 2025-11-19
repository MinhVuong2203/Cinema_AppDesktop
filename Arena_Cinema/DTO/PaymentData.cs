using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentData
    {
        public long orderCode { get; set; }
        public int amount { get; set; }
        public string description { get; set; }
        public List<PaymentItem> items { get; set; }
        public string cancelUrl { get; set; }
        public string returnUrl { get; set; }
    }

}
