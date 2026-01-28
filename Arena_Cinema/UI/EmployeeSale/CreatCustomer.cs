using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace UI.EmployeeSale
{
    public partial class CreatCustomer : Form
    {
        private readonly CinemaDBContext _context;
        private string _phone;

        public CreatCustomer(string phone)
        {
            InitializeComponent();
            _context = new CinemaDBContext();
            _phone = phone;
            txtPhone.Text = phone;
            txtPhone.Enabled = false;
            
            // Set ngày đăng ký là ngày hiện tại
            dtpRegisterDate.Value = DateTime.Now;
        }

        // Tạo khách hàng mới
        public void CreatedCustomer()
        {
            try
            {
                // Validate dữ liệu
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFullName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }

                // Kiểm tra số điện thoại đã tồn tại chưa
                var existingCustomer = _context.Customers
                    .FirstOrDefault(c => c.Phone == txtPhone.Text.Trim() && !c.IsDeleted);

                if (existingCustomer != null)
                {
                    MessageBox.Show("Số điện thoại này đã được đăng ký!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate email format (nếu có nhập)
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    if (!IsValidEmail(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("Email không hợp lệ!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return;
                    }
                }

                // Validate giới tính
                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbGender.Focus();
                    return;
                }

                string phone = txtPhone.Text.Trim();
                string name = txtFullName.Text.Trim();
                string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
                DateTime birthDate = dtpBirthDate.Value;
                string gender = cbGender.Text;
                DateTime registerDate = DateTime.Now; // Ngày hiện tại

                // Tạo đối tượng khách hàng mới
                var customer = new Customer
                {
                    CustomerID = Guid.NewGuid(),
                    Phone = phone,
                    FullName = name,
                    Email = email,
                    BirthDate = birthDate.ToString("yyyy-MM-dd"), // Format chuẩn
                    Gender = gender,
                    RegisterDate = registerDate, // ✅ Thêm dòng này
                    Point = 10, // Khách hàng mới có 0 điểm
                    VipLevel = 0, // Level 0
                    IsDeleted = false
                };

                // Thêm khách hàng vào cơ sở dữ liệu
                _context.Customers.Add(customer);
                _context.SaveChanges();

                MessageBox.Show("Tạo khách hàng thành công!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form với kết quả OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                string errorMessage = "Lỗi validation:\n";
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += $"- {validationError.PropertyName}: {validationError.ErrorMessage}\n";
                    }
                }
                MessageBox.Show(errorMessage, "Lỗi Validation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                string errorMessage = "Lỗi khi lưu vào database:\n";
                if (ex.InnerException?.InnerException != null)
                {
                    errorMessage += ex.InnerException.InnerException.Message;
                    
                    // Kiểm tra lỗi duplicate key
                    if (errorMessage.Contains("UNIQUE KEY") || errorMessage.Contains("duplicate"))
                    {
                        errorMessage = "Số điện thoại này đã được đăng ký trong hệ thống!";
                    }
                }
                else
                {
                    errorMessage += ex.Message;
                }
                
                MessageBox.Show(errorMessage, "Lỗi Database", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreatedCustomer();
        }

    }
}
