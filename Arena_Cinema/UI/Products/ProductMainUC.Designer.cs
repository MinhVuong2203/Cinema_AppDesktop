namespace UI.Products
{
    partial class ProductMainUC
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDasc = new ReaLTaiizor.Controls.MaterialButton();
            this.btnAsc = new ReaLTaiizor.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnDaNgung = new ReaLTaiizor.Controls.DungeonToggleButton();
            this.btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            this.txtSearch = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.lblTitle = new ReaLTaiizor.Controls.BigLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnDasc);
            this.panelTop.Controls.Add(this.btnAsc);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.cboType);
            this.panelTop.Controls.Add(this.btnDaNgung);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1630, 100);
            this.panelTop.TabIndex = 0;
            // 
            // btnDasc
            // 
            this.btnDasc.AutoSize = false;
            this.btnDasc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDasc.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDasc.Depth = 0;
            this.btnDasc.HighEmphasis = true;
            this.btnDasc.Icon = global::UI.Properties.Resources.sort;
            this.btnDasc.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnDasc.Location = new System.Drawing.Point(954, 53);
            this.btnDasc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDasc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnDasc.Name = "btnDasc";
            this.btnDasc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDasc.Size = new System.Drawing.Size(44, 38);
            this.btnDasc.TabIndex = 9;
            this.btnDasc.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDasc.UseAccentColor = false;
            this.btnDasc.UseVisualStyleBackColor = true;
            this.btnDasc.Click += new System.EventHandler(this.btnDasc_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.AutoSize = false;
            this.btnAsc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsc.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsc.Depth = 0;
            this.btnAsc.HighEmphasis = true;
            this.btnAsc.Icon = global::UI.Properties.Resources.sort_descending__1_;
            this.btnAsc.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAsc.Location = new System.Drawing.Point(902, 53);
            this.btnAsc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAsc.Size = new System.Drawing.Size(44, 38);
            this.btnAsc.TabIndex = 8;
            this.btnAsc.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAsc.UseAccentColor = false;
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(853, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = global::UI.Resources.Lang.Gia;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1270, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = global::UI.Resources.Lang.NgungBan;
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
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboType.FormattingEnabled = true;
            this.cboType.Hint = global::UI.Resources.Lang.LoaiSanPham;
            this.cboType.IntegralHeight = false;
            this.cboType.ItemHeight = 43;
            this.cboType.Items.AddRange(new object[] {
            "Tất cả",
            "Combo 2 ngăn",
            "Nước ngọt",
            "Nước đóng chai",
            "Snack - kẹo",
            "Poca",
            "Bắp rang vùng",
            "Combo"});
            this.cboType.Location = new System.Drawing.Point(436, 49);
            this.cboType.MaxDropDownItems = 4;
            this.cboType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(373, 49);
            this.cboType.StartIndex = 0;
            this.cboType.TabIndex = 5;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // btnDaNgung
            // 
            this.btnDaNgung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaNgung.Location = new System.Drawing.Point(1388, 59);
            this.btnDaNgung.Name = "btnDaNgung";
            this.btnDaNgung.Size = new System.Drawing.Size(79, 27);
            this.btnDaNgung.TabIndex = 5;
            this.btnDaNgung.Text = "dungeonToggleButton1";
            this.btnDaNgung.Toggled = false;
            this.btnDaNgung.ToggledBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDaNgung.ToggledBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.btnDaNgung.ToggledBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(89)))), ((int)(((byte)(55)))));
            this.btnDaNgung.ToggledBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(89)))), ((int)(((byte)(55)))));
            this.btnDaNgung.ToggledBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnDaNgung.ToggledBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnDaNgung.ToggledColorA = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(58)))));
            this.btnDaNgung.ToggledColorB = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(113)))), ((int)(((byte)(63)))));
            this.btnDaNgung.ToggledColorC = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnDaNgung.ToggledColorD = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnDaNgung.ToggledIOColorA = System.Drawing.Color.WhiteSmoke;
            this.btnDaNgung.ToggledIOColorB = System.Drawing.Color.DimGray;
            this.btnDaNgung.ToggledOnOffColorA = System.Drawing.Color.WhiteSmoke;
            this.btnDaNgung.ToggledOnOffColorB = System.Drawing.Color.DimGray;
            this.btnDaNgung.ToggledYesNoColorA = System.Drawing.Color.WhiteSmoke;
            this.btnDaNgung.ToggledYesNoColorB = System.Drawing.Color.DimGray;
            this.btnDaNgung.Type = ReaLTaiizor.Controls.DungeonToggleButton._Type.OnOff;
            this.btnDaNgung.ToggledChanged += new ReaLTaiizor.Controls.DungeonToggleButton.ToggledChangedEventHandler(this.btnDaNgung_ToggledChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAdd.Location = new System.Drawing.Point(1517, 50);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(93, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = global::UI.Resources.Lang.ThemMoi;
            this.btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.HideSelection = true;
            this.txtSearch.Hint = global::UI.Resources.Lang.TimKiemSanPham;
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(30, 50);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrefixSuffixText = null;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(400, 48);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = global::UI.Resources.Lang.QuanLySanPham;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMain.Controls.Add(this.flowLayoutProducts);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1630, 600);
            this.panelMain.TabIndex = 1;
            // 
            // flowLayoutProducts
            // 
            this.flowLayoutProducts.AutoScroll = true;
            this.flowLayoutProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.flowLayoutProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutProducts.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutProducts.Name = "flowLayoutProducts";
            this.flowLayoutProducts.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutProducts.Size = new System.Drawing.Size(1630, 600);
            this.flowLayoutProducts.TabIndex = 0;
            this.flowLayoutProducts.WrapContents = false;
            // 
            // ProductMainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Name = "ProductMainUC";
            this.Size = new System.Drawing.Size(1630, 700);
            this.Load += new System.EventHandler(this.ProductMainUCcs_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private ReaLTaiizor.Controls.BigLabel lblTitle;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSearch;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProducts;


        #endregion
        private ReaLTaiizor.Controls.DungeonToggleButton btnDaNgung;
        private ReaLTaiizor.Controls.MaterialComboBox cboType;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialButton btnDasc;
        private ReaLTaiizor.Controls.MaterialButton btnAsc;
        private System.Windows.Forms.Label label2;
    }
}
