namespace UI.Voucher
{
    partial class VoucherSelectionUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Các control chính
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TabControl tabControl;

        // Tab 1: Chọn Voucher
        private System.Windows.Forms.TabPage tabSelectVoucher;
        private System.Windows.Forms.FlowLayoutPanel flpSelectVouchers;

        // Tab 2: Đổi Voucher
        private System.Windows.Forms.TabPage tabRedeemVoucher;
        private System.Windows.Forms.FlowLayoutPanel flpRedeemVouchers;

        // Labels & Buttons
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblCustomerInfo;

        private System.Windows.Forms.Label lblSelectVoucherCount;
        private System.Windows.Forms.Label lblRedeemVoucherCount;

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClearVoucher;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblSelectVoucherCount = new System.Windows.Forms.Label();
            this.lblRedeemVoucherCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClearVoucher = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSelectVoucher = new System.Windows.Forms.TabPage();
            this.flpSelectVouchers = new System.Windows.Forms.FlowLayoutPanel();
            this.tabRedeemVoucher = new System.Windows.Forms.TabPage();
            this.flpRedeemVouchers = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSelectVoucher.SuspendLayout();
            this.tabRedeemVoucher.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblOrderTotal);
            this.panelHeader.Controls.Add(this.lblCustomerInfo);
            this.panelHeader.Controls.Add(this.lblSelectVoucherCount);
            this.panelHeader.Controls.Add(this.lblRedeemVoucherCount);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.btnClearVoucher);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 130);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎫 QUẢN LÝ VOUCHER";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblOrderTotal.Location = new System.Drawing.Point(20, 55);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(400, 25);
            this.lblOrderTotal.TabIndex = 1;
            this.lblOrderTotal.Text = "Tổng đơn hàng: 0 ₫";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCustomerInfo.Location = new System.Drawing.Point(20, 85);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(500, 25);
            this.lblCustomerInfo.TabIndex = 2;
            this.lblCustomerInfo.Text = "Khách hàng: ---";
            // 
            // lblSelectVoucherCount
            // 
            this.lblSelectVoucherCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVoucherCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSelectVoucherCount.Location = new System.Drawing.Point(430, 20);
            this.lblSelectVoucherCount.Name = "lblSelectVoucherCount";
            this.lblSelectVoucherCount.Size = new System.Drawing.Size(350, 25);
            this.lblSelectVoucherCount.TabIndex = 3;
            this.lblSelectVoucherCount.Text = "0 voucher khả dụng";
            this.lblSelectVoucherCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRedeemVoucherCount
            // 
            this.lblRedeemVoucherCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedeemVoucherCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.lblRedeemVoucherCount.Location = new System.Drawing.Point(430, 20);
            this.lblRedeemVoucherCount.Name = "lblRedeemVoucherCount";
            this.lblRedeemVoucherCount.Size = new System.Drawing.Size(350, 25);
            this.lblRedeemVoucherCount.TabIndex = 6;
            this.lblRedeemVoucherCount.Text = "0 voucher có thể đổi";
            this.lblRedeemVoucherCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblRedeemVoucherCount.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(660, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "✕ Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnClearVoucher
            // 
            this.btnClearVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClearVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearVoucher.FlatAppearance.BorderSize = 0;
            this.btnClearVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearVoucher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearVoucher.ForeColor = System.Drawing.Color.White;
            this.btnClearVoucher.Location = new System.Drawing.Point(526, 65);
            this.btnClearVoucher.Name = "btnClearVoucher";
            this.btnClearVoucher.Size = new System.Drawing.Size(124, 40);
            this.btnClearVoucher.TabIndex = 5;
            this.btnClearVoucher.Text = "Bỏ voucher";
            this.btnClearVoucher.UseVisualStyleBackColor = false;
            //this.btnClearVoucher.Click += new System.EventHandler(this.btnClearVoucher_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.tabControl);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 130);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(800, 470);
            this.panelContent.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSelectVoucher);
            this.tabControl.Controls.Add(this.tabRedeemVoucher);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(150, 35);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(20, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(780, 450);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabSelectVoucher
            // 
            this.tabSelectVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.tabSelectVoucher.Controls.Add(this.flpSelectVouchers);
            this.tabSelectVoucher.Location = new System.Drawing.Point(4, 39);
            this.tabSelectVoucher.Name = "tabSelectVoucher";
            this.tabSelectVoucher.Padding = new System.Windows.Forms.Padding(10);
            this.tabSelectVoucher.Size = new System.Drawing.Size(772, 407);
            this.tabSelectVoucher.TabIndex = 0;
            this.tabSelectVoucher.Text = "🎫 Chọn Voucher";
            // 
            // flpSelectVouchers
            // 
            this.flpSelectVouchers.AutoScroll = true;
            this.flpSelectVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSelectVouchers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSelectVouchers.Location = new System.Drawing.Point(10, 10);
            this.flpSelectVouchers.Name = "flpSelectVouchers";
            this.flpSelectVouchers.Size = new System.Drawing.Size(752, 387);
            this.flpSelectVouchers.TabIndex = 0;
            this.flpSelectVouchers.WrapContents = false;
            // 
            // tabRedeemVoucher
            // 
            this.tabRedeemVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.tabRedeemVoucher.Controls.Add(this.flpRedeemVouchers);
            this.tabRedeemVoucher.Location = new System.Drawing.Point(4, 39);
            this.tabRedeemVoucher.Name = "tabRedeemVoucher";
            this.tabRedeemVoucher.Padding = new System.Windows.Forms.Padding(10);
            this.tabRedeemVoucher.Size = new System.Drawing.Size(772, 407);
            this.tabRedeemVoucher.TabIndex = 1;
            this.tabRedeemVoucher.Text = "🎁 Đổi Voucher";
            // 
            // flpRedeemVouchers
            // 
            this.flpRedeemVouchers.AutoScroll = true;
            this.flpRedeemVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRedeemVouchers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRedeemVouchers.Location = new System.Drawing.Point(10, 10);
            this.flpRedeemVouchers.Name = "flpRedeemVouchers";
            this.flpRedeemVouchers.Size = new System.Drawing.Size(752, 387);
            this.flpRedeemVouchers.TabIndex = 0;
            this.flpRedeemVouchers.WrapContents = false;
            // 
            // VoucherSelectionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "VoucherSelectionUC";
            this.Size = new System.Drawing.Size(800, 600);
            this.panelHeader.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabSelectVoucher.ResumeLayout(false);
            this.tabRedeemVoucher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}