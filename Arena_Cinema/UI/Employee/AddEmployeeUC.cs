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
        private bool isEdit = false;
        private Guid EmployeeId;
        private string passOld;

        private EmployeeBLL _employeesBLL;

        private string pathImg = "Image\\Employee\\emloyeeDefault.png";
        public AddEmployeeUC(Home home, DTO.Employee employee) 
        {
            this._home = home;
            this._employee = employee; 
            isEdit = false;
            InitializeComponent();
            this.txtPassword.Hint = "Mật khẩu";
            pathImg = "Image\\Employee\\emloyeeDefault.png";
            LoadCboRoles();
            LoadImage();
        }

        public AddEmployeeUC(Home home, DTO.Employee employee, DTO.Employee employeeEdit)
        { 
            this._home = home;            
            this.pathImg = employeeEdit.ImageUrl;
            this.isEdit = true;
            string gender = employeeEdit.Gender;
            InitializeComponent();
            this.lblTitle.Text = "CẬP NHẬT NHÂN SỰ";
            this.txtPassword.Hint = "Mật khẩu mới";
            this.EmployeeId = employeeEdit.EmployeeID;
            this.passOld = employeeEdit.Account.PasswordHash;

            this.pathImg = employeeEdit.ImageUrl;
            this.txtFullName.Text = employeeEdit.FullName;
            this.txtCCCD.Text = employeeEdit.CCCD;
            this.txtPhone.Text = employeeEdit.Phone;
            this.cboGender.SelectedIndex = (string.IsNullOrEmpty(gender)) ? 0 : (gender == "Nam" ? 1 : 2);
            this.txtEmail.Text = employeeEdit.Email;
            this.txtHourWage.Text = employeeEdit.HourWage.ToString();
            this.txtEmail.Text = employeeEdit.Email;
            this.txtAddress.Text = employeeEdit.Address;
            this.dtpBirthDate.Value = employeeEdit.BirthDate.HasValue ? employeeEdit.BirthDate.Value : DateTime.Now;
            this.txtUsername.Text = employeeEdit.Account.Username;
            LoadCboRoles(employeeEdit);
            LoadImage();
            Reset();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new ListEmployeeUC(_home, _employee));
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
        public void LoadCboRoles(DTO.Employee employeeEdit)
        {
            RoleDAL roleDAL = new RoleDAL();
            var roles = roleDAL.GetAllRoles();
            var defaultItem = new Role { RoleID = 0, RoleName = "--- Chọn chức vụ ---" };         
            var roleList = new List<Role> { defaultItem };
            roleList.AddRange(roles);
            cboRole.DataSource = roleList;
            cboRole.DisplayMember = "RoleName";  // Hiển thị tên
            cboRole.ValueMember = "RoleID";      // Giá trị thực
            if (employeeEdit != null && employeeEdit.RoleId.HasValue)
            {
                cboRole.SelectedValue = employeeEdit.RoleId.Value;
                if (cboRole.SelectedIndex == -1)
                {
                    cboRole.SelectedIndex = 0;
                }
            }
            else
            {
                cboRole.SelectedIndex = 0;
            }
        }
        public void LoadImage()
        {
            ImgHelper.DisplayImageFromRelative(this.pathImg, this.picImage);
        }
        
        public void Reset()
        {
            this.lbCheckCCCD.Text = "";
            this.lbCheckEmail.Text = "";
            this.lbCheckLuong.Text = "";
            this.lbCheckPassword.Text = "";
            this.lbCheckPhone.Text = ""; ;
            this.lbCheckUsername.Text = "";
            this.lbCheckPassword.Text = "";
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
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Xác nhận hủy",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.setDefaltInfo();
            }
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
                if (!this.isEdit)
                {
                    // Chức năng add 
                    string hashedPassword = null;
                    if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim());
                    }                      
                    try
                    {
                        Guid newEmployeeId = Guid.NewGuid();
                        DTO.Employee employee = new DTO.Employee
                        {
                            EmployeeID = newEmployeeId,
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
                            IsDeleted = false,
                            // Gán Account luôn
                            Account = new DTO.Account
                            {
                                EmployeeID = newEmployeeId, 
                                Username = txtUsername.Text.Trim(),
                                PasswordHash = hashedPassword,
                                RoleId = (int.Parse(cboRole.SelectedValue.ToString()) == 0) ? 2 : int.Parse(cboRole.SelectedValue.ToString())
                            }
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
                else
                {
                    // Chức năng Edit
                    string hashedPassword;
                    if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim());
                    }
                    else
                    {
                        hashedPassword = this.passOld;
                    }
                        try
                        {
                            DTO.Employee employee = new DTO.Employee
                            {
                                EmployeeID = this.EmployeeId,
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
                                IsDeleted = false,
                                // Gán Account luôn
                                Account = new DTO.Account
                                {
                                    EmployeeID = this.EmployeeId,
                                    Username = txtUsername.Text.Trim(),
                                    PasswordHash = hashedPassword,
                                    RoleId = (int.Parse(cboRole.SelectedValue.ToString()) == 0) ? 2 : int.Parse(cboRole.SelectedValue.ToString())
                                }
                            };

                            _employeesBLL = new EmployeeBLL();
                            bool rs = _employeesBLL.UpdateEmployee(employee);
                            if (rs)
                            {
                                MessageBox.Show("Cập nhật thông tin công dân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            string pathImg = ImgHelper.UploadImage("Employee", this.picImage);
            if (!string.IsNullOrEmpty(pathImg))    
                this.pathImg = pathImg;
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {           
           if (this.txtPassword.Password == true)
            {
                this.txtPassword.Password = false;
                this.btnShowPass.ButtonImage = global::UI.Properties.Resources.OpenEyes1;
            }
           else
            {
                this.txtPassword.Password = true;
                this.btnShowPass.ButtonImage = global::UI.Properties.Resources.CloseEyes;
            }
           
        }
    }
}
