using Common;
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
        public SettingControl()
        {
            InitializeComponent();
        }
        private void cbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbLang.SelectedItem?.ToString();
            string langCode = selected == "Tiếng Anh" ? "en-US" : "vi-VN";
            //this.lang
            LanguageHelper.ChangeLanguage(langCode);

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                var bounds = parentForm.Bounds;

                // 🔹 Thay vì Hide+Close, hãy tạo form mới và ShowDialog để tránh crash
                Home newHome = new Home(new DTO.Employee());
                newHome.StartPosition = FormStartPosition.Manual;
                newHome.Bounds = bounds;
                newHome.LoadControl(new SettingControl());
                newHome.Show();

                // 🔹 Đóng form cũ sau khi form mới đã show
                parentForm.Hide();
                parentForm.Dispose();
            }
        }




    }
}
