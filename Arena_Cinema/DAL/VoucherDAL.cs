using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class VoucherDAL
    {
        private readonly CinemaDBContext _context;
        public VoucherDAL()
        {
            _context = new CinemaDBContext();
        }

        // Lấy tất cả voucher
        public List<Voucher> GetAll()
        {
            return _context.Vouchers
                .Where(v => !v.IsDeleted)
                .Include(v => v.Employee)
                .OrderByDescending(v => v.CreatedDate)
                .ToList();
        }

        // Lấy voucher đang hoạt động
        public List<Voucher> GetActiveVouchers()
        {
            var now = DateTime.Now;
            return _context.Vouchers
                .Where(v => !v.IsDeleted
                    && v.IsActive
                    && v.StartDate <= now
                    && v.EndDate >= now
                    && v.RemainingQuantity > 0)
                .OrderBy(v => v.PointRequired)
                .ToList();
        }

        // Lấy voucher theo code
        public Voucher GetByCode(string voucherCode)
        {
            return _context.Vouchers
                .Include(v => v.Employee)
                .FirstOrDefault(v => v.VoucherCode == voucherCode && !v.IsDeleted);
        }

        // Lấy voucher theo ID
        public Voucher GetById(int id)
        {
            return _context.Vouchers
                .Include(v => v.Employee)
                .Include(v => v.CustomerVouchers)
                .FirstOrDefault(v => v.VoucherID == id);
        }

        // Thêm voucher mới
        public bool Add(Voucher voucher)
        {
            try
            {
                voucher.CreatedDate = DateTime.Now;
                voucher.UsedQuantity = 0;
                _context.Vouchers.Add(voucher);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Cập nhật voucher
        public bool Update(Voucher voucher)
        {
            try
            {
                var existing = _context.Vouchers.Find(voucher.VoucherID);
                if (existing != null)
                {
                    existing.VoucherCode = voucher.VoucherCode;
                    existing.VoucherName = voucher.VoucherName;
                    existing.Description = voucher.Description;
                    existing.DiscountType = voucher.DiscountType;
                    existing.DiscountValue = voucher.DiscountValue;
                    existing.MaxDiscountAmount = voucher.MaxDiscountAmount;
                    existing.MinOrderAmount = voucher.MinOrderAmount;
                    existing.PointRequired = voucher.PointRequired;
                    existing.TotalQuantity = voucher.TotalQuantity;
                    existing.StartDate = voucher.StartDate;
                    existing.EndDate = voucher.EndDate;
                    existing.MaxUsagePerCustomer = voucher.MaxUsagePerCustomer;
                    existing.VoucherCategory = voucher.VoucherCategory;
                    existing.ApplicableFor = voucher.ApplicableFor;
                    existing.ImageUrl = voucher.ImageUrl;
                    existing.IsActive = voucher.IsActive;

                    return _context.SaveChanges() > 0;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Xóa voucher (soft delete)
        public bool Delete(int id)
        {
            try
            {
                var voucher = _context.Vouchers.Find(id);
                if (voucher != null)
                {
                    voucher.IsDeleted = true;
                    voucher.IsActive = false;
                    return _context.SaveChanges() > 0;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Lấy voucher có thể đổi cho khách hàng
        public List<Voucher> GetAvailableVouchersForCustomer(Guid customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer == null) return new List<Voucher>();

            var now = DateTime.Now;
            var customerPoint = customer.Point;

            return _context.Vouchers
                .Where(v => !v.IsDeleted
                    && v.IsActive
                    && v.StartDate <= now
                    && v.EndDate >= now
                    && v.RemainingQuantity > 0
                    && v.PointRequired <= customerPoint)
                .ToList()
                .Where(v =>
                {
                    var timesUsed = _context.CustomerVouchers
                        .Count(cv => cv.VoucherID == v.VoucherID
                            && cv.CustomerID == customerId
                            && !cv.IsDeleted);
                    return timesUsed < v.MaxUsagePerCustomer;
                })
                .OrderBy(v => v.PointRequired)
                .ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
