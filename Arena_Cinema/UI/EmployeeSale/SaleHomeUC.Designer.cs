namespace UI.EmployeeSale
{
    partial class SaleHomeUC
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel_SaleArea = new System.Windows.Forms.Panel();
            this.panel_SaleProduct = new System.Windows.Forms.Panel();
            this.lb_SaleProduct_Desc = new System.Windows.Forms.Label();
            this.lb_SaleProduct_Title = new System.Windows.Forms.Label();
            this.btn_SaleProduct = new ReaLTaiizor.Controls.MaterialButton();
            this.panel_SaleTicket = new System.Windows.Forms.Panel();
            this.lb_SaleTicket_Desc = new System.Windows.Forms.Label();
            this.lb_SaleTicket_Title = new System.Windows.Forms.Label();
            this.btn_SaleTicket = new ReaLTaiizor.Controls.MaterialButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.hopePictureBox_ = new ReaLTaiizor.Controls.HopePictureBox();
            this.hopePictureBox_Icon = new ReaLTaiizor.Controls.HopePictureBox();
            this.panelMain.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.panel_SaleArea.SuspendLayout();
            this.panel_SaleProduct.SuspendLayout();
            this.panel_SaleTicket.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelMain.Controls.Add(this.panelWelcome);
            this.panelMain.Controls.Add(this.panel_SaleArea);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(40);
            this.panelMain.Size = new System.Drawing.Size(1630, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.White;
            this.panelWelcome.Controls.Add(this.lblWelcomeMessage);
            this.panelWelcome.Controls.Add(this.lblDateTime);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(40, 40);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelWelcome.Size = new System.Drawing.Size(1550, 120);
            this.panelWelcome.TabIndex = 2;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(30, 20);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(433, 46);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Chào mừng đến bán hàng";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDateTime.Location = new System.Drawing.Point(30, 70);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(1490, 30);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Thứ Hai, 27/01/2026 - 14:30:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_SaleArea
            // 
            this.panel_SaleArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_SaleArea.BackColor = System.Drawing.Color.Transparent;
            this.panel_SaleArea.Controls.Add(this.panel_SaleProduct);
            this.panel_SaleArea.Controls.Add(this.panel_SaleTicket);
            this.panel_SaleArea.Location = new System.Drawing.Point(40, 180);
            this.panel_SaleArea.Name = "panel_SaleArea";
            this.panel_SaleArea.Size = new System.Drawing.Size(1550, 500);
            this.panel_SaleArea.TabIndex = 1;
            // 
            // panel_SaleProduct
            // 
            this.panel_SaleProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_SaleProduct.BackColor = System.Drawing.Color.White;
            this.panel_SaleProduct.Controls.Add(this.lb_SaleProduct_Desc);
            this.panel_SaleProduct.Controls.Add(this.lb_SaleProduct_Title);
            this.panel_SaleProduct.Controls.Add(this.hopePictureBox_);
            this.panel_SaleProduct.Controls.Add(this.btn_SaleProduct);
            this.panel_SaleProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_SaleProduct.Location = new System.Drawing.Point(850, 50);
            this.panel_SaleProduct.Name = "panel_SaleProduct";
            this.panel_SaleProduct.Size = new System.Drawing.Size(500, 400);
            this.panel_SaleProduct.TabIndex = 2;
            // 
            // lb_SaleProduct_Desc
            // 
            this.lb_SaleProduct_Desc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lb_SaleProduct_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lb_SaleProduct_Desc.Location = new System.Drawing.Point(30, 240);
            this.lb_SaleProduct_Desc.Name = "lb_SaleProduct_Desc";
            this.lb_SaleProduct_Desc.Size = new System.Drawing.Size(440, 60);
            this.lb_SaleProduct_Desc.TabIndex = 3;
            this.lb_SaleProduct_Desc.Text = "Bán bắp nước, combo và các sản phẩm khác";
            this.lb_SaleProduct_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_SaleProduct_Title
            // 
            this.lb_SaleProduct_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lb_SaleProduct_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lb_SaleProduct_Title.Location = new System.Drawing.Point(30, 180);
            this.lb_SaleProduct_Title.Name = "lb_SaleProduct_Title";
            this.lb_SaleProduct_Title.Size = new System.Drawing.Size(440, 50);
            this.lb_SaleProduct_Title.TabIndex = 2;
            this.lb_SaleProduct_Title.Text = "🍿 BÁN SẢN PHẨM";
            this.lb_SaleProduct_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SaleProduct
            // 
            this.btn_SaleProduct.AutoSize = false;
            this.btn_SaleProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SaleProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btn_SaleProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaleProduct.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_SaleProduct.Depth = 0;
            this.btn_SaleProduct.FlatAppearance.BorderSize = 0;
            this.btn_SaleProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaleProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SaleProduct.ForeColor = System.Drawing.Color.White;
            this.btn_SaleProduct.HighEmphasis = true;
            this.btn_SaleProduct.Icon = null;
            this.btn_SaleProduct.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_SaleProduct.Location = new System.Drawing.Point(100, 320);
            this.btn_SaleProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SaleProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_SaleProduct.Name = "btn_SaleProduct";
            this.btn_SaleProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_SaleProduct.Size = new System.Drawing.Size(300, 50);
            this.btn_SaleProduct.TabIndex = 0;
            this.btn_SaleProduct.Text = "BẮT ĐẦU BÁN";
            this.btn_SaleProduct.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_SaleProduct.UseAccentColor = false;
            this.btn_SaleProduct.UseVisualStyleBackColor = false;
            this.btn_SaleProduct.Click += new System.EventHandler(this.btn_SaleProduct_Click);
            // 
            // panel_SaleTicket
            // 
            this.panel_SaleTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_SaleTicket.BackColor = System.Drawing.Color.White;
            this.panel_SaleTicket.Controls.Add(this.lb_SaleTicket_Desc);
            this.panel_SaleTicket.Controls.Add(this.lb_SaleTicket_Title);
            this.panel_SaleTicket.Controls.Add(this.hopePictureBox_Icon);
            this.panel_SaleTicket.Controls.Add(this.btn_SaleTicket);
            this.panel_SaleTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_SaleTicket.Location = new System.Drawing.Point(200, 50);
            this.panel_SaleTicket.Name = "panel_SaleTicket";
            this.panel_SaleTicket.Size = new System.Drawing.Size(500, 400);
            this.panel_SaleTicket.TabIndex = 1;
            // 
            // lb_SaleTicket_Desc
            // 
            this.lb_SaleTicket_Desc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lb_SaleTicket_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lb_SaleTicket_Desc.Location = new System.Drawing.Point(30, 240);
            this.lb_SaleTicket_Desc.Name = "lb_SaleTicket_Desc";
            this.lb_SaleTicket_Desc.Size = new System.Drawing.Size(440, 60);
            this.lb_SaleTicket_Desc.TabIndex = 3;
            this.lb_SaleTicket_Desc.Text = "Bán vé xem phim, chọn suất chiếu và ghế ngồi";
            this.lb_SaleTicket_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_SaleTicket_Title
            // 
            this.lb_SaleTicket_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lb_SaleTicket_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lb_SaleTicket_Title.Location = new System.Drawing.Point(30, 180);
            this.lb_SaleTicket_Title.Name = "lb_SaleTicket_Title";
            this.lb_SaleTicket_Title.Size = new System.Drawing.Size(440, 50);
            this.lb_SaleTicket_Title.TabIndex = 2;
            this.lb_SaleTicket_Title.Text = "🎬 BÁN VÉ XEM PHIM";
            this.lb_SaleTicket_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SaleTicket
            // 
            this.btn_SaleTicket.AutoSize = false;
            this.btn_SaleTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SaleTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btn_SaleTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaleTicket.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_SaleTicket.Depth = 0;
            this.btn_SaleTicket.FlatAppearance.BorderSize = 0;
            this.btn_SaleTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaleTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SaleTicket.ForeColor = System.Drawing.Color.White;
            this.btn_SaleTicket.HighEmphasis = true;
            this.btn_SaleTicket.Icon = null;
            this.btn_SaleTicket.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_SaleTicket.Location = new System.Drawing.Point(100, 320);
            this.btn_SaleTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SaleTicket.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_SaleTicket.Name = "btn_SaleTicket";
            this.btn_SaleTicket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_SaleTicket.Size = new System.Drawing.Size(300, 50);
            this.btn_SaleTicket.TabIndex = 0;
            this.btn_SaleTicket.Text = "BẮT ĐẦU BÁN";
            this.btn_SaleTicket.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_SaleTicket.UseAccentColor = false;
            this.btn_SaleTicket.UseVisualStyleBackColor = false;
            this.btn_SaleTicket.Click += new System.EventHandler(this.btn_SaleTicket_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1630, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1630, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🛒 KHU VỰC BÁN HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // hopePictureBox_
            // 
            this.hopePictureBox_.BackColor = System.Drawing.Color.White;
            this.hopePictureBox_.Image = global::UI.Properties.Resources.popcorn3;
            this.hopePictureBox_.Location = new System.Drawing.Point(170, 40);
            this.hopePictureBox_.Name = "hopePictureBox_";
            this.hopePictureBox_.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox_.Size = new System.Drawing.Size(160, 130);
            this.hopePictureBox_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox_.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox_.TabIndex = 1;
            this.hopePictureBox_.TabStop = false;
            this.hopePictureBox_.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopePictureBox_Icon
            // 
            this.hopePictureBox_Icon.BackColor = System.Drawing.Color.White;
            this.hopePictureBox_Icon.Image = global::UI.Properties.Resources.coupon;
            this.hopePictureBox_Icon.Location = new System.Drawing.Point(170, 40);
            this.hopePictureBox_Icon.Name = "hopePictureBox_Icon";
            this.hopePictureBox_Icon.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox_Icon.Size = new System.Drawing.Size(160, 130);
            this.hopePictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox_Icon.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox_Icon.TabIndex = 1;
            this.hopePictureBox_Icon.TabStop = false;
            this.hopePictureBox_Icon.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // SaleHomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "SaleHomeUC";
            this.Size = new System.Drawing.Size(1630, 800);
            this.panelMain.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panel_SaleArea.ResumeLayout(false);
            this.panel_SaleProduct.ResumeLayout(false);
            this.panel_SaleTicket.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #region Component Designer generated code

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel_SaleArea;
        private System.Windows.Forms.Panel panel_SaleProduct;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox_;
        private ReaLTaiizor.Controls.MaterialButton btn_SaleProduct;
        private System.Windows.Forms.Panel panel_SaleTicket;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox_Icon;
        private ReaLTaiizor.Controls.MaterialButton btn_SaleTicket;
        private System.Windows.Forms.Label lb_SaleProduct_Title;
        private System.Windows.Forms.Label lb_SaleTicket_Title;
        private System.Windows.Forms.Label lb_SaleProduct_Desc;
        private System.Windows.Forms.Label lb_SaleTicket_Desc;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerClock;

        #endregion
    }
}