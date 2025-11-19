using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    internal class SaleProductBLL
    {
        private readonly SaleProductDAL saleProductDAL;
        public SaleProductBLL()
        {
            saleProductDAL = new SaleProductDAL();
        }
        //lấy danh sách các sản phẩm
        public List<DTO.Product> GetAllProducts()
        {
            return saleProductDAL.GetAllProducts();
        }
        //lưu hóa đơn sản phẩm với trạng thái "Chờ thanh toán"
        //public void AddProductInvoice(DTO.Product product, DTO.InvoiceProduct invoiceProduct, DTO.Invoice invoice,
        //    int Quantity, DTO.Employee employee, DTO.Customer customer,
        //    decimal totalAmount, decimal disCount)
        //{
        //    saleProductDAL.AddProductInvoice(product, invoiceProduct, invoice,
        //        Quantity, employee, customer,
        //        totalAmount, disCount);
        //}
        public Guid AddProductInvoice(
                List<DTO.Product> products,
                Dictionary<int, int> productQuantities,
                DTO.Employee employee,
                DTO.Customer customer,
                decimal totalAmount,
                decimal discount)
        {
            return saleProductDAL.AddProductInvoice(
                products,
                productQuantities,
                employee,
                customer,
                totalAmount,
                discount);
        }
    }
}
