using BLL;
using Common;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Employee
{
    public partial class AddEmployeeUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private ListEmployeeUC listEmployeeUC;

        private EmployeeBLL _employeesBLL;

        private string pathImg = "Image\\Employee\\emloyeeDefault.png";
        public AddEmployeeUC(Home home, DTO.Employee employee, ListEmployeeUC listEmployeeUC)
        {
            this._home = home;
            this._employee = employee;
            this.listEmployeeUC = listEmployeeUC;
            InitializeComponent();
            LoadCboRoles();
            LoadImage();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _home.LoadControl(listEmployeeUC);
        }

        public void LoadCboRoles()
        {
            RoleDAL roleDAL = new RoleDAL();
            var roles = roleDAL.GetAllRoles();

            // Tạo item mặc định
            var defaultItem = new Role { RoleID = 0, RoleName = "--- Chọn chức vụ ---" };

            // Thêm vào đầu list
            var roleList = new List<Role> { defaultItem };
            roleList.AddRange(roles);

            // Binding vào ComboBox
            cboRole.DataSource = roleList;
            cboRole.DisplayMember = "RoleName";  // Hiển thị tên
            cboRole.ValueMember = "RoleID";      // Giá trị thực
            cboRole.SelectedIndex = 0;
        }

        public void LoadImage()
        {
            ImgHelper.DisplayImageFromRelative(this.pathImg, this.picImage);
        }

        public void setDefaltInfo()
        { 
            this.txtCCCD.Text = string.Empty;
            this.txtFullName.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtHourWage.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtUsername.Text = string.Empty;
            this.cboRole.SelectedIndex = 0;
            this.cboGender.SelectedIndex = 0;
            this.txtAddress.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.pathImg = "Image\\Employee\\emloyeeDefault.png";
            LoadImage();
        }

        private void txtHourWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự
            }
        }

        private void parrotButton1_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (!string.IsNullOrEmpty(this.txtHourWage.Text))
            {
               t = int.Parse(this.txtHourWage.Text);
            }
            t += 1000;
            this.txtHourWage.Text = t.ToString();
            this.txtHourWage.Focus();
        }

        private void parrotButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtHourWage.Text)) { return; }
            int t = int.Parse(this.txtHourWage.Text);
            if (t - 1000 < 0 ) { return; }
            t -= 1000;
            this.txtHourWage.Text = t.ToString();
            this.txtHourWage.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.setDefaltInfo();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            ValidateHepler.ValidateTextBox(this.txtFullName, this.lbCheckName, "Họ và tên", true, @"^[\p{L}\s]+$");
            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            ValidateHepler.ValidateTextBox(this.txtPhone, this.lbCheckPhone, "Số điện thoại", true, @"^0[0-9]{9,10}$", "Số điện thoại phải bắt đầu bằng 0 và có 10-11 chữ số");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateHepler.ValidateTextBox(this.txtEmail, this.lbCheckEmail, "Email", true, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            ValidateHepler.ValidateTextBox(this.txtCCCD, this.lbCheckCCCD, "CCCD", true, @"^[0-9]{9,12}$");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateHepler.ValidateTextBox(this.txtUsername, this.lbCheckUsername, "Tên đăng nhập", false, @"^(?=.*[a-z])(?=.*[A-Z])[a-zA-Z]{6,}$", "Tên đăng nhập phải ít nhất 6 ký tự có hoa và thường");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateHepler.ValidateTextBox(this.txtPassword, this.lbCheckPassword, "Mật khẩu", false, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!])(?=.{6,})", "Mật khẩu phải ít nhất 6 ký tự bao gồm hoa, thường và ký tự đặc biệt");
        }

        private void txtHourWage_TextChanged(object sender, EventArgs e)
        {
            ValidateHepler.ValidateTextBox(this.txtHourWage, this.lbCheckLuong, "Tiền lương", true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (string.IsNullOrEmpty(this.lbCheckName.Text)
              && string.IsNullOrEmpty(this.lbCheckCCCD.Text)
              && string.IsNullOrEmpty(this.lbCheckPhone.Text)
              && string.IsNullOrEmpty(this.lbCheckEmail.Text)
              && string.IsNullOrEmpty(this.lbCheckLuong.Text)
              && string.IsNullOrEmpty(this.lbCheckUsername.Text)
              && string.IsNullOrEmpty(this.lbCheckPassword.Text))
            {
                check = true;
            }

            if (!check)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập!",
                    "Lỗi Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            } else
            {
                try
                {
                    DTO.Employee employee = new DTO.Employee
                    {
                        EmployeeID = Guid.NewGuid(),
                        FullName = txtFullName.Text.Trim(),
                        CCCD = txtCCCD.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim().ToLower(),
                        Address = txtAddress.Text.Trim(),
                        BirthDate = dtpBirthDate.Value,
                        HourWage = int.Parse(txtHourWage.Text.Trim()),
                        Gender = string.IsNullOrEmpty(cboGender.SelectedItem?.ToString()) ? "Nam" : cboGender.SelectedItem.ToString(),
                        ImageUrl = this.pathImg,
                        RoleId = (int.Parse(cboRole.SelectedValue.ToString()) == 0) ? 2 : int.Parse(cboRole.SelectedValue.ToString()),
                        RegisterDate = DateTime.Now,
                        IsDeleted = false
                    };
                    _employeesBLL = new EmployeeBLL();
                    bool rs = _employeesBLL.AddEmployee(employee);
                    if (rs)
                    {
                        MessageBox.Show("Thêm công dân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.setDefaltInfo();
                    }
                    else
                    {
                        MessageBox.Show("Ôi hỏng có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            string pathImg = ImgHelper.UploadImage("Employee", this.picImage);
            Debug.WriteLine("----------- " + pathImg);
        }
    }
}
