using BLL;
using Common;
using DAL;
using DTO;
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
    public partial class ListEmployeeUC : UserControl
    {
        private DTO.Employee _employee;
        private Home _home;

        private EmployeeBLL _employeeBLL = new EmployeeBLL();


        public ListEmployeeUC(Home home, DTO.Employee employee)
        {
            this._employee = employee;
            this._home = home;
            InitializeComponent();
            LoadCboRoles();
            LoadCardEmployees(_employeeBLL.GetAllEmployees());
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new EmployeeHomeUC(_home, _employee));
        }
        
        public void LoadCboRoles()
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("Tất cả");
            RoleDAL roleDAL = new RoleDAL();
            var roles = roleDAL.GetAllRoles();
            foreach (var role in roles)
            {
                cboRole.Items.Add(role.RoleName);
            }
            cboRole.SelectedIndex = 0; // Chọn mục đầu tiên làm mặc định
        }

        public void LoadCardEmployees(List<DTO.Employee> employees)
        {
            // Xóa tất cả card cũ (trừ card mẫu nếu muốn giữ)
            panelEmployeeList.Controls.Clear();

            // Lặp qua danh sách nhân viên và tạo card
            foreach (var emp in employees)
            {
                // Bỏ qua nhân viên đã bị xóa
                if (emp.IsDeleted)
                    continue;

                // Tạo card mới
                ReaLTaiizor.Controls.MaterialCard card = new ReaLTaiizor.Controls.MaterialCard();
                card.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                card.Depth = 0;
                card.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
                card.Margin = new System.Windows.Forms.Padding(3, 20, 8, 3);
                card.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
                card.Padding = new System.Windows.Forms.Padding(15);
                card.Size = new System.Drawing.Size(462, 244);

                // Tạo panel chứa nội dung
                System.Windows.Forms.Panel panelContent = new System.Windows.Forms.Panel();
                panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
                panelContent.Size = new System.Drawing.Size(432, 214);

                // PictureBox - Ảnh nhân viên
                System.Windows.Forms.PictureBox picEmployee = new System.Windows.Forms.PictureBox();
                picEmployee.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
                picEmployee.Location = new System.Drawing.Point(10, 10);
                picEmployee.Size = new System.Drawing.Size(120, 160);
                picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                picEmployee.TabStop = false;

                // Load ảnh nếu có
                if (!string.IsNullOrEmpty(emp.ImageUrl))
                {                  
                    try
                    {
                        ImgHelper.DisplayImageFromRelative(emp.ImageUrl, picEmployee);      
                    }
                    catch (Exception ex)
                    {
                        ImgHelper.DisplayImageFromRelative("Image\\Employee\\employeeDefault.png", picEmployee); 
                    }
                } 
                else
                {
                    ImgHelper.DisplayImageFromRelative("Image\\Employee\\employeeDefault.png", picEmployee);
                }

                    // Label ID
                System.Windows.Forms.Label lblId = new System.Windows.Forms.Label();
                lblId.AutoSize = true;
                lblId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                lblId.ForeColor = System.Drawing.Color.Brown;
                lblId.Location = new System.Drawing.Point(139, 13);
                lblId.Text = $"ID: {emp.EmployeeID.ToString().Substring(0, 8)}...";

                // Label Tên
                System.Windows.Forms.Label lblName = new System.Windows.Forms.Label();
                lblName.AutoSize = true;
                lblName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                lblName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
                lblName.Location = new System.Drawing.Point(136, 35);
                lblName.Text = emp.FullName;
                lblName.MaximumSize = new System.Drawing.Size(300, 0); // Giới hạn độ rộng

                // Label Chức vụ
                System.Windows.Forms.Label lblRole = new System.Windows.Forms.Label();
                lblRole.AutoSize = true;
                lblRole.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
                lblRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                lblRole.ForeColor = System.Drawing.Color.White;
                lblRole.Location = new System.Drawing.Point(138, 71);
                lblRole.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
                lblRole.Text = emp.Role?.RoleName ?? "Chưa xác định";

                // Label Email
                System.Windows.Forms.Label lblEmail = new System.Windows.Forms.Label();
                lblEmail.AutoSize = true;
                lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                lblEmail.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
                lblEmail.Location = new System.Drawing.Point(135, 102);
                lblEmail.Text = $"Email: {emp.Email ?? "Chưa có"}";
                lblEmail.MaximumSize = new System.Drawing.Size(300, 0);

                // Label Phone
                System.Windows.Forms.Label lblPhone = new System.Windows.Forms.Label();
                lblPhone.AutoSize = true;
                lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                lblPhone.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
                lblPhone.Location = new System.Drawing.Point(135, 132);
                lblPhone.Text = $"SĐT: {emp.Phone ?? "Chưa có"}";

                // Nút Sửa
                ReaLTaiizor.Controls.MaterialButton btnEdit = new ReaLTaiizor.Controls.MaterialButton();
                btnEdit.AutoSize = false;
                btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
                btnEdit.Depth = 0;
                btnEdit.HighEmphasis = true;
                btnEdit.Icon = UI.Properties.Resources.edit;
                btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
                btnEdit.Location = new System.Drawing.Point(223, 164);
                btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
                btnEdit.Size = new System.Drawing.Size(100, 42);
                btnEdit.Text = "Sửa";
                btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
                btnEdit.UseAccentColor = false;
                btnEdit.UseVisualStyleBackColor = true;
                btnEdit.Tag = emp.EmployeeID; // Lưu ID để xử lý sự kiện
                btnEdit.Click += BtnEdit_Click; // Gắn sự kiện

                // Nút Xóa
                ReaLTaiizor.Controls.MaterialButton btnDelete = new ReaLTaiizor.Controls.MaterialButton();
                btnDelete.AutoSize = false;
                btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                btnDelete.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
                btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
                btnDelete.Depth = 0;
                btnDelete.HighEmphasis = true;
                btnDelete.Icon = UI.Properties.Resources.trash;
                btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
                btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnDelete.Location = new System.Drawing.Point(327, 163);
                btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
                btnDelete.Size = new System.Drawing.Size(100, 42);
                btnDelete.Text = "Xóa";
                btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
                btnDelete.UseAccentColor = true;
                btnDelete.UseMnemonic = false;
                btnDelete.UseVisualStyleBackColor = false;
                btnDelete.Tag = emp.EmployeeID; // Lưu ID để xử lý sự kiện
                //btnDelete.Click += BtnDelete_Click; // Gắn sự kiện

                // Thêm các control vào panel
                panelContent.Controls.Add(picEmployee);
                panelContent.Controls.Add(lblId);
                panelContent.Controls.Add(lblName);
                panelContent.Controls.Add(lblRole);
                panelContent.Controls.Add(lblEmail);
                panelContent.Controls.Add(lblPhone);
                panelContent.Controls.Add(btnEdit);
                panelContent.Controls.Add(btnDelete);

                // Thêm panel vào card
                card.Controls.Add(panelContent);

                // Thêm card vào FlowLayoutPanel
                panelEmployeeList.Controls.Add(card);
            }
        }

        // Sự kiện nút Sửa
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ReaLTaiizor.Controls.MaterialButton btn = sender as ReaLTaiizor.Controls.MaterialButton;
            if (btn != null && btn.Tag != null)
            {
                Guid employeeId = (Guid)btn.Tag;    
                DialogResult rs = MessageBox.Show($"Nhấn OK để sửa thông tin nhân viên ID: {employeeId}", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    DTO.Employee employeeEdit = _employeeBLL.GetEmployeeById(employeeId);
                    this._home.LoadControl(new AddEmployeeUC(_home, _employee, employeeEdit));
                }
            }
        }

        public void FilterEmployees()
        {
            string selectedRole = cboRole.SelectedItem.ToString();
            bool isDelete = btnWorking.Toggled;
            string nameFilter = txtSearch.Text.Trim();
            string gender = cboGender.SelectedItem.ToString();
            LoadCardEmployees(_employeeBLL.GetEmployeeBy(nameFilter, selectedRole, gender, isDelete));
        }
        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void btnWorking_ToggledChanged()
        {
            FilterEmployees();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new AddEmployeeUC(_home, _employee));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        




        // Sự kiện nút Xóa
        //private void BtnDelete_Click(object sender, EventArgs e)
        //{
        //    ReaLTaiizor.Controls.MaterialButton btn = sender as ReaLTaiizor.Controls.MaterialButton;
        //    if (btn != null && btn.Tag != null)
        //    {
        //        Guid employeeId = (Guid)btn.Tag;

        //        // Xác nhận xóa
        //        DialogResult result = MessageBox.Show(
        //            "Bạn có chắc chắn muốn xóa nhân viên này?",
        //            "Xác nhận xóa",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Question
        //        );

        //        if (result == DialogResult.Yes)
        //        {
        //            // Xử lý xóa nhân viên
        //            bool success = _employeeBLL.DeleteEmployee(employeeId);
        //            if (success)
        //            {
        //                MessageBox.Show("Xóa nhân viên thành công!");
        //                LoadCardEmployees(); // Reload lại danh sách
        //            }
        //            else
        //            {
        //                MessageBox.Show("Xóa nhân viên thất bại!");
        //            }
        //        }
        //    }
        //}


    }
}
