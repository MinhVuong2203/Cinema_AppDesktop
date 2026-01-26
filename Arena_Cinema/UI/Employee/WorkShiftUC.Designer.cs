namespace UI.Employee
{
    partial class WorkShiftUC
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tblFilter;
        private ReaLTaiizor.Controls.MetroLabel lblRole;
        private ReaLTaiizor.Controls.PoisonComboBox cboRole;
        private ReaLTaiizor.Controls.MetroLabel lblStartDate;
        private ReaLTaiizor.Controls.MetroLabel lblEndDate;
        private ReaLTaiizor.Controls.PoisonDateTime dtpStartDate;
        private ReaLTaiizor.Controls.PoisonDateTime dtpEndDate;
        private ReaLTaiizor.Controls.MetroLabel lblSearch;
        private System.Windows.Forms.Panel pnlBody;
        private WorkShiftVirtualRenderer virtualRenderer;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkShiftUC));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tblFilter = new System.Windows.Forms.TableLayoutPanel();
            this.lblRole = new ReaLTaiizor.Controls.MetroLabel();
            this.cboRole = new ReaLTaiizor.Controls.PoisonComboBox();
            this.lblStartDate = new ReaLTaiizor.Controls.MetroLabel();
            this.dtpStartDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.lblEndDate = new ReaLTaiizor.Controls.MetroLabel();
            this.dtpEndDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.lblSearch = new ReaLTaiizor.Controls.MetroLabel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.virtualRenderer = new UI.Employee.WorkShiftVirtualRenderer();
            this.pnlTop.SuspendLayout();
            this.tblFilter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.tblFilter);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.pnlTop.Size = new System.Drawing.Size(1400, 90);
            this.pnlTop.TabIndex = 0;
            // 
            // tblFilter
            // 
            this.tblFilter.ColumnCount = 8;
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilter.Controls.Add(this.lblRole, 0, 0);
            this.tblFilter.Controls.Add(this.cboRole, 1, 0);
            this.tblFilter.Controls.Add(this.lblStartDate, 2, 0);
            this.tblFilter.Controls.Add(this.dtpStartDate, 3, 0);
            this.tblFilter.Controls.Add(this.lblEndDate, 4, 0);
            this.tblFilter.Controls.Add(this.dtpEndDate, 5, 0);
            this.tblFilter.Controls.Add(this.lblSearch, 6, 0);
            this.tblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilter.Location = new System.Drawing.Point(24, 16);
            this.tblFilter.Margin = new System.Windows.Forms.Padding(0);
            this.tblFilter.Name = "tblFilter";
            this.tblFilter.RowCount = 1;
            this.tblFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilter.Size = new System.Drawing.Size(1352, 58);
            this.tblFilter.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRole.IsDerivedStyle = true;
            this.lblRole.Location = new System.Drawing.Point(3, 16);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(81, 25);
            this.lblRole.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblRole.StyleManager = null;
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = global::UI.Resources.Lang.ChucVu;
            this.lblRole.ThemeAuthor = "Taiizor";
            this.lblRole.ThemeName = "MetroLight";
            // 
            // cboRole
            // 
            this.cboRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.ItemHeight = 24;
            this.cboRole.Location = new System.Drawing.Point(103, 14);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(190, 30);
            this.cboRole.TabIndex = 1;
            this.cboRole.UseSelectable = true;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.IsDerivedStyle = true;
            this.lblStartDate.Location = new System.Drawing.Point(303, 16);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 25);
            this.lblStartDate.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblStartDate.StyleManager = null;
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = global::UI.Resources.Lang.TuNgay;
            this.lblStartDate.ThemeAuthor = "Taiizor";
            this.lblStartDate.ThemeName = "MetroLight";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(393, 14);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(170, 30);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.IsDerivedStyle = true;
            this.lblEndDate.Location = new System.Drawing.Point(573, 4);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(54, 50);
            this.lblEndDate.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblEndDate.StyleManager = null;
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = global::UI.Resources.Lang.DenNgay;
            this.lblEndDate.ThemeAuthor = "Taiizor";
            this.lblEndDate.ThemeName = "MetroLight";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(663, 14);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(170, 30);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearch.IsDerivedStyle = true;
            this.lblSearch.Location = new System.Drawing.Point(843, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblSearch.StyleManager = null;
            this.lblSearch.TabIndex = 6;
            this.lblSearch.ThemeAuthor = "Taiizor";
            this.lblSearch.ThemeName = "MetroLight";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlBody.Controls.Add(this.virtualRenderer);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 90);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 8, 24, 24);
            this.pnlBody.Size = new System.Drawing.Size(1400, 610);
            this.pnlBody.TabIndex = 1;
            // 
            // virtualRenderer
            // 
            this.virtualRenderer.AutoScroll = true;
            this.virtualRenderer.AutoScrollMinSize = new System.Drawing.Size(520, 60);
            this.virtualRenderer.BackColor = System.Drawing.Color.White;
            this.virtualRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.virtualRenderer.EndDate = new System.DateTime(((long)(0)));
            this.virtualRenderer.Location = new System.Drawing.Point(24, 8);
            this.virtualRenderer.Name = "virtualRenderer";
            this.virtualRenderer.Size = new System.Drawing.Size(1352, 578);
            this.virtualRenderer.StartDate = new System.DateTime(((long)(0)));
            this.virtualRenderer.TabIndex = 0;
            // 
            // WorkShiftUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.Name = "WorkShiftUC";
            this.Size = new System.Drawing.Size(1400, 700);
            this.Load += new System.EventHandler(this.WorkShiftUC_Load);
            this.pnlTop.ResumeLayout(false);
            this.tblFilter.ResumeLayout(false);
            this.tblFilter.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
