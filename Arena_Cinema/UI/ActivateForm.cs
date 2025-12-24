using Common.Licensing;
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
        private readonly string _connStr;
        private readonly Guid _tenantId;

        public ActivateForm(string connStr, Guid tenantId)
        {
            InitializeComponent();
            _connStr = connStr;
            _tenantId = tenantId;
            lblTenant.Text = "TenantId: " + _tenantId;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            var key = txtKey.Text.Trim();
            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Vui lòng nhập key.");
                return;
            }

            if (AppLicenseManager.ApplyToken(_connStr, key, out var err))
            {
                MessageBox.Show("Kích hoạt thành công. Ứng dụng sẽ khởi động lại.");
                Application.Restart();
            }
            else
            {
                MessageBox.Show(err ?? "Kích hoạt thất bại.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
