namespace UI.ShowTime
{
    partial class MNShowTimeUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddShowtime = new ReaLTaiizor.Controls.ParrotButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cboBranch = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.cboMovie = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.cboPageSize = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnFilter = new ReaLTaiizor.Controls.ParrotButton();
            this.btnReset = new ReaLTaiizor.Controls.ParrotButton();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.dgvShowtimes = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.colShowtimeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.btnFirstPage = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPrevPage = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPage2 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPage3 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnNextPage = new ReaLTaiizor.Controls.ParrotButton();
            this.btnLastPage = new ReaLTaiizor.Controls.ParrotButton();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).BeginInit();
            this.paginationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnAddShowtime);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "🎬 Quản Lý Suất Chiếu";
            // 
            // btnAddShowtime
            // 
            this.btnAddShowtime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAddShowtime.ButtonImage = null;
            this.btnAddShowtime.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnAddShowtime.ButtonText = "+ Thêm Mới";
            this.btnAddShowtime.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddShowtime.ClickTextColor = System.Drawing.Color.White;
            this.btnAddShowtime.CornerRadius = 5;
            this.btnAddShowtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddShowtime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddShowtime.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddShowtime.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnAddShowtime.HoverTextColor = System.Drawing.Color.White;
            this.btnAddShowtime.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnAddShowtime.Location = new System.Drawing.Point(1210, 12);
            this.btnAddShowtime.Name = "btnAddShowtime";
            this.btnAddShowtime.Size = new System.Drawing.Size(130, 36);
            this.btnAddShowtime.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAddShowtime.TabIndex = 2;
            this.btnAddShowtime.TextColor = System.Drawing.Color.White;
            this.btnAddShowtime.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAddShowtime.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.filterPanel);
            this.panelMain.Controls.Add(this.infoPanel);
            this.panelMain.Controls.Add(this.dataGridPanel);
            this.panelMain.Controls.Add(this.paginationPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1360, 740);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.White;
            this.filterPanel.Controls.Add(this.lblBranch);
            this.filterPanel.Controls.Add(this.cboBranch);
            this.filterPanel.Controls.Add(this.lblMovie);
            this.filterPanel.Controls.Add(this.cboMovie);
            this.filterPanel.Controls.Add(this.lblPageSize);
            this.filterPanel.Controls.Add(this.cboPageSize);
            this.filterPanel.Controls.Add(this.btnFilter);
            this.filterPanel.Controls.Add(this.btnReset);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(25, 25);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(15);
            this.filterPanel.Size = new System.Drawing.Size(1310, 100);
            this.filterPanel.TabIndex = 0;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblBranch.Location = new System.Drawing.Point(15, 15);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(77, 20);
            this.lblBranch.TabIndex = 0;
            this.lblBranch.Text = "Chi Nhánh";
            // 
            // cboBranch
            // 
            this.cboBranch.AutoResize = false;
            this.cboBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboBranch.Depth = 0;
            this.cboBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboBranch.DropDownHeight = 174;
            this.cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBranch.DropDownWidth = 121;
            this.cboBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Hint = "-- Tất cả chi nhánh --";
            this.cboBranch.IntegralHeight = false;
            this.cboBranch.ItemHeight = 43;
            this.cboBranch.Location = new System.Drawing.Point(15, 38);
            this.cboBranch.MaxDropDownItems = 4;
            this.cboBranch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(230, 49);
            this.cboBranch.StartIndex = 0;
            this.cboBranch.TabIndex = 1;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMovie.Location = new System.Drawing.Point(265, 15);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(42, 20);
            this.lblMovie.TabIndex = 2;
            this.lblMovie.Text = "Phim";
            // 
            // cboMovie
            // 
            this.cboMovie.AutoResize = false;
            this.cboMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMovie.Depth = 0;
            this.cboMovie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMovie.DropDownHeight = 174;
            this.cboMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovie.DropDownWidth = 121;
            this.cboMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Hint = "-- Tất cả phim --";
            this.cboMovie.IntegralHeight = false;
            this.cboMovie.ItemHeight = 43;
            this.cboMovie.Location = new System.Drawing.Point(265, 38);
            this.cboMovie.MaxDropDownItems = 4;
            this.cboMovie.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(420, 49);
            this.cboMovie.StartIndex = 0;
            this.cboMovie.TabIndex = 3;
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPageSize.Location = new System.Drawing.Point(705, 15);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(106, 20);
            this.lblPageSize.TabIndex = 4;
            this.lblPageSize.Text = "Số dòng/trang";
            // 
            // cboPageSize
            // 
            this.cboPageSize.AutoResize = false;
            this.cboPageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPageSize.Depth = 0;
            this.cboPageSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPageSize.DropDownHeight = 174;
            this.cboPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPageSize.DropDownWidth = 121;
            this.cboPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboPageSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboPageSize.FormattingEnabled = true;
            this.cboPageSize.Hint = "10";
            this.cboPageSize.IntegralHeight = false;
            this.cboPageSize.ItemHeight = 43;
            this.cboPageSize.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100"});
            this.cboPageSize.Location = new System.Drawing.Point(705, 38);
            this.cboPageSize.MaxDropDownItems = 4;
            this.cboPageSize.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(120, 49);
            this.cboPageSize.StartIndex = 0;
            this.cboPageSize.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnFilter.ButtonImage = null;
            this.btnFilter.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnFilter.ButtonText = "🔍 Lọc";
            this.btnFilter.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFilter.ClickTextColor = System.Drawing.Color.White;
            this.btnFilter.CornerRadius = 5;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFilter.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnFilter.HoverTextColor = System.Drawing.Color.White;
            this.btnFilter.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnFilter.Location = new System.Drawing.Point(1045, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 40);
            this.btnFilter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnFilter.TabIndex = 6;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnFilter.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnReset.ButtonImage = null;
            this.btnReset.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnReset.ButtonText = "🔄 Reset";
            this.btnReset.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnReset.ClickTextColor = System.Drawing.Color.White;
            this.btnReset.CornerRadius = 5;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReset.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnReset.HoverTextColor = System.Drawing.Color.White;
            this.btnReset.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnReset.Location = new System.Drawing.Point(1175, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnReset.TabIndex = 7;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnReset.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.infoPanel.Controls.Add(this.lblInfo);
            this.infoPanel.Location = new System.Drawing.Point(25, 135);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1310, 35);
            this.infoPanel.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblInfo.Size = new System.Drawing.Size(1310, 35);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "⚪ Hiển thị 10 trong tổng số 25 suất chiếu / Trang 1 / 3";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.BackColor = System.Drawing.Color.White;
            this.dataGridPanel.Controls.Add(this.dgvShowtimes);
            this.dataGridPanel.Location = new System.Drawing.Point(25, 175);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridPanel.Size = new System.Drawing.Size(1310, 480);
            this.dataGridPanel.TabIndex = 2;
            // 
            // dgvShowtimes
            // 
            this.dgvShowtimes.AllowUserToAddRows = false;
            this.dgvShowtimes.AllowUserToDeleteRows = false;
            this.dgvShowtimes.AllowUserToResizeRows = false;
            this.dgvShowtimes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvShowtimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowtimes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvShowtimes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowtimes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowtimes.ColumnHeadersHeight = 40;
            this.dgvShowtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowtimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShowtimeId,
            this.colMovie,
            this.colCinema,
            this.colRoom,
            this.colStartTime,
            this.colEndTime,
            this.colPrice,
            this.colStatus,
            this.colView,
            this.colEdit,
            this.colDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowtimes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowtimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowtimes.EnableHeadersVisualStyles = false;
            this.dgvShowtimes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvShowtimes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvShowtimes.Location = new System.Drawing.Point(5, 5);
            this.dgvShowtimes.Name = "dgvShowtimes";
            this.dgvShowtimes.ReadOnly = true;
            this.dgvShowtimes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowtimes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowtimes.RowHeadersVisible = false;
            this.dgvShowtimes.RowHeadersWidth = 51;
            this.dgvShowtimes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShowtimes.RowTemplate.Height = 35;
            this.dgvShowtimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowtimes.Size = new System.Drawing.Size(1300, 470);
            this.dgvShowtimes.TabIndex = 0;
            this.dgvShowtimes.UseCustomBackColor = true;
            this.dgvShowtimes.UseCustomForeColor = true;
            this.dgvShowtimes.UseStyleColors = true;
            // 
            // colShowtimeId
            // 
            this.colShowtimeId.HeaderText = "MÃ SUẤT CHIẾU";
            this.colShowtimeId.MinimumWidth = 6;
            this.colShowtimeId.Name = "colShowtimeId";
            this.colShowtimeId.ReadOnly = true;
            this.colShowtimeId.Width = 120;
            // 
            // colMovie
            // 
            this.colMovie.HeaderText = "PHIM";
            this.colMovie.MinimumWidth = 6;
            this.colMovie.Name = "colMovie";
            this.colMovie.ReadOnly = true;
            this.colMovie.Width = 180;
            // 
            // colCinema
            // 
            this.colCinema.HeaderText = "CHI NHÁNH";
            this.colCinema.MinimumWidth = 6;
            this.colCinema.Name = "colCinema";
            this.colCinema.ReadOnly = true;
            this.colCinema.Width = 150;
            // 
            // colRoom
            // 
            this.colRoom.HeaderText = "PHÒNG";
            this.colRoom.MinimumWidth = 6;
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            this.colRoom.Width = 90;
            // 
            // colStartTime
            // 
            this.colStartTime.HeaderText = "GIỜ BẮT ĐẦU";
            this.colStartTime.MinimumWidth = 6;
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            this.colStartTime.Width = 130;
            // 
            // colEndTime
            // 
            this.colEndTime.HeaderText = "GIỜ KẾT THÚC";
            this.colEndTime.MinimumWidth = 6;
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.ReadOnly = true;
            this.colEndTime.Width = 130;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "GIÁ";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "TRẠNG THÁI";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 120;
            // 
            // colView
            // 
            this.colView.HeaderText = "THAO TÁC";
            this.colView.MinimumWidth = 6;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Text = "👁";
            this.colView.UseColumnTextForButtonValue = true;
            this.colView.Width = 80;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "✏";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 80;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "🗑";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 80;
            // 
            // paginationPanel
            // 
            this.paginationPanel.BackColor = System.Drawing.Color.Transparent;
            this.paginationPanel.Controls.Add(this.btnFirstPage);
            this.paginationPanel.Controls.Add(this.btnPrevPage);
            this.paginationPanel.Controls.Add(this.btnPage2);
            this.paginationPanel.Controls.Add(this.btnPage3);
            this.paginationPanel.Controls.Add(this.btnNextPage);
            this.paginationPanel.Controls.Add(this.btnLastPage);
            this.paginationPanel.Location = new System.Drawing.Point(25, 665);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Size = new System.Drawing.Size(1310, 50);
            this.paginationPanel.TabIndex = 3;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnFirstPage.ButtonImage = null;
            this.btnFirstPage.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnFirstPage.ButtonText = "1";
            this.btnFirstPage.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFirstPage.ClickTextColor = System.Drawing.Color.White;
            this.btnFirstPage.CornerRadius = 3;
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirstPage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFirstPage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnFirstPage.HoverTextColor = System.Drawing.Color.White;
            this.btnFirstPage.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnFirstPage.Location = new System.Drawing.Point(545, 10);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(35, 30);
            this.btnFirstPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnFirstPage.TabIndex = 0;
            this.btnFirstPage.TextColor = System.Drawing.Color.White;
            this.btnFirstPage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnFirstPage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnPrevPage.ButtonImage = null;
            this.btnPrevPage.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnPrevPage.ButtonText = "2";
            this.btnPrevPage.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnPrevPage.ClickTextColor = System.Drawing.Color.White;
            this.btnPrevPage.CornerRadius = 3;
            this.btnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevPage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrevPage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnPrevPage.HoverTextColor = System.Drawing.Color.White;
            this.btnPrevPage.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPrevPage.Location = new System.Drawing.Point(590, 10);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(35, 30);
            this.btnPrevPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPrevPage.TabIndex = 1;
            this.btnPrevPage.TextColor = System.Drawing.Color.White;
            this.btnPrevPage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPrevPage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnPage2
            // 
            this.btnPage2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnPage2.ButtonImage = null;
            this.btnPage2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnPage2.ButtonText = "3";
            this.btnPage2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnPage2.ClickTextColor = System.Drawing.Color.White;
            this.btnPage2.CornerRadius = 3;
            this.btnPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPage2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnPage2.HoverTextColor = System.Drawing.Color.White;
            this.btnPage2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPage2.Location = new System.Drawing.Point(635, 10);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(35, 30);
            this.btnPage2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPage2.TabIndex = 2;
            this.btnPage2.TextColor = System.Drawing.Color.White;
            this.btnPage2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPage2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnPage3
            // 
            this.btnPage3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnPage3.ButtonImage = null;
            this.btnPage3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnPage3.ButtonText = "›";
            this.btnPage3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnPage3.ClickTextColor = System.Drawing.Color.White;
            this.btnPage3.CornerRadius = 3;
            this.btnPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPage3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPage3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnPage3.HoverTextColor = System.Drawing.Color.White;
            this.btnPage3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPage3.Location = new System.Drawing.Point(680, 10);
            this.btnPage3.Name = "btnPage3";
            this.btnPage3.Size = new System.Drawing.Size(35, 30);
            this.btnPage3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPage3.TabIndex = 3;
            this.btnPage3.TextColor = System.Drawing.Color.White;
            this.btnPage3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPage3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnNextPage.ButtonImage = null;
            this.btnNextPage.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnNextPage.ButtonText = "»";
            this.btnNextPage.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnNextPage.ClickTextColor = System.Drawing.Color.White;
            this.btnNextPage.CornerRadius = 3;
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNextPage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNextPage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnNextPage.HoverTextColor = System.Drawing.Color.White;
            this.btnNextPage.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnNextPage.Location = new System.Drawing.Point(725, 10);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(35, 30);
            this.btnNextPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnNextPage.TabIndex = 4;
            this.btnNextPage.TextColor = System.Drawing.Color.White;
            this.btnNextPage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnNextPage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLastPage.ButtonImage = null;
            this.btnLastPage.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnLastPage.ButtonText = "⟫";
            this.btnLastPage.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnLastPage.ClickTextColor = System.Drawing.Color.White;
            this.btnLastPage.CornerRadius = 3;
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLastPage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLastPage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnLastPage.HoverTextColor = System.Drawing.Color.White;
            this.btnLastPage.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnLastPage.Location = new System.Drawing.Point(770, 10);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(35, 30);
            this.btnLastPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnLastPage.TabIndex = 5;
            this.btnLastPage.TextColor = System.Drawing.Color.White;
            this.btnLastPage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnLastPage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // MNShowTimeUC
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "MNShowTimeUC";
            this.Size = new System.Drawing.Size(1360, 800);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).EndInit();
            this.paginationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private ReaLTaiizor.Controls.ParrotButton btnAddShowtime;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label lblBranch;
        private ReaLTaiizor.Controls.MaterialComboBox cboBranch;
        private System.Windows.Forms.Label lblMovie;
        private ReaLTaiizor.Controls.MaterialComboBox cboMovie;
        private System.Windows.Forms.Label lblPageSize;
        private ReaLTaiizor.Controls.MaterialComboBox cboPageSize;
        private ReaLTaiizor.Controls.ParrotButton btnFilter;
        private ReaLTaiizor.Controls.ParrotButton btnReset;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel dataGridPanel;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvShowtimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowtimeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Panel paginationPanel;
        private ReaLTaiizor.Controls.ParrotButton btnFirstPage;
        private ReaLTaiizor.Controls.ParrotButton btnPrevPage;
        private ReaLTaiizor.Controls.ParrotButton btnPage2;
        private ReaLTaiizor.Controls.ParrotButton btnPage3;
        private ReaLTaiizor.Controls.ParrotButton btnNextPage;
        private ReaLTaiizor.Controls.ParrotButton btnLastPage;

    }
}
