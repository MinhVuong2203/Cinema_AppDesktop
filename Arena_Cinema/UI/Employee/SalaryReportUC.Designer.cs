using System.Windows.Forms;

namespace UI.Employee
{
    partial class SalaryReportUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ReaLTaiizor.Controls.PoisonLabel lblTitle;
        private System.Windows.Forms.Panel pnlFilters;
        private ReaLTaiizor.Controls.MetroLabel lblRole;
        private ReaLTaiizor.Controls.PoisonComboBox cboRole;
        private ReaLTaiizor.Controls.MetroLabel lblStart;
        private ReaLTaiizor.Controls.PoisonDateTime dtpStartDate;
        private ReaLTaiizor.Controls.MetroLabel lblEnd;
        private ReaLTaiizor.Controls.PoisonDateTime dtpEndDate;

        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel cardTotalEmp;
        private System.Windows.Forms.Panel cardTotalSalary;
        private System.Windows.Forms.Panel cardTotalDone;
        private System.Windows.Forms.Panel cardTotalAbsent;
        private ReaLTaiizor.Controls.MetroLabel lblTotalEmpTitle;
        private ReaLTaiizor.Controls.MetroLabel lblTotalSalaryTitle;
        private ReaLTaiizor.Controls.MetroLabel lblTotalDoneTitle;
        private ReaLTaiizor.Controls.MetroLabel lblTotalAbsentTitle;
        private ReaLTaiizor.Controls.MetroLabel lblTotalEmployee;
        private ReaLTaiizor.Controls.MetroLabel lblTotalSalary;
        private ReaLTaiizor.Controls.MetroLabel lblTotalDone;
        private ReaLTaiizor.Controls.MetroLabel lblTotalAbsent;

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.lblTitle = new ReaLTaiizor.Controls.PoisonLabel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.dtpEndDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.lblEnd = new ReaLTaiizor.Controls.MetroLabel();
            this.dtpStartDate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.lblStart = new ReaLTaiizor.Controls.MetroLabel();
            this.cboRole = new ReaLTaiizor.Controls.PoisonComboBox();
            this.lblRole = new ReaLTaiizor.Controls.MetroLabel();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.cardTotalAbsent = new System.Windows.Forms.Panel();
            this.lblTotalAbsent = new ReaLTaiizor.Controls.MetroLabel();
            this.lblTotalAbsentTitle = new ReaLTaiizor.Controls.MetroLabel();
            this.cardTotalDone = new System.Windows.Forms.Panel();
            this.lblTotalDone = new ReaLTaiizor.Controls.MetroLabel();
            this.lblTotalDoneTitle = new ReaLTaiizor.Controls.MetroLabel();
            this.cardTotalSalary = new System.Windows.Forms.Panel();
            this.lblTotalSalary = new ReaLTaiizor.Controls.MetroLabel();
            this.lblTotalSalaryTitle = new ReaLTaiizor.Controls.MetroLabel();
            this.cardTotalEmp = new System.Windows.Forms.Panel();
            this.lblTotalEmployee = new ReaLTaiizor.Controls.MetroLabel();
            this.lblTotalEmpTitle = new ReaLTaiizor.Controls.MetroLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlFilters.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.cardTotalAbsent.SuspendLayout();
            this.cardTotalDone.SuspendLayout();
            this.cardTotalSalary.SuspendLayout();
            this.cardTotalEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.lblTitle.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Thống kê lương và hiệu suất làm việc";
            this.lblTitle.UseCustomBackColor = true;
            this.lblTitle.UseCustomForeColor = true;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.dtpEndDate);
            this.pnlFilters.Controls.Add(this.lblEnd);
            this.pnlFilters.Controls.Add(this.dtpStartDate);
            this.pnlFilters.Controls.Add(this.lblStart);
            this.pnlFilters.Controls.Add(this.cboRole);
            this.pnlFilters.Controls.Add(this.lblRole);
            this.pnlFilters.Location = new System.Drawing.Point(20, 55);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1260, 90);
            this.pnlFilters.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(563, 38);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(180, 30);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEnd.IsDerivedStyle = true;
            this.lblEnd.Location = new System.Drawing.Point(563, 5);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(96, 25);
            this.lblEnd.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblEnd.StyleManager = null;
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "Đến ngày";
            this.lblEnd.ThemeAuthor = "Taiizor";
            this.lblEnd.ThemeName = "MetroLight";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(360, 38);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(180, 30);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStart.IsDerivedStyle = true;
            this.lblStart.Location = new System.Drawing.Point(360, 5);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(84, 25);
            this.lblStart.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblStart.StyleManager = null;
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Từ ngày";
            this.lblStart.ThemeAuthor = "Taiizor";
            this.lblStart.ThemeName = "MetroLight";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.ItemHeight = 24;
            this.cboRole.Location = new System.Drawing.Point(10, 38);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(330, 30);
            this.cboRole.TabIndex = 7;
            this.cboRole.UseSelectable = true;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRole.IsDerivedStyle = true;
            this.lblRole.Location = new System.Drawing.Point(10, 5);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(85, 25);
            this.lblRole.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblRole.StyleManager = null;
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Chức vụ";
            this.lblRole.ThemeAuthor = "Taiizor";
            this.lblRole.ThemeName = "MetroLight";
            // 
            // pnlSummary
            // 
            this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSummary.BackColor = System.Drawing.Color.Transparent;
            this.pnlSummary.Controls.Add(this.cardTotalAbsent);
            this.pnlSummary.Controls.Add(this.cardTotalDone);
            this.pnlSummary.Controls.Add(this.cardTotalSalary);
            this.pnlSummary.Controls.Add(this.cardTotalEmp);
            this.pnlSummary.Location = new System.Drawing.Point(20, 155);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(1260, 90);
            this.pnlSummary.TabIndex = 1;
            // 
            // cardTotalAbsent
            // 
            this.cardTotalAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cardTotalAbsent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalAbsent.Controls.Add(this.lblTotalAbsent);
            this.cardTotalAbsent.Controls.Add(this.lblTotalAbsentTitle);
            this.cardTotalAbsent.Location = new System.Drawing.Point(795, 5);
            this.cardTotalAbsent.Name = "cardTotalAbsent";
            this.cardTotalAbsent.Size = new System.Drawing.Size(250, 80);
            this.cardTotalAbsent.TabIndex = 0;
            // 
            // lblTotalAbsent
            // 
            this.lblTotalAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalAbsent.IsDerivedStyle = true;
            this.lblTotalAbsent.Location = new System.Drawing.Point(10, 35);
            this.lblTotalAbsent.Name = "lblTotalAbsent";
            this.lblTotalAbsent.Size = new System.Drawing.Size(230, 30);
            this.lblTotalAbsent.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblTotalAbsent.StyleManager = null;
            this.lblTotalAbsent.TabIndex = 0;
            this.lblTotalAbsent.Text = "0";
            this.lblTotalAbsent.ThemeAuthor = "Taiizor";
            this.lblTotalAbsent.ThemeName = "MetroLight";
            // 
            // lblTotalAbsentTitle
            // 
            this.lblTotalAbsentTitle.AutoSize = true;
            this.lblTotalAbsentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalAbsentTitle.IsDerivedStyle = true;
            this.lblTotalAbsentTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTotalAbsentTitle.Name = "lblTotalAbsentTitle";
            this.lblTotalAbsentTitle.Size = new System.Drawing.Size(132, 25);
            this.lblTotalAbsentTitle.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblTotalAbsentTitle.StyleManager = null;
            this.lblTotalAbsentTitle.TabIndex = 1;
            this.lblTotalAbsentTitle.Text = "Tổng ca vắng";
            this.lblTotalAbsentTitle.ThemeAuthor = "Taiizor";
            this.lblTotalAbsentTitle.ThemeName = "MetroLight";
            // 
            // cardTotalDone
            // 
            this.cardTotalDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardTotalDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalDone.Controls.Add(this.lblTotalDone);
            this.cardTotalDone.Controls.Add(this.lblTotalDoneTitle);
            this.cardTotalDone.Location = new System.Drawing.Point(535, 5);
            this.cardTotalDone.Name = "cardTotalDone";
            this.cardTotalDone.Size = new System.Drawing.Size(250, 80);
            this.cardTotalDone.TabIndex = 1;
            // 
            // lblTotalDone
            // 
            this.lblTotalDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalDone.IsDerivedStyle = true;
            this.lblTotalDone.Location = new System.Drawing.Point(10, 35);
            this.lblTotalDone.Name = "lblTotalDone";
            this.lblTotalDone.Size = new System.Drawing.Size(230, 30);
            this.lblTotalDone.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblTotalDone.StyleManager = null;
            this.lblTotalDone.TabIndex = 0;
            this.lblTotalDone.Text = "0";
            this.lblTotalDone.ThemeAuthor = "Taiizor";
            this.lblTotalDone.ThemeName = "MetroLight";
            // 
            // lblTotalDoneTitle
            // 
            this.lblTotalDoneTitle.AutoSize = true;
            this.lblTotalDoneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalDoneTitle.IsDerivedStyle = true;
            this.lblTotalDoneTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTotalDoneTitle.Name = "lblTotalDoneTitle";
            this.lblTotalDoneTitle.Size = new System.Drawing.Size(187, 25);
            this.lblTotalDoneTitle.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblTotalDoneTitle.StyleManager = null;
            this.lblTotalDoneTitle.TabIndex = 1;
            this.lblTotalDoneTitle.Text = "Tổng ca hoàn thành";
            this.lblTotalDoneTitle.ThemeAuthor = "Taiizor";
            this.lblTotalDoneTitle.ThemeName = "MetroLight";
            // 
            // cardTotalSalary
            // 
            this.cardTotalSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cardTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalSalary.Controls.Add(this.lblTotalSalary);
            this.cardTotalSalary.Controls.Add(this.lblTotalSalaryTitle);
            this.cardTotalSalary.Location = new System.Drawing.Point(275, 5);
            this.cardTotalSalary.Name = "cardTotalSalary";
            this.cardTotalSalary.Size = new System.Drawing.Size(250, 80);
            this.cardTotalSalary.TabIndex = 2;
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalSalary.IsDerivedStyle = true;
            this.lblTotalSalary.Location = new System.Drawing.Point(10, 35);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(230, 30);
            this.lblTotalSalary.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblTotalSalary.StyleManager = null;
            this.lblTotalSalary.TabIndex = 0;
            this.lblTotalSalary.Text = "0 đ";
            this.lblTotalSalary.ThemeAuthor = "Taiizor";
            this.lblTotalSalary.ThemeName = "MetroLight";
            // 
            // lblTotalSalaryTitle
            // 
            this.lblTotalSalaryTitle.AutoSize = true;
            this.lblTotalSalaryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalSalaryTitle.IsDerivedStyle = true;
            this.lblTotalSalaryTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTotalSalaryTitle.Name = "lblTotalSalaryTitle";
            this.lblTotalSalaryTitle.Size = new System.Drawing.Size(111, 25);
            this.lblTotalSalaryTitle.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblTotalSalaryTitle.StyleManager = null;
            this.lblTotalSalaryTitle.TabIndex = 1;
            this.lblTotalSalaryTitle.Text = "Tổng lương";
            this.lblTotalSalaryTitle.ThemeAuthor = "Taiizor";
            this.lblTotalSalaryTitle.ThemeName = "MetroLight";
            // 
            // cardTotalEmp
            // 
            this.cardTotalEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cardTotalEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalEmp.Controls.Add(this.lblTotalEmployee);
            this.cardTotalEmp.Controls.Add(this.lblTotalEmpTitle);
            this.cardTotalEmp.Location = new System.Drawing.Point(15, 5);
            this.cardTotalEmp.Name = "cardTotalEmp";
            this.cardTotalEmp.Size = new System.Drawing.Size(250, 80);
            this.cardTotalEmp.TabIndex = 3;
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalEmployee.IsDerivedStyle = true;
            this.lblTotalEmployee.Location = new System.Drawing.Point(10, 35);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(230, 30);
            this.lblTotalEmployee.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblTotalEmployee.StyleManager = null;
            this.lblTotalEmployee.TabIndex = 0;
            this.lblTotalEmployee.Text = "0";
            this.lblTotalEmployee.ThemeAuthor = "Taiizor";
            this.lblTotalEmployee.ThemeName = "MetroLight";
            // 
            // lblTotalEmpTitle
            // 
            this.lblTotalEmpTitle.AutoSize = true;
            this.lblTotalEmpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalEmpTitle.IsDerivedStyle = true;
            this.lblTotalEmpTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTotalEmpTitle.Name = "lblTotalEmpTitle";
            this.lblTotalEmpTitle.Size = new System.Drawing.Size(148, 25);
            this.lblTotalEmpTitle.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblTotalEmpTitle.StyleManager = null;
            this.lblTotalEmpTitle.TabIndex = 1;
            this.lblTotalEmpTitle.Text = "Tổng nhân viên";
            this.lblTotalEmpTitle.ThemeAuthor = "Taiizor";
            this.lblTotalEmpTitle.ThemeName = "MetroLight";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.Location = new System.Drawing.Point(20, 250);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.AutoScroll = true;
            this.splitContainerMain.Panel1.Controls.Add(this.chartSalary);
            this.splitContainerMain.Panel1.Controls.Add(this.dgvReport);
            this.splitContainerMain.Panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Enabled = false;
            this.splitContainerMain.Size = new System.Drawing.Size(1260, 1130);
            this.splitContainerMain.SplitterDistance = 1080;
            this.splitContainerMain.TabIndex = 0;
            // 
            // chartSalary
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSalary.ChartAreas.Add(chartArea2);
            this.chartSalary.Location = new System.Drawing.Point(32, 505);
            this.chartSalary.Name = "chartSalary";
            this.chartSalary.Size = new System.Drawing.Size(1202, 551);
            this.chartSalary.TabIndex = 0;
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(32, 41);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new System.Drawing.Size(1202, 424);
            this.dgvReport.TabIndex = 0;
            // 
            // SalaryReportUC
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.lblTitle);
            this.Name = "SalaryReportUC";
            this.Size = new System.Drawing.Size(1300, 1400);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.cardTotalAbsent.ResumeLayout(false);
            this.cardTotalAbsent.PerformLayout();
            this.cardTotalDone.ResumeLayout(false);
            this.cardTotalDone.PerformLayout();
            this.cardTotalSalary.ResumeLayout(false);
            this.cardTotalSalary.PerformLayout();
            this.cardTotalEmp.ResumeLayout(false);
            this.cardTotalEmp.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
