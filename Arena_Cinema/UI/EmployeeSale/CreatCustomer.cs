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

                // Validate email format (nếu có nhập)
                string email = null;
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    string emailInput = txtEmail.Text.Trim();
                    if (!IsValidEmail(emailInput))
                    {
                        MessageBox.Show("Email không hợp lệ!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return;
                    }
                    email = emailInput; // Chỉ gán nếu email hợp lệ
                }
                // Nếu email rỗng, để null hoặc tạo email unique
                else
                {
                    // Tạo email unique tự động để tránh duplicate NULL
                    email = $"customer_{Guid.NewGuid().ToString("N").Substring(0, 4)}@gmail.com";
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
                DateTime birthDate = dtpBirthDate.Value;
                string gender = cbGender.Text;
                DateTime registerDate = DateTime.Now;

                // Tạo đối tượng khách hàng mới
                var customer = new Customer
                {
                    CustomerID = Guid.NewGuid(),
                    Phone = phone,
                    FullName = name,
                    Email = email,
                    BirthDate = birthDate.ToString("yyyy-MM-dd"),
                    Gender = gender,
                    RegisterDate = registerDate,
                    Point = 0,
                    VipLevel = 0,
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
                        Console.WriteLine($"[Validation] {validationError.PropertyName}: {validationError.ErrorMessage}");
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
                    string innerError = ex.InnerException.InnerException.Message;
                    Console.WriteLine($"[DbUpdate Error] {innerError}");
                    
                    // Kiểm tra lỗi duplicate key cụ thể
                    if (innerError.Contains("UNIQUE") || innerError.Contains("duplicate"))
                    {
                        if (innerError.Contains("Phone"))
                        {
                            errorMessage = "Số điện thoại này đã được đăng ký trong hệ thống!";
                        }
                        else if (innerError.Contains("Email"))
                        {
                            errorMessage = "Email này đã được đăng ký trong hệ thống!";
                        }
                        else if (innerError.Contains("NULL"))
                        {
                            errorMessage = "Có trường thông tin bị trùng lặp. Vui lòng kiểm tra lại!";
                        }
                        else
                        {
                            errorMessage = "Dữ liệu đã tồn tại trong hệ thống!";
                        }
                    }
                    else
                    {
                        errorMessage += innerError;
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
                Console.WriteLine($"[Error] {ex.Message}");
                Console.WriteLine($"[StackTrace] {ex.StackTrace}");
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
