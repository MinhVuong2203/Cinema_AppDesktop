using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class CustomerVoucherDAL
    {
        private readonly CinemaDBContext _context;

        public CustomerVoucherDAL()
        {
            _context = new CinemaDBContext();
        }

        // Lấy voucher của khách hàng theo ID và status
        public List<CustomerVoucher> GetByCustomerId(Guid customerId, string status = null)
        {
            var query = _context.CustomerVouchers
                .Include(cv => cv.Voucher)
                .Include(cv => cv.Employee)
                .Where(cv => cv.CustomerID == customerId && !cv.IsDeleted);

            // SỬA LẠI: Không dùng string interpolation trong Where
            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(cv => cv.Status == status);
            }

            return query
                .OrderByDescending(cv => cv.RedeemedDate)
                .ToList();
        }

        // Lấy tất cả voucher của khách hàng
        public List<CustomerVoucher> GetAll(Guid customerId)
        {
            return _context.CustomerVouchers
                .Include(cv => cv.Voucher)
                .Include(cv => cv.Employee)
                .Where(cv => cv.CustomerID == customerId && !cv.IsDeleted)
                .OrderByDescending(cv => cv.RedeemedDate)
                .ToList();
        }

        // Lấy voucher chưa sử dụng
        public List<CustomerVoucher> GetUnusedVouchers(Guid customerId)
        {
            return _context.CustomerVouchers
                .Include(cv => cv.Voucher)
                .Where(cv => cv.CustomerID == customerId
                    && !cv.IsDeleted
                    && cv.Status == "Chưa sử dụng"
                    && cv.ExpiryDate >= DateTime.Now)
                .OrderBy(cv => cv.ExpiryDate)
                .ToList();
        }

        // Lấy voucher đã sử dụng
        public List<CustomerVoucher> GetUsedVouchers(Guid customerId)
        {
            return _context.CustomerVouchers
                .Include(cv => cv.Voucher)
                .Include(cv => cv.Invoice)
                .Where(cv => cv.CustomerID == customerId
                    && !cv.IsDeleted
                    && cv.Status == "Đã sử dụng")
                .OrderByDescending(cv => cv.UsedDate)
                .ToList();
        }

        // Lấy voucher hết hạn
        public List<CustomerVoucher> GetExpiredVouchers(Guid customerId)
        {
            return _context.CustomerVouchers
                .Include(cv => cv.Voucher)
                .Where(cv => cv.CustomerID == customerId
                    && !cv.IsDeleted
                    && (cv.Status == "Hết hạn" || cv.ExpiryDate < DateTime.Now))
                .OrderByDescending(cv => cv.ExpiryDate)
                .ToList();
        }

        // Lấy voucher theo ID
        public CustomerVoucher GetById(Guid customerVoucherId)
        {
            return _context.CustomerVouchers
                .Include(cv => cv.Voucher)
                .Include(cv => cv.Customer)
                .Include(cv => cv.Employee)
                .FirstOrDefault(cv => cv.CustomerVoucherID == customerVoucherId && !cv.IsDeleted);
        }

        // Đổi voucher cho khách hàng
        public (bool success, string message) RedeemVoucher(int voucherId, Guid customerId, Guid employeeId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Lấy voucher
                    var voucher = _context.Vouchers.Find(voucherId);
                    if (voucher == null || voucher.IsDeleted)
                        return (false, "Voucher không tồn tại");

                    if (!voucher.IsActive)
                        return (false, "Voucher không còn hoạt động");

                    // Kiểm tra thời hạn
                    var now = DateTime.Now;
                    if (now < voucher.StartDate || now > voucher.EndDate)
                        return (false, "Voucher chưa có hiệu lực hoặc đã hết hạn");

                    // Kiểm tra số lượng còn lại
                    var remaining = voucher.TotalQuantity - voucher.UsedQuantity;
                    if (remaining <= 0)
                        return (false, "Voucher đã hết số lượng");

                    // Kiểm tra điểm khách hàng
                    var customer = _context.Customers.Find(customerId);
                    if (customer == null)
                        return (false, "Khách hàng không tồn tại");

                    if (customer.Point < voucher.PointRequired)
                        return (false, $"Không đủ điểm. Cần {voucher.PointRequired} điểm, bạn có {customer.Point} điểm");

                    // Kiểm tra số lần đã sử dụng
                    var timesUsed = _context.CustomerVouchers
                        .Count(cv => cv.VoucherID == voucherId
                            && cv.CustomerID == customerId
                            && !cv.IsDeleted);

                    if (timesUsed >= voucher.MaxUsagePerCustomer)
                        return (false, "Đã đạt giới hạn sử dụng voucher này");

                    // Tạo CustomerVoucher
                    var customerVoucher = new CustomerVoucher
                    {
                        CustomerVoucherID = Guid.NewGuid(),
                        VoucherID = voucherId,
                        CustomerID = customerId,
                        RedeemedBy = employeeId,
                        RedeemedDate = DateTime.Now,
                        PointsUsed = voucher.PointRequired,
                        Status = "Chưa sử dụng",
                        ExpiryDate = voucher.EndDate,
                        IsDeleted = false
                    };

                    _context.CustomerVouchers.Add(customerVoucher);

                    // Trừ điểm khách hàng
                    customer.Point -= voucher.PointRequired;

                    // Cập nhật số lượng voucher đã sử dụng
                    voucher.UsedQuantity++;

                    _context.SaveChanges();
                    transaction.Commit();

                    return (true, "Đổi voucher thành công");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return (false, $"Lỗi: {ex.Message}");
                }
            }
        }

        // Áp dụng voucher vào hóa đơn
        public (bool success, string message, decimal discountAmount) ApplyVoucher(
            Guid customerVoucherId,
            Guid invoiceId,
            decimal totalAmount)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var customerVoucher = _context.CustomerVouchers
                        .Include(cv => cv.Voucher)
                        .FirstOrDefault(cv => cv.CustomerVoucherID == customerVoucherId);

                    if (customerVoucher == null)
                        return (false, "Voucher không tồn tại", 0);

                    if (customerVoucher.Status != "Chưa sử dụng")
                        return (false, "Voucher đã được sử dụng hoặc hết hạn", 0);

                    if (customerVoucher.ExpiryDate < DateTime.Now)
                    {
                        customerVoucher.Status = "Hết hạn";
                        _context.SaveChanges();
                        return (false, "Voucher đã hết hạn", 0);
                    }

                    var voucher = customerVoucher.Voucher;

                    if (totalAmount < voucher.MinOrderAmount)
                        return (false, $"Giá trị đơn hàng tối thiểu là {voucher.MinOrderAmount:N0} VNĐ", 0);

                    // Tính tiền giảm
                    decimal discountAmount = 0;
                    if (voucher.DiscountType == "Phần trăm")
                    {
                        discountAmount = totalAmount * voucher.DiscountValue / 100;
                        if (voucher.MaxDiscountAmount.HasValue && discountAmount > voucher.MaxDiscountAmount.Value)
                            discountAmount = voucher.MaxDiscountAmount.Value;
                    }
                    else // Số tiền
                    {
                        discountAmount = voucher.DiscountValue;
                        if (discountAmount > totalAmount)
                            discountAmount = totalAmount;
                    }

                    // Cập nhật trạng thái voucher
                    customerVoucher.Status = "Đã sử dụng";
                    customerVoucher.UsedDate = DateTime.Now;
                    customerVoucher.InvoiceID = invoiceId;

                    _context.SaveChanges();
                    transaction.Commit();

                    return (true, "Áp dụng voucher thành công", discountAmount);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return (false, $"Lỗi: {ex.Message}", 0);
                }
            }
        }

        // Hủy voucher (soft delete)
        public bool CancelVoucher(Guid customerVoucherId)
        {
            try
            {
                var customerVoucher = _context.CustomerVouchers.Find(customerVoucherId);
                if (customerVoucher != null && customerVoucher.Status == "Chưa sử dụng")
                {
                    // Hoàn điểm cho khách hàng
                    var customer = _context.Customers.Find(customerVoucher.CustomerID);
                    if (customer != null)
                    {
                        customer.Point += customerVoucher.PointsUsed;
                    }

                    // Giảm số lượng đã sử dụng của voucher
                    var voucher = _context.Vouchers.Find(customerVoucher.VoucherID);
                    if (voucher != null)
                    {
                        voucher.UsedQuantity--;
                    }

                    customerVoucher.IsDeleted = true;
                    return _context.SaveChanges() > 0;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật trạng thái voucher hết hạn
        public void UpdateExpiredVouchers()
        {
            try
            {
                var now = DateTime.Now;
                var expiredVouchers = _context.CustomerVouchers
                    .Where(cv => cv.Status == "Chưa sử dụng"
                        && cv.ExpiryDate < now
                        && !cv.IsDeleted)
                    .ToList();

                foreach (var voucher in expiredVouchers)
                {
                    voucher.Status = "Hết hạn";
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi cập nhật voucher hết hạn: {ex.Message}");
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}