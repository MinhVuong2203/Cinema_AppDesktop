namespace UI.Products
{
    partial class ProductAddEditForm
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSave = new ReaLTaiizor.Controls.MaterialButton();
            this.btnChooseImage = new ReaLTaiizor.Controls.MaterialButton();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.txtPrice = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboType = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.lblTitle = new ReaLTaiizor.Controls.BigLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtSoLuongToiDa = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.txtSoLuongToiDa);
            this.panelForm.Controls.Add(this.btnCancel);
            this.panelForm.Controls.Add(this.btnSave);
            this.panelForm.Controls.Add(this.btnChooseImage);
            this.panelForm.Controls.Add(this.picPreview);
            this.panelForm.Controls.Add(this.txtPrice);
            this.panelForm.Controls.Add(this.cboType);
            this.panelForm.Controls.Add(this.txtName);
            this.panelForm.Controls.Add(this.lblTitle);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelForm.Size = new System.Drawing.Size(600, 650);
            this.panelForm.TabIndex = 0;
            this.panelForm.Text = "panel1";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.HighEmphasis = false;
            this.btnCancel.Icon = null;
            this.btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancel.Location = new System.Drawing.Point(413, 579);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = global::UI.Resources.Lang.Huy;
            this.btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSave.Location = new System.Drawing.Point(506, 579);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = global::UI.Resources.Lang.Luu;
            this.btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseImage.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChooseImage.Depth = 0;
            this.btnChooseImage.HighEmphasis = false;
            this.btnChooseImage.Icon = null;
            this.btnChooseImage.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnChooseImage.Location = new System.Drawing.Point(210, 499);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChooseImage.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChooseImage.Size = new System.Drawing.Size(136, 36);
            this.btnChooseImage.TabIndex = 5;
            this.btnChooseImage.Text = global::UI.Resources.Lang.ChonHinhAnh;
            this.btnChooseImage.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnChooseImage.UseAccentColor = false;
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(185, 340);
            this.picPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(199, 150);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 4;
            this.picPreview.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.AnimateReadOnly = false;
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.HideSelection = true;
            this.txtPrice.Hint = global::UI.Resources.Lang.GiaSanPhamVND;
            this.txtPrice.LeadingIcon = null;
            this.txtPrice.Location = new System.Drawing.Point(29, 240);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PrefixSuffixText = null;
            this.txtPrice.ReadOnly = false;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(258, 48);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TabStop = false;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.TrailingIcon = null;
            this.txtPrice.UseSystemPasswordChar = false;
            //this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            // 
            // cboType
            // 
            this.cboType.AutoResize = false;
            this.cboType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboType.Depth = 0;
            this.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboType.DropDownHeight = 174;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.DropDownWidth = 121;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboType.FormattingEnabled = true;
            this.cboType.Hint = global::UI.Resources.Lang.LoaiSanPham;
            this.cboType.IntegralHeight = false;
            this.cboType.ItemHeight = 43;
            this.cboType.Items.AddRange(new object[] {
            "Combo 2 ngăn",
            "Bắp rang vùng",
            "Nước ngọt",
            "Nước đóng chai",
            "Snack - kẹo",
            "Poca",
            "Combo"});
            this.cboType.Location = new System.Drawing.Point(29, 160);
            this.cboType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboType.MaxDropDownItems = 4;
            this.cboType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(540, 49);
            this.cboType.StartIndex = 0;
            this.cboType.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HideSelection = true;
            this.txtName.Hint = global::UI.Resources.Lang.TenSanPham;
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(29, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.MaxLength = 100;
            this.txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(540, 48);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM SẢN PHẨM MỚI";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            this.openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            // 
            // txtSoLuongToiDa
            // 
            this.txtSoLuongToiDa.AnimateReadOnly = false;
            this.txtSoLuongToiDa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSoLuongToiDa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSoLuongToiDa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSoLuongToiDa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoLuongToiDa.Depth = 0;
            this.txtSoLuongToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoLuongToiDa.HideSelection = true;
            this.txtSoLuongToiDa.Hint = "Số lượng tối đa";
            this.txtSoLuongToiDa.LeadingIcon = null;
            this.txtSoLuongToiDa.Location = new System.Drawing.Point(304, 240);
            this.txtSoLuongToiDa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongToiDa.MaxLength = 32767;
            this.txtSoLuongToiDa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSoLuongToiDa.Name = "txtSoLuongToiDa";
            this.txtSoLuongToiDa.PasswordChar = '\0';
            this.txtSoLuongToiDa.PrefixSuffixText = null;
            this.txtSoLuongToiDa.ReadOnly = false;
            this.txtSoLuongToiDa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoLuongToiDa.SelectedText = "";
            this.txtSoLuongToiDa.SelectionLength = 0;
            this.txtSoLuongToiDa.SelectionStart = 0;
            this.txtSoLuongToiDa.ShortcutsEnabled = true;
            this.txtSoLuongToiDa.Size = new System.Drawing.Size(265, 48);
            this.txtSoLuongToiDa.TabIndex = 8;
            this.txtSoLuongToiDa.TabStop = false;
            this.txtSoLuongToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoLuongToiDa.TrailingIcon = null;
            this.txtSoLuongToiDa.UseSystemPasswordChar = false;
            //this.txtSoLuongToiDa.Click += new System.EventHandler(this.txtSoLuongToiDa_Click);
            this.txtSoLuongToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongToiDa_KeyPress);
            // 
            // ProductAddEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sản phẩm";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelForm;
        private ReaLTaiizor.Controls.BigLabel lblTitle;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialComboBox cboType;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrice;
        private System.Windows.Forms.PictureBox picPreview;
        private ReaLTaiizor.Controls.MaterialButton btnChooseImage;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSoLuongToiDa;
    }

    #endregion
}