using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    /// <summary>
    /// Data Access Layer cho việc khóa/mở khóa ghế realtime
    /// Quản lý trạng thái LockedBy và LockedAt trong bảng Ticket
    /// </summary>
    public class SeatLockDAL
    {
        private CinemaDBContext _context;

        /// <summary>
        /// Thời gian tự động unlock ghế (phút)
        /// Có thể thay đổi giá trị này tùy theo nhu cầu
        /// </summary>
        public const int LOCK_TIMEOUT_MINUTES = 10;

        public SeatLockDAL()
        {
            _context = new CinemaDBContext();
        }

        /// <summary>
        /// Khóa ghế cho nhân viên khi họ chọn ghế
        /// </summary>
        /// <param name="ticketID">ID của vé cần khóa</param>
        /// <param name="employeeID">ID nhân viên đang chọn ghế</param>
        /// <returns>true nếu khóa thành công, false nếu thất bại</returns>
        public bool LockSeat(Guid ticketID, Guid employeeID)
        {
            try
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == ticketID);
                if (ticket == null)
                {
                    Console.WriteLine($"[LockSeat] Ticket not found: {ticketID}");
                    return false;
                }

                // Kiểm tra ghế đã được bán chưa
                if (ticket.Status == "Đã bán")
                {
                    Console.WriteLine($"[LockSeat] Ticket already sold: {ticketID}");
                    return false;
                }

                // Kiểm tra ghế có đang bị lock bởi người khác không
                if (ticket.LockedBy.HasValue && ticket.LockedBy != employeeID)
                {
                    // Kiểm tra xem lock đã hết hạn chưa
                    if (ticket.LockedAt.HasValue)
                    {
                        var lockAge = DateTime.Now - ticket.LockedAt.Value;
                        if (lockAge.TotalMinutes < LOCK_TIMEOUT_MINUTES)
                        {
                            // Còn trong thời gian lock, không cho phép lock
                            Console.WriteLine($"[LockSeat] Ticket locked by another employee: {ticket.LockedBy}");
                            return false;
                        }
                        else
                        {
                            // Lock đã hết hạn, có thể chiếm lại
                            Console.WriteLine($"[LockSeat] Lock expired, taking over from: {ticket.LockedBy}");
                        }
                    }
                }

                // Thực hiện lock ghế
                ticket.LockedBy = employeeID;
                ticket.LockedAt = DateTime.Now;
                ticket.Status = "Đang giữ chỗ";

                _context.SaveChanges();

                Console.WriteLine($"[LockSeat] Success - Ticket: {ticketID}, Employee: {employeeID}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LockSeat] Error: {ex.Message}");
                throw new Exception($"Lỗi khi khóa ghế: {ex.Message}");
            }
        }

        /// <summary>
        /// Mở khóa ghế khi nhân viên bỏ chọn
        /// </summary>
        /// <param name="ticketID">ID của vé cần mở khóa</param>
        /// <param name="employeeID">ID nhân viên đang mở khóa</param>
        /// <returns>true nếu mở khóa thành công, false nếu thất bại</returns>
        public bool UnlockSeat(Guid ticketID, Guid employeeID)
        {
            try
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == ticketID);
                if (ticket == null)
                {
                    Console.WriteLine($"[UnlockSeat] Ticket not found: {ticketID}");
                    return false;
                }

                // Chỉ cho phép unlock nếu là người đã lock
                if (ticket.LockedBy != employeeID)
                {
                    Console.WriteLine($"[UnlockSeat] Not authorized - LockedBy: {ticket.LockedBy}, Employee: {employeeID}");
                    return false;
                }

                // Thực hiện unlock ghế
                ticket.LockedBy = null;
                ticket.LockedAt = null;
                ticket.Status = "Trống";

                _context.SaveChanges();

                Console.WriteLine($"[UnlockSeat] Success - Ticket: {ticketID}, Employee: {employeeID}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UnlockSeat] Error: {ex.Message}");
                throw new Exception($"Lỗi khi mở khóa ghế: {ex.Message}");
            }
        }

        /// <summary>
        /// Mở khóa tất cả ghế của một nhân viên
        /// Gọi khi nhân viên đóng form hoặc hủy giao dịch
        /// </summary>
        /// <param name="employeeID">ID nhân viên</param>
        /// <returns>Số lượng ghế đã được mở khóa</returns>
        public int UnlockAllSeatsForEmployee(Guid employeeID)
        {
            try
            {
                var lockedTickets = _context.Tickets
                    .Where(t => t.LockedBy == employeeID && t.Status == "Đang giữ chỗ")
                    .ToList();

                int count = lockedTickets.Count;

                foreach (var ticket in lockedTickets)
                {
                    ticket.LockedBy = null;
                    ticket.LockedAt = null;
                    ticket.Status = "Trống";
                }

                _context.SaveChanges();

                Console.WriteLine($"[UnlockAllSeats] Unlocked {count} seats for Employee: {employeeID}");
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UnlockAllSeats] Error: {ex.Message}");
                throw new Exception($"Lỗi khi mở khóa tất cả ghế: {ex.Message}");
            }
        }

        /// <summary>
        /// Tự động mở khóa các ghế đã hết thời gian lock
        /// Được gọi định kỳ bởi background service
        /// </summary>
        /// <returns>Số lượng ghế đã được tự động mở khóa</returns>
        public int AutoUnlockExpiredSeats()
        {
            try
            {
                var expiredTime = DateTime.Now.AddMinutes(-LOCK_TIMEOUT_MINUTES);

                var expiredTickets = _context.Tickets
                    .Where(t => t.LockedBy.HasValue
                            && t.LockedAt.HasValue
                            && t.LockedAt < expiredTime
                            && t.Status == "Đang giữ chỗ")
                    .ToList();

                int count = expiredTickets.Count;

                foreach (var ticket in expiredTickets)
                {
                    Console.WriteLine($"[AutoUnlock] Unlocking expired ticket: {ticket.TicketID}, LockedBy: {ticket.LockedBy}");

                    ticket.LockedBy = null;
                    ticket.LockedAt = null;
                    ticket.Status = "Trống";
                }

                if (count > 0)
                {
                    _context.SaveChanges();
                    Console.WriteLine($"[AutoUnlock] Unlocked {count} expired seats");
                }

                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AutoUnlock] Error: {ex.Message}");
                throw new Exception($"Lỗi khi tự động unlock: {ex.Message}");
            }
        }

        /// <summary>
        /// Kiểm tra ghế có đang bị lock bởi người khác không
        /// </summary>
        /// <param name="ticketID">ID vé cần kiểm tra</param>
        /// <param name="currentEmployeeID">ID nhân viên hiện tại</param>
        /// <returns>true nếu ghế đang bị lock bởi người khác</returns>
        public bool IsLockedByOther(Guid ticketID, Guid currentEmployeeID)
        {
            try
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == ticketID);
                if (ticket == null) return false;

                // Không có ai lock
                if (!ticket.LockedBy.HasValue) return false;

                // Lock bởi chính mình
                if (ticket.LockedBy == currentEmployeeID) return false;

                // Kiểm tra thời gian lock
                if (ticket.LockedAt.HasValue)
                {
                    var lockAge = DateTime.Now - ticket.LockedAt.Value;
                    if (lockAge.TotalMinutes >= LOCK_TIMEOUT_MINUTES)
                    {
                        // Lock đã hết hạn
                        return false;
                    }
                }

                // Đang bị lock bởi người khác
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[IsLockedByOther] Error: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Lấy thông tin lock của ghế
        /// </summary>
        /// <param name="ticketID">ID vé</param>
        /// <returns>Object chứa thông tin lock</returns>
        public TicketLockInfo GetLockInfo(Guid ticketID)
        {
            try
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == ticketID);
                if (ticket == null) return null;

                var employee = ticket.LockedBy.HasValue
                    ? _context.Employees.FirstOrDefault(e => e.EmployeeID == ticket.LockedBy.Value)
                    : null;

                return new TicketLockInfo
                {
                    TicketID = ticket.TicketID,
                    IsLocked = ticket.LockedBy.HasValue,
                    LockedBy = ticket.LockedBy,
                    LockedByName = employee?.FullName,
                    LockedAt = ticket.LockedAt,
                    RemainingMinutes = ticket.LockedAt.HasValue
                        ? Math.Max(0, LOCK_TIMEOUT_MINUTES - (DateTime.Now - ticket.LockedAt.Value).TotalMinutes)
                        : 0
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetLockInfo] Error: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Refresh context để lấy dữ liệu mới nhất từ database
        /// </summary>
        public void RefreshContext()
        {
            _context.Dispose();
            _context = new CinemaDBContext();
        }
    }

    /// <summary>
    /// Class chứa thông tin lock của ghế
    /// </summary>
    public class TicketLockInfo
    {
        public Guid TicketID { get; set; }
        public bool IsLocked { get; set; }
        public Guid? LockedBy { get; set; }
        public string LockedByName { get; set; }
        public DateTime? LockedAt { get; set; }
        public double RemainingMinutes { get; set; }
    }
}