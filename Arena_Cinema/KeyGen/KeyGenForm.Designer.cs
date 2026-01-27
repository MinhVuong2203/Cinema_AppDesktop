using ReaLTaiizor.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeyGen
{
    partial class KeyGenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form Properties
            this.Text = "Trình tạo khóa cấp phép";
            this.Size = new Size(500, 580);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.Sizable = false;

            // Container Panel
            this.panelContainer = new System.Windows.Forms.Panel
            {
                Location = new Point(20, 80),
                Size = new Size(460, 470),
                BackColor = Color.White
            };

            // Title Label
            this.lblTitle = new MaterialLabel
            {
                Location = new Point(0, 10),
                Size = new Size(460, 40),
                Text = "🔑 Trình tạo khóa cấp phép",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 150, 243),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // TenantId Label
            this.lblTenantId = new MaterialLabel
            {
                Location = new Point(20, 70),
                Size = new Size(420, 25),
                Text = "Tenant ID (GUID):",
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64)
            };

            // TenantId TextBox
            this.txtTenantId = new MaterialTextBoxEdit
            {
                Location = new Point(20, 100),
                Size = new Size(420, 48),
                Font = new Font("Segoe UI", 11F),
                Hint = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"
            };

            // MaxSeats Label
            this.lblMaxSeats = new MaterialLabel
            {
                Location = new Point(20, 160),
                Size = new Size(420, 25),
                Text = "Số lượng tối đa:",
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64)
            };

            // MaxSeats TextBox (using MaterialTextBoxEdit)
            this.txtMaxSeats = new MaterialTextBoxEdit
            {
                Location = new Point(20, 190),
                Size = new Size(420, 48),
                Font = new Font("Segoe UI", 11F),
                Text = "1",
                Hint = "Enter number of seats"
            };

            // Plan Label
            this.lblPlan = new MaterialLabel
            {
                Location = new Point(20, 250),
                Size = new Size(420, 25),
                Text = "Loại thời hạn:",
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64)
            };

            // Plan ComboBox
            this.cboPlan = new MaterialComboBox
            {
                Location = new Point(20, 280),
                Size = new Size(420, 48),
                Font = new Font("Segoe UI", 11F)
            };
            this.cboPlan.Items.Add("1Y");
            this.cboPlan.Items.Add("2Y");
            this.cboPlan.Items.Add("LIFETIME");
            this.cboPlan.SelectedIndex = 0;

            // Generate Button
            this.btnGenerate = new MaterialButton
            {
                Location = new Point(20, 365),
                Size = new Size(420, 48),
                Text = "GENERATE LICENSE KEY",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Type = MaterialButton.MaterialButtonType.Contained,
                UseAccentColor = true
            };
            this.btnGenerate.Click += new EventHandler(this.BtnGenerate_Click);

            // Result Label
            this.lblResult = new MaterialLabel
            {
                Location = new Point(20, 405),
                Size = new Size(300, 25),
                Text = "Key đã tạo:",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(76, 175, 80),
                Visible = false
            };

            // Copy Button (small, next to label)
            this.btnCopy = new MaterialButton
            {
                Location = new Point(350, 405),
                Size = new Size(90, 30),
                Text = "COPY",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Type = MaterialButton.MaterialButtonType.Contained,
                UseAccentColor = false,
                Visible = false
            };
            this.btnCopy.Click += new EventHandler(this.BtnCopy_Click);

            // Result TextBox
            this.txtResult = new MaterialTextBoxEdit
            {
                Location = new Point(20, 440),
                Size = new Size(420, 20),
                Font = new Font("Consolas", 8F),
                ReadOnly = true,
                Visible = false
            };

            // Price Label
            this.lblPrice = new MaterialLabel
            {
                Location = new Point(20, 340),
                Size = new Size(420, 25),
                Text = "Giá: 0 VND",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 152, 0) // màu cam
            };


            // Add controls to container
            this.panelContainer.Controls.Add(this.lblTitle);
            this.panelContainer.Controls.Add(this.lblTenantId);
            this.panelContainer.Controls.Add(this.txtTenantId);
            this.panelContainer.Controls.Add(this.lblMaxSeats);
            this.panelContainer.Controls.Add(this.txtMaxSeats);
            this.panelContainer.Controls.Add(this.lblPlan);
            this.panelContainer.Controls.Add(this.cboPlan);
            this.panelContainer.Controls.Add(this.btnGenerate);
            this.panelContainer.Controls.Add(this.lblResult);
            this.panelContainer.Controls.Add(this.btnCopy);
            this.panelContainer.Controls.Add(this.txtResult);
            this.panelContainer.Controls.Add(this.lblPrice);

            // Add container to form
            this.Controls.Add(this.panelContainer);

            this.ResumeLayout(false);
        }

        // TODO: dán PRIVATE KEY XML vào đây (chỉ bạn giữ)
      
        private MaterialTextBoxEdit txtTenantId;
        private MaterialTextBoxEdit txtMaxSeats;
        private MaterialComboBox cboPlan;
        private MaterialButton btnGenerate;
        private MaterialTextBoxEdit txtResult;
        private MaterialLabel lblTitle;
        private MaterialLabel lblTenantId;
        private MaterialLabel lblMaxSeats;
        private MaterialLabel lblPlan;
        private MaterialLabel lblResult;
        private MaterialButton btnCopy;
        private System.Windows.Forms.Panel panelContainer;
        private Control lblPrice;
        #endregion
    }
}