using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MovieProduct
    {
        public int MovieProductID { get; set; }
        public int MovieID { get; set; }
        public int ProductID { get; set; }
        public string OfferType { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }

        public MovieProduct() { }

        public MovieProduct(int movieProductID, int movieID, int productID, string offerType, int quantity, string note)
        {
            MovieProductID = movieProductID;
            MovieID = movieID;
            ProductID = productID;
            OfferType = offerType;
            Quantity = quantity;
            Note = note;
        }
    }
}
