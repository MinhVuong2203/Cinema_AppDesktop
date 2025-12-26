using BLL;
using Common;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Setting;

namespace UI.Employee
{
    public partial class ProfileUC : UserControl
    {
        private string lang;
        private string font;
        private string color;
        private int size;
        private Guid emID;

        private DTO.Employee _employee;
        private EmployeeDAL _employeeDAL = new EmployeeDAL();
        public ProfileUC(DTO.Employee employee)
        {
            this.lang = employee.Setting.LanguageCode;
            this.font = employee.Setting.FontText;
            this.color = employee.Setting.MainColor;
            this.size = employee.Setting.SizeText ?? 12;
            this.emID = employee.EmployeeID;
            InitializeComponent();
            _employee = employee;
            LoadProfileData(employee);
            LoadThem();
            setCboLang();
            setColor();   
        }

        private void LoadThem()
        {
            Color c = ColorHelper.Parse(_employee.Setting.MainColor);
            this.panelMain.BackColor = c;  
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
        private void setColor()
        {
            if (!string.IsNullOrEmpty(color))
            {
                Color c = StringToColor(color);
                colorPicker.SelectedColor = c;
                lblPreview.BackColor = c;
            }
        }

        private void setCboLang()
        {
            cbLang.Items.Clear();

            if (this.lang == "vi-VN")
            {
                cbLang.Items.Add("Tiếng Việt");
                cbLang.Items.Add("Tiếng Anh");
                cbLang.SelectedIndex = 0;
            }
            else
            {
                cbLang.Items.Add("Vietnamese");
                cbLang.Items.Add("English");
                cbLang.SelectedIndex = 1;
            }
            // hoặc giá trị bạn muốn mặc định
        }


        private void cbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbLang.SelectedItem?.ToString();
            if (selected == "Tiếng Anh" || selected == "English")
            {
                this.lang = "en-US";
            }
            else
            {
                this.lang = "vi-VN";
            }
        }

       

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = this.BackColor;
                colorDialog.AllowFullOpen = true;
                colorDialog.FullOpen = true;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    lblPreview.BackColor = selectedColor;
                    string rgb = $"{selectedColor.R},{selectedColor.G},{selectedColor.B}";
                    this.color = rgb;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Color selected = colorPicker.SelectedColor;
            DTO.Setting setting = new DTO.Setting
            {
                LanguageCode = this.lang,
                FontText = this.font,
                MainColor = ColorToString(selected),
                SizeText = this.size
            };
            _employeeDAL.UpdateEmployeeSettingById(this.emID, setting);

            DTO.Employee em = _employeeDAL.GetEmployeeById(emID);
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                var bounds = parentForm.Bounds;

                // 🔹 Thay vì Hide+Close, hãy tạo form mới và ShowDialog để tránh crash
                Home newHome = new Home(em);
                newHome.StartPosition = FormStartPosition.Manual;
                newHome.Bounds = bounds;
                newHome.LoadControl(new ProfileUC(em));
                newHome.Show();

                // 🔹 Đóng form cũ sau khi form mới đã show
                parentForm.Hide();
                parentForm.Dispose();
            }
        }

        private string ColorToString(Color c)
        {
            return $"{c.A},{c.R},{c.G},{c.B}";
        }


        private Color StringToColor(string colorText)
        {
            if (string.IsNullOrWhiteSpace(colorText))
                return Color.Black;  // fallback

            string[] parts = colorText.Split(',');

            if (parts.Length == 3)
            {
                // RGB
                return Color.FromArgb(
                    255,
                    int.Parse(parts[0]),
                    int.Parse(parts[1]),
                    int.Parse(parts[2])
                );
            }
            else if (parts.Length == 4)
            {
                // ARGB
                return Color.FromArgb(
                    int.Parse(parts[0]),
                    int.Parse(parts[1]),
                    int.Parse(parts[2]),
                    int.Parse(parts[3])
                );
            }

            return Color.Black;
        }

        //private void colorPicker_ColorChanged(object sender, EventArgs e)
        //{
        //}

        private void colorPicker_MouseUp(object sender, MouseEventArgs e)
        {
            Color c = colorPicker.SelectedColor;
            lblPreview.BackColor = c;
        }

        private void colorPicker_ColorChanged(Color color)
        {

            lblPreview.BackColor = color;
        }

        private void skyButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
