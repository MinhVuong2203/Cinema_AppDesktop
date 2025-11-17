using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using DTO;
using DAL;

namespace BLL
{
    internal class SaleTicketBLL
    {
        private readonly SaleTicketDAL saleTicketDAL;
        public SaleTicketBLL()
        {
            saleTicketDAL = new SaleTicketDAL();
        }

        // Lấy danh sách suất chiếu theo MovieID
        public List<ShowTime> GetShowTimesByMovieID(int movieID)
        {
            return saleTicketDAL.GetShowTimesByMovieID(movieID);
        }

        // Lấy danh sách vé
        public List<DTO.Ticket> GetAllTickets()
        {
            return saleTicketDAL.GetAllTickets();
        }

        // Lấy danh sách vé theo ShowTimeID
        public List<Ticket> GetTicketsByShowTimeID(Guid showTimeID)
        {
            return saleTicketDAL.GetTicketsByShowTimeID(showTimeID);
        }

        //danh sach sản phẩm
        public List<Product> GetAllProducts()
        {
            return saleTicketDAL.GetAllProducts();
        }

        // Cập nhật trạng thái vé
        public void UpdateTicketStatus(List<Guid> ticketIDs, string status)
        {
            saleTicketDAL.UpdateTicketStatus(ticketIDs, status);
        }

        //lưu vé đã bán vào payment và cập nhật trạng thái vé
        public void AddPayment(Payment payment, List<Guid> ticketIDs)
        {
            saleTicketDAL.AddPayment(payment, ticketIDs);
            saleTicketDAL.UpdateTicketStatus(ticketIDs, "Đã bán");

        }
    }
}
