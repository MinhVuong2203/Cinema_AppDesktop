namespace UI.Products
{
    partial class ProductCardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrice = new ReaLTaiizor.Controls.BigLabel();
            this.lblType = new ReaLTaiizor.Controls.BigLabel();
            this.lblName = new ReaLTaiizor.Controls.BigLabel();
            this.lblId = new ReaLTaiizor.Controls.BigLabel();
            this.panelCard = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.btnNgungBan = new ReaLTaiizor.Controls.MaterialButton();
            this.btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            this.btnKhoiPhuc = new ReaLTaiizor.Controls.MaterialButton();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.panelCard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblPrice.Location = new System.Drawing.Point(1083, 49);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(138, 30);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "50.000 VNĐ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(749, 42);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(5);
            this.lblType.Size = new System.Drawing.Size(106, 38);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Đồ ăn vặt";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblName.Location = new System.Drawing.Point(273, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 30);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Bắp rang";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblId.Location = new System.Drawing.Point(156, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 28);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "#1";
            // 
            // panelCard
            // 
            this.panelCard.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCard.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCard.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.panelCard.Controls.Add(this.panel1);
            this.panelCard.Controls.Add(this.lblName);
            this.panelCard.Controls.Add(this.picProduct);
            this.panelCard.Controls.Add(this.lblPrice);
            this.panelCard.Controls.Add(this.lblId);
            this.panelCard.Controls.Add(this.lblType);
            this.panelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.panelCard.Location = new System.Drawing.Point(0, 0);
            this.panelCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCard.Name = "panelCard";
            this.panelCard.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.panelCard.PrimerColor = System.Drawing.Color.White;
            this.panelCard.Size = new System.Drawing.Size(1630, 121);
            this.panelCard.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.panelCard.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.panelCard.TabIndex = 1;
            this.panelCard.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.panelCard.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCard.TopRight = System.Drawing.Color.Black;
            this.panelCard.MouseEnter += new System.EventHandler(this.panelCard_MouseEnter);
            this.panelCard.MouseLeave += new System.EventHandler(this.panelCard_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnKhoiPhuc);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnNgungBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.EdgeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1269, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(361, 121);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 7;
            this.panel1.Text = "panel1";
            // 
            // btnNgungBan
            // 
            this.btnNgungBan.AutoSize = false;
            this.btnNgungBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNgungBan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNgungBan.Depth = 0;
            this.btnNgungBan.HighEmphasis = true;
            this.btnNgungBan.Icon = global::UI.Properties.Resources.ban;
            this.btnNgungBan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnNgungBan.Location = new System.Drawing.Point(279, 36);
            this.btnNgungBan.Margin = new System.Windows.Forms.Padding(0);
            this.btnNgungBan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnNgungBan.Name = "btnNgungBan";
            this.btnNgungBan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNgungBan.Size = new System.Drawing.Size(64, 50);
            this.btnNgungBan.TabIndex = 8;
            this.btnNgungBan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNgungBan.UseAccentColor = true;
            this.btnNgungBan.UseVisualStyleBackColor = true;
            this.btnNgungBan.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = global::UI.Properties.Resources.edit;
            this.btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEdit.Location = new System.Drawing.Point(201, 36);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(64, 50);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.AutoSize = false;
            this.btnKhoiPhuc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKhoiPhuc.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKhoiPhuc.Depth = 0;
            this.btnKhoiPhuc.HighEmphasis = true;
            this.btnKhoiPhuc.Icon = global::UI.Properties.Resources.reset1;
            this.btnKhoiPhuc.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(236, 36);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(0);
            this.btnKhoiPhuc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKhoiPhuc.Size = new System.Drawing.Size(64, 50);
            this.btnKhoiPhuc.TabIndex = 8;
            this.btnKhoiPhuc.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKhoiPhuc.UseAccentColor = true;
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picProduct.Location = new System.Drawing.Point(35, 9);
            this.picProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(100, 100);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // ProductCardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCard);
            this.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.Name = "ProductCardUC";
            this.Size = new System.Drawing.Size(1630, 121);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.PictureBox picProduct;
        private ReaLTaiizor.Controls.BigLabel lblId;
        private ReaLTaiizor.Controls.BigLabel lblName;
        private ReaLTaiizor.Controls.BigLabel lblType;
        private ReaLTaiizor.Controls.BigLabel lblPrice;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
        private ReaLTaiizor.Controls.MaterialButton btnKhoiPhuc;


        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel panelCard;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btnNgungBan;
    }
}
