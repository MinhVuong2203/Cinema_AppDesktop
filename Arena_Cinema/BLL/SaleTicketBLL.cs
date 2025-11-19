using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using DTO;
using DAL;

namespace BLL
{
    public class SaleTicketBLL
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

        //lấy danh sách loại, số lượng vé theo showtimeID
        public Dictionary<string, int> GetTicketTypesByShowTimeID(Guid showTimeID)
        {
            return saleTicketDAL.GetTicketTypesByShowTimeID(showTimeID);
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

        //load danh sách ghế của phòng
        public List<Seat> GetSeatsByRoomID(int roomID)
        {
            return saleTicketDAL.GetSeatsByRoomID(roomID);
        }

        public Guid CreateInvoice(Invoice invoice, List<Guid> ticketIds, Dictionary<int, int> productQuantities)
        {
            return saleTicketDAL.CreateInvoice(invoice, ticketIds, productQuantities);
        }
    }
}
