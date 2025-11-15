namespace UI.Room
{
    partial class RoomManagementUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddRoom = new ReaLTaiizor.Controls.ParrotButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dgvShowtimes = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.colShowtimeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.btnFirstPage = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPrevPage = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPage2 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPage3 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnNextPage = new ReaLTaiizor.Controls.ParrotButton();
            this.btnLastPage = new ReaLTaiizor.Controls.ParrotButton();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.left_Panel = new System.Windows.Forms.Panel();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cboBranch = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.cboMovie = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.cboPageSize = new ReaLTaiizor.Controls.MaterialComboBox();
            this.right_Panel = new System.Windows.Forms.Panel();
            this.btnReset = new ReaLTaiizor.Controls.ParrotButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).BeginInit();
            this.paginationPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.left_Panel.SuspendLayout();
            this.right_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnAddRoom);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1337, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản Lý Phòng chiếu";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAddRoom.ButtonImage = null;
            this.btnAddRoom.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnAddRoom.ButtonText = "+ Thêm Phòng Mới";
            this.btnAddRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddRoom.ClickTextColor = System.Drawing.Color.White;
            this.btnAddRoom.CornerRadius = 5;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnAddRoom.HoverTextColor = System.Drawing.Color.White;
            this.btnAddRoom.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnAddRoom.Location = new System.Drawing.Point(1164, 10);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(170, 36);
            this.btnAddRoom.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.TextColor = System.Drawing.Color.White;
            this.btnAddRoom.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAddRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.panelDataGridView);
            this.panelMain.Controls.Add(this.paginationPanel);
            this.panelMain.Controls.Add(this.filterPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1337, 725);
            this.panelMain.TabIndex = 2;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dgvShowtimes);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(25, 174);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelDataGridView.Size = new System.Drawing.Size(1287, 476);
            this.panelDataGridView.TabIndex = 4;
            // 
            // dgvShowtimes
            // 
            this.dgvShowtimes.AllowUserToAddRows = false;
            this.dgvShowtimes.AllowUserToDeleteRows = false;
            this.dgvShowtimes.AllowUserToResizeRows = false;
            this.dgvShowtimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowtimes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvShowtimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowtimes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvShowtimes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowtimes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowtimes.ColumnHeadersHeight = 40;
            this.dgvShowtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowtimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShowtimeId,
            this.colCinema,
            this.colRoom,
            this.colStartTime,
            this.colEndTime,
            this.colStatus,
            this.mota,
            this.colView});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowtimes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowtimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowtimes.EnableHeadersVisualStyles = false;
            this.dgvShowtimes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvShowtimes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvShowtimes.Location = new System.Drawing.Point(0, 10);
            this.dgvShowtimes.Name = "dgvShowtimes";
            this.dgvShowtimes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowtimes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowtimes.RowHeadersVisible = false;
            this.dgvShowtimes.RowHeadersWidth = 51;
            this.dgvShowtimes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShowtimes.RowTemplate.Height = 35;
            this.dgvShowtimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowtimes.Size = new System.Drawing.Size(1287, 456);
            this.dgvShowtimes.TabIndex = 0;
            this.dgvShowtimes.UseCustomBackColor = true;
            this.dgvShowtimes.UseCustomForeColor = true;
            this.dgvShowtimes.UseStyleColors = true;
            // 
            // colShowtimeId
            // 
            this.colShowtimeId.HeaderText = "MÃ PHÒNG";
            this.colShowtimeId.MinimumWidth = 6;
            this.colShowtimeId.Name = "colShowtimeId";
            // 
            // colCinema
            // 
            this.colCinema.HeaderText = "CHI NHÁNH";
            this.colCinema.MinimumWidth = 6;
            this.colCinema.Name = "colCinema";
            // 
            // colRoom
            // 
            this.colRoom.HeaderText = "TÊN PHÒNG";
            this.colRoom.MinimumWidth = 6;
            this.colRoom.Name = "colRoom";
            // 
            // colStartTime
            // 
            this.colStartTime.HeaderText = "LOẠI PHÒNG";
            this.colStartTime.MinimumWidth = 6;
            this.colStartTime.Name = "colStartTime";
            // 
            // colEndTime
            // 
            this.colEndTime.HeaderText = "SỐ GHẾ";
            this.colEndTime.MinimumWidth = 6;
            this.colEndTime.Name = "colEndTime";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "TRẠNG THÁI";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // mota
            // 
            this.mota.HeaderText = "MÔ TẢ";
            this.mota.MinimumWidth = 6;
            this.mota.Name = "mota";
            // 
            // colView
            // 
            this.colView.HeaderText = "THAO TÁC";
            this.colView.MinimumWidth = 6;
            this.colView.Name = "colView";
            this.colView.Text = "👁";
            this.colView.UseColumnTextForButtonValue = true;
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
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginationPanel.Location = new System.Drawing.Point(25, 650);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Size = new System.Drawing.Size(1287, 50);
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
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.SystemColors.Window;
            this.filterPanel.Controls.Add(this.left_Panel);
            this.filterPanel.Controls.Add(this.right_Panel);
            this.filterPanel.Controls.Add(this.lblInfo);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(25, 25);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(15);
            this.filterPanel.Size = new System.Drawing.Size(1287, 149);
            this.filterPanel.TabIndex = 0;
            // 
            // left_Panel
            // 
            this.left_Panel.Controls.Add(this.lblBranch);
            this.left_Panel.Controls.Add(this.cboBranch);
            this.left_Panel.Controls.Add(this.lblMovie);
            this.left_Panel.Controls.Add(this.cboMovie);
            this.left_Panel.Controls.Add(this.lblPageSize);
            this.left_Panel.Controls.Add(this.cboPageSize);
            this.left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_Panel.Location = new System.Drawing.Point(15, 15);
            this.left_Panel.Name = "left_Panel";
            this.left_Panel.Size = new System.Drawing.Size(826, 84);
            this.left_Panel.TabIndex = 9;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblBranch.Location = new System.Drawing.Point(2, 5);
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
            this.cboBranch.Location = new System.Drawing.Point(2, 28);
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
            this.lblMovie.Location = new System.Drawing.Point(252, 5);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(84, 20);
            this.lblMovie.TabIndex = 2;
            this.lblMovie.Text = "Loại phòng";
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
            this.cboMovie.Location = new System.Drawing.Point(252, 28);
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
            this.lblPageSize.Location = new System.Drawing.Point(692, 5);
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
            this.cboPageSize.Location = new System.Drawing.Point(692, 28);
            this.cboPageSize.MaxDropDownItems = 4;
            this.cboPageSize.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(120, 49);
            this.cboPageSize.StartIndex = 0;
            this.cboPageSize.TabIndex = 5;
            // 
            // right_Panel
            // 
            this.right_Panel.Controls.Add(this.btnReset);
            this.right_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_Panel.Location = new System.Drawing.Point(996, 15);
            this.right_Panel.Name = "right_Panel";
            this.right_Panel.Size = new System.Drawing.Size(276, 84);
            this.right_Panel.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnReset.ButtonImage = null;
            this.btnReset.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnReset.ClickTextColor = System.Drawing.Color.White;
            this.btnReset.CornerRadius = 5;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReset.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnReset.HoverTextColor = System.Drawing.Color.White;
            this.btnReset.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnReset.Location = new System.Drawing.Point(147, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnReset.TabIndex = 7;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnReset.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(15, 99);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblInfo.Size = new System.Drawing.Size(1257, 35);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Hiển thị 10 trong tổng số 25 phòng | Trang 1 / 3";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomManagementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "RoomManagementUC";
            this.Size = new System.Drawing.Size(1337, 785);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).EndInit();
            this.paginationPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.left_Panel.ResumeLayout(false);
            this.left_Panel.PerformLayout();
            this.right_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private ReaLTaiizor.Controls.ParrotButton btnAddRoom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDataGridView;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvShowtimes;
        private System.Windows.Forms.Panel paginationPanel;
        private ReaLTaiizor.Controls.ParrotButton btnFirstPage;
        private ReaLTaiizor.Controls.ParrotButton btnPrevPage;
        private ReaLTaiizor.Controls.ParrotButton btnPage2;
        private ReaLTaiizor.Controls.ParrotButton btnPage3;
        private ReaLTaiizor.Controls.ParrotButton btnNextPage;
        private ReaLTaiizor.Controls.ParrotButton btnLastPage;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel left_Panel;
        private System.Windows.Forms.Label lblBranch;
        private ReaLTaiizor.Controls.MaterialComboBox cboBranch;
        private System.Windows.Forms.Label lblMovie;
        private ReaLTaiizor.Controls.MaterialComboBox cboMovie;
        private System.Windows.Forms.Label lblPageSize;
        private ReaLTaiizor.Controls.MaterialComboBox cboPageSize;
        private System.Windows.Forms.Panel right_Panel;
        private ReaLTaiizor.Controls.ParrotButton btnReset;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowtimeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
    }
}
