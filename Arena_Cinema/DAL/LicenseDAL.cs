using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DAL
{
    public class LicenseDAL
    {
        private readonly CinemaDBContext _context;

        public LicenseDAL()
        {
            _context = new CinemaDBContext();
        }

        // Lấy License theo TenantId
        public License GetLicenseByTenantId(Guid tenantId)
        {
            return _context.Licenses
                          .FirstOrDefault(l => l.TenantId == tenantId && l.IsActive);
        }

        // Lấy tất cả Licenses
        public List<License> GetAllLicenses()
        {
            return _context.Licenses.ToList();
        }

        // Lấy AppSetting theo TenantId
        public AppSetting GetAppSettingByTenantId(Guid tenantId)
        {
            return _context.AppSettings
                          .FirstOrDefault(s => s.TenantId == tenantId);
        }

        // Lấy tất cả LicenseActivations theo TenantId
        public List<LicenseActivation> GetActivationsByTenantId(Guid tenantId)
        {
            return _context.LicenseActivations
                          .Where(a => a.TenantId == tenantId)
                          .OrderByDescending(a => a.LastSeenAtUtc)
                          .ToList();
        }

        // Đếm số máy đã kích hoạt
        public int CountActiveInstallations(Guid tenantId)
        {
            return _context.LicenseActivations
                          .Count(a => a.TenantId == tenantId && !a.IsBlocked);
        }

        // Kiểm tra License còn hiệu lực
        public bool IsLicenseValid(Guid tenantId)
        {
            var license = GetLicenseByTenantId(tenantId);
            if (license == null) return false;

            return license.IsActive
                   && license.ExpiresAtUtc > DateTime.UtcNow
                   && license.RevokedAtUtc == null;
        }

        // Cập nhật LastSeenAtUtc cho activation
        public bool UpdateLastSeen(Guid tenantId, string installId)
        {
            var activation = _context.LicenseActivations
                                    .FirstOrDefault(a => a.TenantId == tenantId
                                                      && a.InstallId == installId);
            if (activation == null) return false;

            activation.LastSeenAtUtc = DateTime.UtcNow;
            _context.SaveChanges();
            return true;
        }

        // Block/Unblock một installation
        public bool ToggleBlockInstallation(int activationId)
        {
            var activation = _context.LicenseActivations
                                    .FirstOrDefault(a => a.ActivationId == activationId);
            if (activation == null) return false;

            activation.IsBlocked = !activation.IsBlocked;
            _context.SaveChanges();
            return true;
        }

        // Xóa một activation
        public bool DeleteActivation(int activationId)
        {
            var activation = _context.LicenseActivations
                                    .FirstOrDefault(a => a.ActivationId == activationId);
            if (activation == null) return false;

            _context.LicenseActivations.Remove(activation);
            _context.SaveChanges();
            return true;
        }
    }
}