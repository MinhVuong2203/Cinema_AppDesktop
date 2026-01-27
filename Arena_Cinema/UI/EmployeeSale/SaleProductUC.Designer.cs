namespace UI.EmployeeSale
{
    partial class SaleProductUC
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProductHeader = new System.Windows.Forms.Panel();
            this.lbProducts = new System.Windows.Forms.Label();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.lbCustomerEmail = new System.Windows.Forms.Label();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.btnCheckCustomer = new ReaLTaiizor.Controls.MaterialButton();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.btn_back = new ReaLTaiizor.Controls.ParrotButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.btnPayment = new ReaLTaiizor.Controls.MaterialButton();
            this.pnlInvoiceTotal = new System.Windows.Forms.Panel();
            this.lbInvoiceTotal = new System.Windows.Forms.Label();
            this.pnlInvoiceContent = new System.Windows.Forms.Panel();
            this.lbInvoiceProducts = new System.Windows.Forms.Label();
            this.lbInvoiceTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlProductHeader.SuspendLayout();
            this.pnlCustomerInfo.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.pnlInvoiceTotal.SuspendLayout();
            this.pnlInvoiceContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1630, 800);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.pnlProducts);
            this.pnlLeft.Controls.Add(this.pnlCustomerInfo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(20, 20);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1090, 760);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.White;
            this.pnlProducts.Controls.Add(this.flpProducts);
            this.pnlProducts.Controls.Add(this.pnlProductHeader);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(0, 140);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(1090, 620);
            this.pnlProducts.TabIndex = 1;
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProducts.Location = new System.Drawing.Point(0, 80);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Padding = new System.Windows.Forms.Padding(15);
            this.flpProducts.Size = new System.Drawing.Size(1090, 540);
            this.flpProducts.TabIndex = 1;
            // 
            // pnlProductHeader
            // 
            this.pnlProductHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlProductHeader.Controls.Add(this.lbProducts);
            this.pnlProductHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlProductHeader.Name = "pnlProductHeader";
            this.pnlProductHeader.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlProductHeader.Size = new System.Drawing.Size(1090, 80);
            this.pnlProductHeader.TabIndex = 0;
            // 
            // lbProducts
            // 
            this.lbProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProducts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbProducts.ForeColor = System.Drawing.Color.White;
            this.lbProducts.Location = new System.Drawing.Point(20, 0);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(1050, 80);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.Text = "🍿 CHỌN ĐỒ ĂN VÀ NƯỚC";
            this.lbProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.BackColor = System.Drawing.Color.White;
            this.pnlCustomerInfo.Controls.Add(this.lbCustomerEmail);
            this.pnlCustomerInfo.Controls.Add(this.lbCustomerPhone);
            this.pnlCustomerInfo.Controls.Add(this.lbCustomerName);
            this.pnlCustomerInfo.Controls.Add(this.btnCheckCustomer);
            this.pnlCustomerInfo.Controls.Add(this.txt_Phone);
            this.pnlCustomerInfo.Controls.Add(this.lblPhoneLabel);
            this.pnlCustomerInfo.Controls.Add(this.btn_back);
            this.pnlCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCustomerInfo.Size = new System.Drawing.Size(1090, 140);
            this.pnlCustomerInfo.TabIndex = 0;
            // 
            // lbCustomerEmail
            // 
            this.lbCustomerEmail.AutoSize = true;
            this.lbCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbCustomerEmail.Location = new System.Drawing.Point(692, 100);
            this.lbCustomerEmail.Name = "lbCustomerEmail";
            this.lbCustomerEmail.Size = new System.Drawing.Size(60, 23);
            this.lbCustomerEmail.TabIndex = 6;
            this.lbCustomerEmail.Text = "Email: ";
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbCustomerPhone.Location = new System.Drawing.Point(692, 70);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(49, 23);
            this.lbCustomerPhone.TabIndex = 5;
            this.lbCustomerPhone.Text = "SĐT: ";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbCustomerName.Location = new System.Drawing.Point(692, 35);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(184, 25);
            this.lbCustomerName.TabIndex = 4;
            this.lbCustomerName.Text = "Tên khách hàng: ---";
            // 
            // btnCheckCustomer
            // 
            this.btnCheckCustomer.AutoSize = false;
            this.btnCheckCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnCheckCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCustomer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckCustomer.Depth = 0;
            this.btnCheckCustomer.FlatAppearance.BorderSize = 0;
            this.btnCheckCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCheckCustomer.HighEmphasis = true;
            this.btnCheckCustomer.Icon = null;
            this.btnCheckCustomer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCheckCustomer.Location = new System.Drawing.Point(542, 30);
            this.btnCheckCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckCustomer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCheckCustomer.Name = "btnCheckCustomer";
            this.btnCheckCustomer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckCustomer.Size = new System.Drawing.Size(120, 45);
            this.btnCheckCustomer.TabIndex = 3;
            this.btnCheckCustomer.Text = "🔍 Kiểm tra";
            this.btnCheckCustomer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckCustomer.UseAccentColor = false;
            this.btnCheckCustomer.UseVisualStyleBackColor = false;
            this.btnCheckCustomer.Click += new System.EventHandler(this.btnCheckCustomer_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Phone.Location = new System.Drawing.Point(292, 35);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(230, 34);
            this.txt_Phone.TabIndex = 2;
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_Phone_TextChanged);
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblPhoneLabel.Location = new System.Drawing.Point(100, 38);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(177, 28);
            this.lblPhoneLabel.TabIndex = 1;
            this.lblPhoneLabel.Text = "📞 Số điện thoại:";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundColor = System.Drawing.Color.White;
            this.btn_back.ButtonImage = global::UI.Properties.Resources.chevrons;
            this.btn_back.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btn_back.ButtonText = "";
            this.btn_back.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btn_back.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btn_back.CornerRadius = 10;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_back.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btn_back.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btn_back.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Center;
            this.btn_back.Location = new System.Drawing.Point(20, 20);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 60);
            this.btn_back.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_back.TabIndex = 0;
            this.btn_back.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btn_back.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_back.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlInvoice);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1110, 20);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlRight.Size = new System.Drawing.Size(500, 760);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.White;
            this.pnlInvoice.Controls.Add(this.btnPayment);
            this.pnlInvoice.Controls.Add(this.pnlInvoiceTotal);
            this.pnlInvoice.Controls.Add(this.pnlInvoiceContent);
            this.pnlInvoice.Controls.Add(this.lbInvoiceTitle);
            this.pnlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoice.Location = new System.Drawing.Point(10, 0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(490, 760);
            this.pnlInvoice.TabIndex = 0;
            // 
            // btnPayment
            // 
            this.btnPayment.AutoSize = false;
            this.btnPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPayment.Depth = 0;
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.HighEmphasis = true;
            this.btnPayment.Icon = null;
            this.btnPayment.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnPayment.Location = new System.Drawing.Point(0, 690);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(25);
            this.btnPayment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPayment.Padding = new System.Windows.Forms.Padding(25);
            this.btnPayment.Size = new System.Drawing.Size(490, 70);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "💳 THANH TOÁN";
            this.btnPayment.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPayment.UseAccentColor = false;
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // pnlInvoiceTotal
            // 
            this.pnlInvoiceTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.pnlInvoiceTotal.Controls.Add(this.lbInvoiceTotal);
            this.pnlInvoiceTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceTotal.Location = new System.Drawing.Point(0, 580);
            this.pnlInvoiceTotal.Name = "pnlInvoiceTotal";
            this.pnlInvoiceTotal.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInvoiceTotal.Size = new System.Drawing.Size(490, 100);
            this.pnlInvoiceTotal.TabIndex = 2;
            // 
            // lbInvoiceTotal
            // 
            this.lbInvoiceTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInvoiceTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lbInvoiceTotal.Location = new System.Drawing.Point(20, 20);
            this.lbInvoiceTotal.Name = "lbInvoiceTotal";
            this.lbInvoiceTotal.Size = new System.Drawing.Size(450, 60);
            this.lbInvoiceTotal.TabIndex = 0;
            this.lbInvoiceTotal.Text = "Tổng tiền: 0 ₫";
            this.lbInvoiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInvoiceContent
            // 
            this.pnlInvoiceContent.AutoScroll = true;
            this.pnlInvoiceContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlInvoiceContent.Controls.Add(this.lbInvoiceProducts);
            this.pnlInvoiceContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceContent.Location = new System.Drawing.Point(0, 80);
            this.pnlInvoiceContent.Name = "pnlInvoiceContent";
            this.pnlInvoiceContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInvoiceContent.Size = new System.Drawing.Size(490, 500);
            this.pnlInvoiceContent.TabIndex = 1;
            // 
            // lbInvoiceProducts
            // 
            this.lbInvoiceProducts.AutoSize = true;
            this.lbInvoiceProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInvoiceProducts.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbInvoiceProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lbInvoiceProducts.Location = new System.Drawing.Point(20, 20);
            this.lbInvoiceProducts.MaximumSize = new System.Drawing.Size(450, 0);
            this.lbInvoiceProducts.Name = "lbInvoiceProducts";
            this.lbInvoiceProducts.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbInvoiceProducts.Size = new System.Drawing.Size(173, 35);
            this.lbInvoiceProducts.TabIndex = 0;
            this.lbInvoiceProducts.Text = "Sản phẩm đã chọn:";
            // 
            // lbInvoiceTitle
            // 
            this.lbInvoiceTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbInvoiceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTitle.ForeColor = System.Drawing.Color.White;
            this.lbInvoiceTitle.Location = new System.Drawing.Point(0, 0);
            this.lbInvoiceTitle.Name = "lbInvoiceTitle";
            this.lbInvoiceTitle.Padding = new System.Windows.Forms.Padding(20);
            this.lbInvoiceTitle.Size = new System.Drawing.Size(490, 80);
            this.lbInvoiceTitle.TabIndex = 0;
            this.lbInvoiceTitle.Text = "🧾 GIỎ HÀNG";
            this.lbInvoiceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaleProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "SaleProductUC";
            this.Size = new System.Drawing.Size(1630, 800);
            this.pnlMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlProductHeader.ResumeLayout(false);
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoiceTotal.ResumeLayout(false);
            this.pnlInvoiceContent.ResumeLayout(false);
            this.pnlInvoiceContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Component Designer generated code

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Panel pnlProductHeader;
        private System.Windows.Forms.Label lbProducts;
        private ReaLTaiizor.Controls.ParrotButton btn_back;
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.TextBox txt_Phone;
        private ReaLTaiizor.Controls.MaterialButton btnCheckCustomer;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.Label lbCustomerEmail;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Label lbInvoiceTitle;
        private System.Windows.Forms.Panel pnlInvoiceContent;
        private System.Windows.Forms.Label lbInvoiceProducts;
        private System.Windows.Forms.Panel pnlInvoiceTotal;
        private System.Windows.Forms.Label lbInvoiceTotal;
        private ReaLTaiizor.Controls.MaterialButton btnPayment;

        #endregion
    }
}
