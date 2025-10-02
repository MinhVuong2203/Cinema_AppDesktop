using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void skyButton1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (this.isShow)
            {
                this.btnShowPass.ButtonImage = global::UI.Properties.Resources.CloseEyes;
                isShow = false;
            }
            else
            {
                this.btnShowPass.ButtonImage = global::UI.Properties.Resources.OpenEyes1;
                isShow = true;
            }
                
        }
    }
}
