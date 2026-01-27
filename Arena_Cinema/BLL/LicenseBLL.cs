using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BLL
{
    public class LicenseBLL
    {
        private readonly LicenseDAL _dal;
       
        public LicenseBLL()
        {
            _dal = new LicenseDAL();
          
        }

        // get Guid tenantId
        public Guid getTenantId() => _dal.getTenantId();

        public DTO.License GetLicense() => _dal.GetLicenseByTenantId(getTenantId());

        // Lấy thông tin License kèm validation
        public LicenseInfoViewModel GetLicenseInfo(Guid tenantId)
        {
            var license = _dal.GetLicenseByTenantId(tenantId);
            var appSetting = _dal.GetAppSettingByTenantId(tenantId);
            var activeCount = _dal.CountActiveInstallations(tenantId);

            if (license == null)
            {
                return new LicenseInfoViewModel
                {
                    IsValid = false,
                    ErrorMessage = "Không tìm thấy License"
                };
            }

            var now = DateTime.UtcNow;
            var isExpired = license.ExpiresAtUtc <= now;
            var isRevoked = license.RevokedAtUtc != null;
            var daysRemaining = (license.ExpiresAtUtc - now).Days;

            return new LicenseInfoViewModel
            {
                IsValid = license.IsActive && !isExpired && !isRevoked,
                License = license,
                AppSetting = appSetting,
                ActiveInstallations = activeCount,
                DaysRemaining = daysRemaining,
                IsExpired = isExpired,
                IsRevoked = isRevoked,
                IsNearExpiry = daysRemaining <= 30 && daysRemaining > 0,
                CanActivateMore = activeCount < license.MaxSeats,
                ErrorMessage = isExpired ? "License đã hết hạn" :
                              isRevoked ? "License đã bị thu hồi" :
                              !license.IsActive ? "License không hoạt động" : ""
            };
        }

        // Lấy danh sách installations
        public List<LicenseActivation> GetActivations(Guid tenantId)
        {
            return _dal.GetActivationsByTenantId(tenantId);
        }

        // Block/Unblock installation
        public bool ToggleBlockInstallation(int activationId)
        {
            return _dal.ToggleBlockInstallation(activationId);
        }

        // Xóa installation
        public bool RemoveActivation(int activationId)
        {
            return _dal.DeleteActivation(activationId);
        }

        // Cập nhật LastSeen
        public bool UpdateLastSeen(Guid tenantId, string installId)
        {
            return _dal.UpdateLastSeen(tenantId, installId);
        }

        // Kiểm tra có thể kích hoạt thêm máy không
        public bool CanActivateNewMachine(Guid tenantId)
        {
            var license = _dal.GetLicenseByTenantId(tenantId);
            if (license == null) return false;

            var activeCount = _dal.CountActiveInstallations(tenantId);
            return activeCount < license.MaxSeats && _dal.IsLicenseValid(tenantId);
        }

        // Lấy số slot còn trống
        public int GetAvailableSeats(Guid tenantId)
        {
            var license = _dal.GetLicenseByTenantId(tenantId);
            if (license == null) return 0;

            var activeCount = _dal.CountActiveInstallations(tenantId);
            return Math.Max(0, license.MaxSeats - activeCount);
        }
    }

    // ViewModel để trả về UI
    public class LicenseInfoViewModel
    {
        public bool IsValid { get; set; }
        public DTO.License License { get; set; }
        public AppSetting AppSetting { get; set; }
        public int ActiveInstallations { get; set; }
        public int DaysRemaining { get; set; }
        public bool IsExpired { get; set; }
        public bool IsRevoked { get; set; }
        public bool IsNearExpiry { get; set; }
        public bool CanActivateMore { get; set; }
        public string ErrorMessage { get; set; }
    }
}