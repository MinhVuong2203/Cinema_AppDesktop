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
            setCboLang();
            setColor();
            setFont();
        }
        
        private void setFont()
        {
            this.textFont.Text = this.font + ", " + this.size; 
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

        private void BtnFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = this.Font;
                fontDialog.ShowEffects = false;  // ẩn hiệu ứng như gạch chân, gạch chéo

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textFont.Text = fontDialog.Font.Name + ", " + fontDialog.Font.Size;  
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


        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textFont.Text = fontDialog1.Font.Name;
                lblPreview.Font = fontDialog1.Font;
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
    }
}
