using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Employee
{
    public partial class ProfileUC : UserControl
    {
        private DTO.Employee _employee;
        public ProfileUC(DTO.Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            LoadProfileData(employee);
        }

        private void LoadProfileData(DTO.Employee employee)
        {       
            if (employee != null)
            {
                lblName.Text = employee.FullName;
                lblPosition.Text = $"{employee.Role?.RoleName ?? "Nhân viên"}";
                lblPhone.Text = employee.Phone ?? "Chưa cập nhật";
                lblEmail.Text = employee.Email ?? "Chưa cập nhật";
                lblGender.Text = employee.Gender ?? "Chưa cập nhật";
                lblBirth.Text = employee.BirthDate?.ToString("dd/MM/yyyy") ?? "Chưa cập nhật";
                lblCCCD.Text = employee.CCCD ?? "Chưa cập nhật";
                lblRole.Text = employee.Role?.RoleName ?? "Chưa cập nhật";
                lblWage.Text = (employee.HourWage?.ToString("#,##0") ?? "0") + " VNĐ/giờ";
                lblRegister.Text = employee.RegisterDate?.ToString("dd/MM/yyyy") ?? "Chưa cập nhật";
                lblAddressContent.Text = employee.Address ?? "Chưa cập nhật";

                ImgHelper.DisplayImageFromRelative(employee.ImageUrl, picImg);
            }
        }

    }
}
