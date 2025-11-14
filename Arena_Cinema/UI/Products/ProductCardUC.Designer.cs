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
            this.btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            this.btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            this.lblPrice = new ReaLTaiizor.Controls.BigLabel();
            this.lblType = new ReaLTaiizor.Controls.BigLabel();
            this.lblName = new ReaLTaiizor.Controls.BigLabel();
            this.lblId = new ReaLTaiizor.Controls.BigLabel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.panelCard = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.panelCard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.HighEmphasis = false;
            this.btnDelete.Icon = null;
            this.btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnDelete.Location = new System.Drawing.Point(237, 46);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(106, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "NGƯNG BÁN";
            this.btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEdit.Location = new System.Drawing.Point(106, 46);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(93, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "CẬP NHẬT";
            this.btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblPrice.Location = new System.Drawing.Point(752, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(141, 31);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "50.000 VNĐ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(567, 43);
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
            this.lblName.Location = new System.Drawing.Point(315, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 31);
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
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picProduct.Location = new System.Drawing.Point(34, 9);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(100, 100);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
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
            this.panelCard.Name = "panelCard";
            this.panelCard.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.panelCard.PrimerColor = System.Drawing.Color.White;
            this.panelCard.Size = new System.Drawing.Size(1358, 118);
            this.panelCard.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.panelCard.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.panelCard.TabIndex = 1;
            this.panelCard.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.panelCard.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCard.TopRight = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.EdgeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(997, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(361, 118);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 7;
            this.panel1.Text = "panel1";
            // 
            // ProductCardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelCard);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Name = "ProductCardUC";
            this.Size = new System.Drawing.Size(1358, 118);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.PictureBox picProduct;
        private ReaLTaiizor.Controls.BigLabel lblId;
        private ReaLTaiizor.Controls.BigLabel lblName;
        private ReaLTaiizor.Controls.BigLabel lblType;
        private ReaLTaiizor.Controls.BigLabel lblPrice;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel panelCard;
        private ReaLTaiizor.Controls.Panel panel1;
    }
}
