using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ActivateForm : Form
    {
        private readonly string _installId;

        public ActivateForm(string installId, string message)
        {
            InitializeComponent();

            _installId = installId ?? "";
            txtInstallId.Text = _installId;
            lblInfo.Text = message ?? "";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_installId))
            {
                Clipboard.SetText(_installId);
                MessageBox.Show("Đã copy InstallId.");
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            var key = txtKey.Text.Trim();

            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Vui lòng nhập key.");
                return;
            }

            // GỌI ĐÚNG CLASS LICENSE CỦA BẠN Ở ĐÂY:
            // ví dụ: Common.Licensing.AppLicenseManager
            if (Common.AppLicenseManager.Activate(_installId, key, out var err))
            {
                MessageBox.Show("Kích hoạt thành công. Ứng dụng sẽ khởi động lại.");
                Application.Restart();
            }
            else
            {
                MessageBox.Show(err ?? "Key không hợp lệ.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
