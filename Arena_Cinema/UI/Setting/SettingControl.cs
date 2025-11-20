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
using UI.Resources;

namespace UI.Setting
{
    public partial class SettingControl : UserControl
    {
        private string lang;
        private string font;
        private string color;
        private int size;
        private Guid emID;

        private EmployeeDAL _employeeDAL = new EmployeeDAL();

        public SettingControl(DTO.Employee employee)
        {
            this.lang = employee.Setting.LanguageCode;
            this.font = employee.Setting.FontText;  
            this.color = employee.Setting.MainColor;
            this.size = employee.Setting.SizeText ?? 12;
            this.emID = employee.EmployeeID;
            InitializeComponent();
        }
        private void cbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbLang.SelectedItem?.ToString();
            this.lang = selected == "Tiếng Anh" ? "en-US" : "vi-VN";
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = this.Font;
                fontDialog.ShowEffects = false;  // ẩn hiệu ứng như gạch chân, gạch chéo

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBox1.Text = fontDialog.Font.Name + ", " + fontDialog.Font.Size;  
                    this.font = fontDialog.Font.Name;
                    this.size = (int)fontDialog.Font.Size;
                }
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
            
            DTO.Setting setting = new DTO.Setting
            {
                LanguageCode = this.lang,
                FontText = this.font,
                MainColor = this.color,
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
                newHome.LoadControl(new SettingControl(em));
                newHome.Show();

                // 🔹 Đóng form cũ sau khi form mới đã show
                parentForm.Hide();
                parentForm.Dispose();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Lấy form chứa UserControl
            Form parent = this.FindForm();

            // Ẩn form cha
            parent.Hide();

            // Mở form login
            Login lg = new Login();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.Show();
        }

    }
}
