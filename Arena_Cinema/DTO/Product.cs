using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }

        public Product() { }

        public Product(int productID, string productName, string productType, int price, string imageUrl, bool isDeleted)
        {
            ProductID = productID;
            ProductName = productName;
            ProductType = productType;
            Price = price;
            ImageUrl = imageUrl;
            IsDeleted = isDeleted;
        }
    }
}
