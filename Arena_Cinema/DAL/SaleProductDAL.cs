using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SaleProductDAL
    {
        private readonly CinemaDBContext _context;
        public SaleProductDAL()
        {
            _context = new CinemaDBContext();
        }
        //lấy danh sách các sản phẩm
        public List<DTO.Product> GetAllProducts()
        {
            var products = _context.Products
                .Where(p => !p.IsDeleted)
                .ToList();
            return products;
        }

        //lưu hóa đơn sản phẩm với trạng thái "Chờ thanh toán"
        //public void AddProductInvoice(DTO.Product product, DTO.InvoiceProduct invoiceProduct, DTO.Invoice invoice, 
        //    int Quantity, DTO.Employee employee, DTO.Customer customer,
        //    decimal totalAmount, decimal disCount)
        //{
        //    //tạo hóa đơn
        //    invoice.InvoiceID = Guid.NewGuid();
        //    invoice.EmployeeID = employee.EmployeeID;
        //    invoice.CustomerID = customer != null ? customer.CustomerID : (Guid?)null;
        //    invoice.IssueDate = DateTime.Now;
        //    //invoice.TotalAmount = productOrder.Price * Quantity;
        //    //giá trị tổng của hóa đơn
        //    invoice.TotalAmount = totalAmount;
        //    invoice.Discount = disCount;
        //    invoice.Status = "Chờ thanh toán";
        //    invoice.IsDeleted = false;
        //    //tạo chi tiết hóa đơn cho từng sản phẩm được đặt
        //    //invoiceProduct.Status = "Chờ thanh toán";
        //    invoiceProduct.InvoiceProductID = Guid.NewGuid();
        //    invoiceProduct.InvoiceID = invoice.InvoiceID;
        //    invoiceProduct.ProductID = product.ProductID;
        //    invoiceProduct.Quantity = Quantity;
        //    invoiceProduct.UnitPrice = product.Price;

        //    _context.Invoices.Add(invoice);
        //    _context.InvoiceProducts.Add(invoiceProduct);
        //    _context.SaveChanges();
        //}

        public Guid AddProductInvoice(
                List<DTO.Product> products,
                Dictionary<int, int> productQuantities,
                DTO.Employee employee,
                DTO.Customer customer,
                decimal totalAmount,
                decimal discount)
        {
            // Tạo hóa đơn mới
            var invoice = new DTO.Invoice
            {
                InvoiceID = Guid.NewGuid(),
                EmployeeID = employee.EmployeeID,
                CustomerID = customer != null ? customer.CustomerID : (Guid?)null,
                IssueDate = DateTime.Now,
                TotalAmount = totalAmount,
                Discount = discount,
                Status = "Chờ thanh toán",
                IsDeleted = false
            };

            _context.Invoices.Add(invoice);

            // Thêm chi tiết hóa đơn cho từng sản phẩm
            foreach (var product in products)
            {
                int quantity = productQuantities.ContainsKey(product.ProductID) ? productQuantities[product.ProductID] : 0;
                if (quantity <= 0) continue;

                var invoiceProduct = new DTO.InvoiceProduct
                {
                    InvoiceProductID = Guid.NewGuid(),
                    InvoiceID = invoice.InvoiceID,
                    ProductID = product.ProductID,
                    Quantity = quantity,
                    UnitPrice = product.Price
                };

                _context.InvoiceProducts.Add(invoiceProduct);
            }

            _context.SaveChanges();
            return invoice.InvoiceID; // Trả về mã hóa đơn để sử dụng tiếp
        }
    }
}
