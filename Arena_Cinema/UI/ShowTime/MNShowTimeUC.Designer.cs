using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.head_Right_Panel = new System.Windows.Forms.Panel();
            this.btnEdit = new ReaLTaiizor.Controls.ParrotButton();
            this.btnDelete = new ReaLTaiizor.Controls.ParrotButton();
            this.btnAddShowtime = new ReaLTaiizor.Controls.ParrotButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dgvShowtimes = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.colShowtimeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.btnPageSample = new ReaLTaiizor.Controls.ParrotButton();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.left_Panel = new System.Windows.Forms.Panel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cboRoom = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.cboMovie = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.cboPageSize = new ReaLTaiizor.Controls.MaterialComboBox();
            this.right_Panel = new System.Windows.Forms.Panel();
            this.btnFilter = new ReaLTaiizor.Controls.ParrotButton();
            this.btnReset = new ReaLTaiizor.Controls.ParrotButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.head_Right_Panel.SuspendLayout();
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
            this.panelHeader.Controls.Add(this.head_Right_Panel);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // head_Right_Panel
            // 
            this.head_Right_Panel.Controls.Add(this.btnEdit);
            this.head_Right_Panel.Controls.Add(this.btnDelete);
            this.head_Right_Panel.Controls.Add(this.btnAddShowtime);
            this.head_Right_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.head_Right_Panel.Location = new System.Drawing.Point(880, 0);
            this.head_Right_Panel.Name = "head_Right_Panel";
            this.head_Right_Panel.Size = new System.Drawing.Size(480, 60);
            this.head_Right_Panel.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEdit.ButtonImage = null;
            this.btnEdit.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnEdit.ButtonText = "Sửa";
            this.btnEdit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnEdit.ClickTextColor = System.Drawing.Color.White;
            this.btnEdit.CornerRadius = 5;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnEdit.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnEdit.Location = new System.Drawing.Point(180, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 36);
            this.btnEdit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit.TabIndex = 3;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.ButtonImage = null;
            this.btnDelete.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDelete.ButtonText = "- Xóa";
            this.btnDelete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete.ClickTextColor = System.Drawing.Color.White;
            this.btnDelete.CornerRadius = 5;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnDelete.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDelete.Location = new System.Drawing.Point(325, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 36);
            this.btnDelete.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddShowtime
            // 
            this.btnAddShowtime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
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
            this.btnAddShowtime.Location = new System.Drawing.Point(31, 9);
            this.btnAddShowtime.Name = "btnAddShowtime";
            this.btnAddShowtime.Size = new System.Drawing.Size(130, 36);
            this.btnAddShowtime.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAddShowtime.TabIndex = 2;
            this.btnAddShowtime.TextColor = System.Drawing.Color.White;
            this.btnAddShowtime.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAddShowtime.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddShowtime.Click += new System.EventHandler(this.btnAddShowtime_Click);
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
            this.panelMain.Size = new System.Drawing.Size(1360, 740);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dgvShowtimes);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(25, 174);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelDataGridView.Size = new System.Drawing.Size(1310, 491);
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
            this.colMovie,
            this.colRoom,
            this.colStartTime,
            this.colEndTime,
            this.colPrice,
            this.colStatus});
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
            this.dgvShowtimes.Size = new System.Drawing.Size(1310, 471);
            this.dgvShowtimes.TabIndex = 0;
            this.dgvShowtimes.UseCustomBackColor = true;
            this.dgvShowtimes.UseCustomForeColor = true;
            this.dgvShowtimes.UseStyleColors = true;
            this.dgvShowtimes.SelectionChanged += new System.EventHandler(this.dgvShowtimes_SelectionChanged);
            // 
            // colShowtimeId
            // 
            this.colShowtimeId.DataPropertyName = "ShowTimeID";
            this.colShowtimeId.HeaderText = "MÃ SUẤT CHIẾU";
            this.colShowtimeId.MinimumWidth = 6;
            this.colShowtimeId.Name = "colShowtimeId";
            this.colShowtimeId.Visible = false;
            // 
            // colMovie
            // 
            this.colMovie.DataPropertyName = "MovieTitle";
            this.colMovie.HeaderText = "PHIM";
            this.colMovie.MinimumWidth = 6;
            this.colMovie.Name = "colMovie";
            // 
            // colRoom
            // 
            this.colRoom.DataPropertyName = "RoomName";
            this.colRoom.HeaderText = "PHÒNG";
            this.colRoom.MinimumWidth = 6;
            this.colRoom.Name = "colRoom";
            // 
            // colStartTime
            // 
            this.colStartTime.DataPropertyName = "StartTimeDisplay";
            this.colStartTime.HeaderText = "GIỜ BẮT ĐẦU";
            this.colStartTime.MinimumWidth = 6;
            this.colStartTime.Name = "colStartTime";
            // 
            // colEndTime
            // 
            this.colEndTime.DataPropertyName = "EndTimeDisplay";
            this.colEndTime.HeaderText = "GIỜ KẾT THÚC";
            this.colEndTime.MinimumWidth = 6;
            this.colEndTime.Name = "colEndTime";
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "PriceDisplay";
            this.colPrice.HeaderText = "GIÁ";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "TRẠNG THÁI";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // paginationPanel
            // 
            this.paginationPanel.BackColor = System.Drawing.Color.Transparent;
            this.paginationPanel.Controls.Add(this.btnPageSample);
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginationPanel.Location = new System.Drawing.Point(25, 665);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Size = new System.Drawing.Size(1310, 50);
            this.paginationPanel.TabIndex = 3;
            // 
            // btnPageSample
            // 
            this.btnPageSample.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnPageSample.ButtonImage = null;
            this.btnPageSample.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnPageSample.ButtonText = "1";
            this.btnPageSample.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnPageSample.ClickTextColor = System.Drawing.Color.White;
            this.btnPageSample.CornerRadius = 3;
            this.btnPageSample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageSample.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPageSample.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPageSample.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnPageSample.HoverTextColor = System.Drawing.Color.White;
            this.btnPageSample.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPageSample.Location = new System.Drawing.Point(10, 10);
            this.btnPageSample.Name = "btnPageSample";
            this.btnPageSample.Size = new System.Drawing.Size(40, 30);
            this.btnPageSample.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPageSample.TabIndex = 0;
            this.btnPageSample.TextColor = System.Drawing.Color.White;
            this.btnPageSample.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPageSample.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPageSample.Visible = false;
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
            this.filterPanel.Size = new System.Drawing.Size(1310, 149);
            this.filterPanel.TabIndex = 0;
            // 
            // left_Panel
            // 
            this.left_Panel.Controls.Add(this.lblRoom);
            this.left_Panel.Controls.Add(this.cboRoom);
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
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblRoom.Location = new System.Drawing.Point(2, 5);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(51, 20);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Phòng";
            // 
            // cboRoom
            // 
            this.cboRoom.AutoResize = false;
            this.cboRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRoom.Depth = 0;
            this.cboRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboRoom.DropDownHeight = 174;
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.DropDownWidth = 121;
            this.cboRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Hint = "-- Tất cả Phòng--";
            this.cboRoom.IntegralHeight = false;
            this.cboRoom.ItemHeight = 43;
            this.cboRoom.Location = new System.Drawing.Point(2, 28);
            this.cboRoom.MaxDropDownItems = 4;
            this.cboRoom.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(230, 49);
            this.cboRoom.StartIndex = 0;
            this.cboRoom.TabIndex = 1;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMovie.Location = new System.Drawing.Point(252, 5);
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
            this.right_Panel.Controls.Add(this.btnFilter);
            this.right_Panel.Controls.Add(this.btnReset);
            this.right_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_Panel.Location = new System.Drawing.Point(1019, 15);
            this.right_Panel.Name = "right_Panel";
            this.right_Panel.Size = new System.Drawing.Size(276, 84);
            this.right_Panel.TabIndex = 8;
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
            this.btnFilter.Location = new System.Drawing.Point(17, 18);
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
            this.lblInfo.Size = new System.Drawing.Size(1280, 35);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "⚪ Hiển thị 10 trong tổng số 25 suất chiếu / Trang 1 / 3";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MNShowTimeUC
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "MNShowTimeUC";
            this.Size = new System.Drawing.Size(1360, 800);
            this.Load += new System.EventHandler(this.MNShowTimeUC_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.head_Right_Panel.ResumeLayout(false);
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


        private ShowTimeBLL showTimeBLL;
        private MovieBLL movieBLL;
        private RoomBLL roomBLL;

        // Phân trang
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 0;
        private int totalRecords = 0;

        // Selected row
        private Guid? selectedShowTimeId = null;

        #region Initialize Methods


        private void LoadInitialData()
        {
            try
            {
                showTimeBLL = new ShowTimeBLL();
                movieBLL = new MovieBLL();
                roomBLL = new RoomBLL();

                ConfigureDataGridView();
                LoadMoviesFilter();
                LoadRoomsFilter();
                LoadPageSizes();

                // FIX: Đảm bảo cboPageSize có giá trị mặc định
                if (cboPageSize.SelectedIndex < 0)
                {
                    cboPageSize.SelectedIndex = 0; // Chọn "10"
                }

                SetupEvents();
                LoadShowTimes(); // Load data sau khi setup xong
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}\n\n{ex.StackTrace}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigureDataGridView()
        {
            dgvShowtimes.AutoGenerateColumns = false;
            dgvShowtimes.AllowUserToAddRows = false;
            dgvShowtimes.AllowUserToDeleteRows = false;
            dgvShowtimes.ReadOnly = true;
            dgvShowtimes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShowtimes.MultiSelect = false;
            dgvShowtimes.RowTemplate.Height = 40;
            if (dgvShowtimes.Columns["colShowtimeId"] != null)
            {
                dgvShowtimes.Columns["colShowtimeId"].Visible = false;
            }


        }

        private void LoadMoviesFilter()
        {
            try
            {
                var movies = movieBLL.GetAllMovies();
                cboMovie.Items.Clear();
                cboMovie.Items.Add(new ComboBoxItem { Text = "-- Tất cả phim --", Value = 0 });

                foreach (var movie in movies)
                {
                    cboMovie.Items.Add(new ComboBoxItem
                    {
                        Text = movie.Title,
                        Value = movie.MovieID
                    });
                }

                cboMovie.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load phim: {ex.Message}");
            }
        }
        private void LoadRoomsFilter()
        {
            try
            {
                var rooms = roomBLL.GetAllRooms();
                cboRoom.Items.Clear();
                cboRoom.Items.Add(new ComboBoxItem { Text = "-- Tất cả phòng --", Value = 0 });

                foreach (var room in rooms)
                {
                    cboRoom.Items.Add(new ComboBoxItem
                    {
                        Text = room.RoomName,
                        Value = room.RoomID
                    });
                }

                cboRoom.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load phòng: {ex.Message}");
            }
        }
        private void LoadPageSizes()
        {
           
            if (cboPageSize.Items.Count == 0)
            {
                cboPageSize.Items.AddRange(new object[] { "10", "25", "50", "100" });
            }

            cboPageSize.SelectedIndex = 0;
        }

       

        private void SetupEvents()
        {
            // Pagination
            btnFilter.Click += (s, e) =>
            {
                currentPage = 1;
                LoadShowTimes();
            };

            btnReset.Click += (s, e) => ResetFilters();

            cboPageSize.SelectedIndexChanged += (s, e) =>
            {
                if (cboPageSize.SelectedItem != null)
                {
                    currentPage = 1;
                    LoadShowTimes();
                }
            };
        }

        #endregion

        #region Load Data

        private void LoadShowTimes()
        {
            try
            {
                // Lấy filter Movie
                int? movieId = null;
                if (cboMovie.SelectedIndex > 0 && cboMovie.SelectedItem is ComboBoxItem movieItem)
                {
                    movieId = (int)movieItem.Value;
                }

                // Lấy filter Room
                int? roomId = null;
                if (cboRoom.SelectedIndex > 0 && cboRoom.SelectedItem is ComboBoxItem roomItem)
                {
                    roomId = (int)roomItem.Value;
                }

                // Xử lý page size
                if (cboPageSize.SelectedItem != null)
                {
                    string pageSizeText = cboPageSize.SelectedItem.ToString();
                    if (int.TryParse(pageSizeText, out int parsedPageSize))
                    {
                        pageSize = parsedPageSize;
                    }
                    else
                    {
                        pageSize = 10;
                    }
                }
                else
                {
                    pageSize = 10;
                }

                // Gọi stored procedure
                var result = showTimeBLL.GetShowTimesPaginated(
                    pageNumber: currentPage,
                    pageSize: pageSize,
                    movieId: movieId,
                    roomId: roomId,  // ← THÊM FILTER ROOM
                    startDate: null,
                    endDate: null,
                    minPrice: null,
                    maxPrice: null,
                    sortBy: "StartTime",
                    sortOrder: "DESC"
                );

                if (result.items == null)
                {
                    MessageBox.Show("Không có dữ liệu trả về!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvShowtimes.DataSource = null;
                    totalRecords = 0;
                    totalPages = 0;
                    UpdatePaginationInfo();
                    return;
                }

                totalRecords = result.totalCount;
                totalPages = result.totalPages;

                var displayData = new List<ShowTimeDisplayModel>();
                foreach (var st in result.items)
                {
                    displayData.Add(new ShowTimeDisplayModel
                    {
                        ShowTimeID = st.ShowTimeID,
                        MovieTitle = st.Movie?.Title ?? "N/A",
                        RoomName = st.Room?.RoomName ?? "N/A",
                        StartTimeDisplay = st.StartTime.ToString("dd/MM/yyyy HH:mm"),
                        EndTimeDisplay = showTimeBLL.CalculateEndTime(st).ToString("dd/MM/yyyy HH:mm"),
                        PriceDisplay = st.Price.ToString("N0") + " VNĐ",
                        Status = showTimeBLL.GetShowTimeStatus(st),
                        ShowTime = st
                    });
                }

                dgvShowtimes.DataSource = null;
                dgvShowtimes.DataSource = displayData;

                UpdatePaginationInfo();
                UpdatePaginationButtons();
                ColorizeRows();

                selectedShowTimeId = null;
                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                string errorMessage = $"Lỗi load dữ liệu: {ex.Message}\n\n" +
                                     $"Chi tiết: {ex.StackTrace}";

                if (ex.InnerException != null)
                {
                    errorMessage += $"\n\nLỗi bên trong: {ex.InnerException.Message}";
                }

                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"Error details: {ex}");
            }
        }

        private void ColorizeRows()
        {
            foreach (DataGridViewRow row in dgvShowtimes.Rows)
            {
                if (row.Cells["colStatus"].Value != null)
                {
                    string status = row.Cells["colStatus"].Value.ToString();

                    switch (status)
                    {
                        case "Sắp chiếu":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(220, 252, 231);
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
                            break;
                        case "Đang chiếu":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(219, 234, 254);
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
                            break;
                        case "Đã chiếu":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
                            break;
                    }
                }
            }
        }

        #endregion

        #region Pagination

        private void UpdatePaginationInfo()
        {
            int startRecord = (currentPage - 1) * pageSize + 1;
            int endRecord = System.Math.Min(currentPage * pageSize, totalRecords);

            lblInfo.Text = $"⚪ Hiển thị {startRecord}-{endRecord} trong tổng số {totalRecords} suất chiếu / Trang {currentPage} / {totalPages}";
        }


        private ReaLTaiizor.Controls.ParrotButton CreateButtonFromSample(string text, int xPosition)
        {
            var btn = new ReaLTaiizor.Controls.ParrotButton
            {
                ButtonText = text,
                Size = btnPageSample.Size,
                Location = new Point(xPosition, btnPageSample.Location.Y),
                CornerRadius = btnPageSample.CornerRadius,
                Font = btnPageSample.Font,
                ButtonStyle = btnPageSample.ButtonStyle,
                Horizontal_Alignment = btnPageSample.Horizontal_Alignment,
                Vertical_Alignment = btnPageSample.Vertical_Alignment,
                TextRenderingType = btnPageSample.TextRenderingType,
                SmoothingType = btnPageSample.SmoothingType,
                ImagePosition = btnPageSample.ImagePosition,
                ButtonImage = null  // Không dùng image
            };

            return btn;
        }
        private void UpdatePaginationButtons()
        {
            // Xóa tất cả các nút trang cũ
            ClearPageButtons();

            if (totalPages == 0)
            {
                UpdatePaginationInfo();
                return;
            }

            // Tính toán phạm vi trang cần hiển thị
            int startPage, endPage;
            CalculatePageRange(out startPage, out endPage);

            // Tính tổng chiều rộng của các nút
            int buttonCount = 2; // First, Previous
            if (startPage > 1) buttonCount++; // Ellipsis đầu
            buttonCount += (endPage - startPage + 1); // Các nút trang
            if (endPage < totalPages) buttonCount++; // Ellipsis cuối
            buttonCount += 2; // Next, Last

            int totalWidth = buttonCount * 40 + (buttonCount - 1) * 5; // 40px mỗi nút + 5px khoảng cách
            int startX = (paginationPanel.Width - totalWidth) / 2;

            // Tạo nút "First" (<<)
            CreateNavigationButton("<<", 1, currentPage > 1, startX);
            startX += 45;

            // Tạo nút "Previous" (<)
            CreateNavigationButton("<", currentPage - 1, currentPage > 1, startX);
            startX += 45;

            // Hiển thị "..." nếu startPage > 1
            if (startPage > 1)
            {
                CreateEllipsisLabel(startX);
                startX += 45;
            }

            // Tạo các nút trang
            for (int i = startPage; i <= endPage; i++)
            {
                CreatePageButton(i, startX);
                startX += 45;
            }

            // Hiển thị "..." nếu endPage < totalPages
            if (endPage < totalPages)
            {
                CreateEllipsisLabel(startX);
                startX += 45;
            }

            // Tạo nút "Next" (>)
            CreateNavigationButton(">", currentPage + 1, currentPage < totalPages, startX);
            startX += 45;

            // Tạo nút "Last" (>>)
            CreateNavigationButton(">>", totalPages, currentPage < totalPages, startX);

            // Cập nhật thông tin phân trang
            UpdatePaginationInfo();
        }

        private void CalculatePageRange(out int startPage, out int endPage)
        {
            if (totalPages <= MAX_VISIBLE_PAGES)
            {
                // Hiển thị tất cả các trang
                startPage = 1;
                endPage = totalPages;
            }
            else
            {
                // Tính toán phạm vi hiển thị
                int halfVisible = MAX_VISIBLE_PAGES / 2;

                if (currentPage <= halfVisible + 1)
                {
                    // Gần đầu
                    startPage = 1;
                    endPage = MAX_VISIBLE_PAGES;
                }
                else if (currentPage >= totalPages - halfVisible)
                {
                    // Gần cuối
                    startPage = totalPages - MAX_VISIBLE_PAGES + 1;
                    endPage = totalPages;
                }
                else
                {
                    // Ở giữa
                    startPage = currentPage - halfVisible;
                    endPage = currentPage + halfVisible;
                }
            }
        }

        private void CreatePageButton(int pageNumber, int xPosition)
        {
            var btn = CreateButtonFromSample(pageNumber.ToString(), xPosition);
            btn.Cursor = Cursors.Hand;

            if (pageNumber == currentPage)
            {
                btn.BackgroundColor = Color.FromArgb(220, 53, 69);
                btn.TextColor = Color.White;
                btn.Enabled = false;
            }
            else
            {
                btn.BackgroundColor = btnPageSample.BackgroundColor;
                btn.TextColor = btnPageSample.TextColor;
                btn.HoverBackgroundColor = btnPageSample.HoverBackgroundColor;
                btn.ClickBackColor = btnPageSample.ClickBackColor;
                btn.HoverTextColor = btnPageSample.HoverTextColor;
                btn.ClickTextColor = btnPageSample.ClickTextColor;

                int page = pageNumber;
                btn.Click += (s, e) => NavigateToPage(page);
            }

            paginationPanel.Controls.Add(btn);
            pageButtons.Add(btn);
        
        }

        private void CreateNavigationButton(string text, int targetPage, bool enabled, int xPosition)
        {
            var btn = new ReaLTaiizor.Controls.ParrotButton
            {
                ButtonText = text,
                Size = new Size(40, 30),
                Location = new Point(xPosition, 10),
                CornerRadius = 3,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = enabled ? Cursors.Hand : Cursors.Default,
                ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                Horizontal_Alignment = StringAlignment.Center,
                Vertical_Alignment = StringAlignment.Center,
                TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit,
                SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality,
                Enabled = enabled,
                ButtonImage = null
            };

            if (enabled)
            {
                btn.BackgroundColor = Color.FromArgb(108, 117, 125);
                btn.TextColor = Color.White;
                btn.HoverBackgroundColor = Color.FromArgb(128, 137, 145);
                btn.ClickBackColor = Color.FromArgb(88, 97, 105);
                btn.HoverTextColor = Color.White;
                btn.ClickTextColor = Color.White;

                int page = targetPage;
                btn.Click += (s, e) => NavigateToPage(page);
            }
            else
            {
                btn.BackgroundColor = Color.FromArgb(180, 180, 180);
                btn.TextColor = Color.FromArgb(220, 220, 220);
            }

            paginationPanel.Controls.Add(btn);
            pageButtons.Add(btn);
        }

        private void CreateEllipsisLabel(int xPosition)
        {
            var lbl = new Label
            {
                Text = "...",
                Size = new Size(40, 30),
                Location = new Point(xPosition, 10),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter
            };

            paginationPanel.Controls.Add(lbl);
        }

        private void ClearPageButtons()
        {
            foreach (var btn in pageButtons)
            {
                paginationPanel.Controls.Remove(btn);
                btn.Dispose();
            }
            pageButtons.Clear();

            var controlsToRemove = new List<Control>();
            foreach (Control ctrl in paginationPanel.Controls)
            {
                if (ctrl is Label)
                {
                    controlsToRemove.Add(ctrl);
                }
            }

            foreach (var ctrl in controlsToRemove)
            {
                paginationPanel.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }

        private void NavigateToPage(int pageNumber)
        {
            if (pageNumber >= 1 && pageNumber <= totalPages && pageNumber != currentPage)
            {
                currentPage = pageNumber;
                LoadShowTimes();
            }
        }


        #endregion

        #region Filter

        private void ResetFilters()
        {
            cboMovie.SelectedIndex = 0;
            cboRoom.SelectedIndex = 0;
            cboPageSize.SelectedIndex = 0;
            currentPage = 1;
            LoadShowTimes();
        }

        #endregion

        #region Event Handlers

        private void dgvShowtimes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShowtimes.SelectedRows.Count > 0)
            {
                var row = dgvShowtimes.SelectedRows[0];
                selectedShowTimeId = (Guid)row.Cells["colShowtimeId"].Value;
            }
            else
            {
                selectedShowTimeId = null;
            }
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            bool hasSelection = selectedShowTimeId.HasValue;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;

            // Đổi màu button khi disable
            if (!hasSelection)
            {
                btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(180, 180, 180);
                btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(180, 180, 180);
            }
            else
            {
                // Giữ nguyên màu đỏ như thiết kế
                btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(220, 53, 69);
                btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(220, 53, 69);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!selectedShowTimeId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn một suất chiếu để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            var showTime = showTimeBLL.GetShowTimeById(selectedShowTimeId.Value);
            if (showTime == null)
            {
                MessageBox.Show("Không tìm thấy suất chiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // MỞ GIAO DIỆN SỬA
            var editUC = new EditShowTimeUC(_home, _employee, showTime);
            _home.LoadControl(editUC);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!selectedShowTimeId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn một suất chiếu để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteShowTime(selectedShowTimeId.Value);
        }

        private void EditShowTime(Guid showTimeId)
        {
            MessageBox.Show($"Chức năng sửa đang phát triển!\nID: {showTimeId}",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteShowTime(Guid showTimeId)
        {
            try
            {
                var showTime = showTimeBLL.GetShowTimeById(showTimeId);
                if (showTime == null)
                {
                    MessageBox.Show("Không tìm thấy suất chiếu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    $"Xác nhận xóa suất chiếu:\n\n" +
                    $"📽️ Phim: {showTime.Movie?.Title}\n" +
                    $"🎭 Phòng: {showTime.Room?.RoomName}\n" +
                    $"⏰ Thời gian: {showTime.StartTime:dd/MM/yyyy HH:mm}\n" +
                    $"💰 Giá: {showTime.Price:N0} VNĐ",
                    "⚠️ Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    var result = showTimeBLL.DeleteShowTime(showTimeId);
                    MessageBox.Show(result.message,
                        result.success ? "✓ Thành công" : "✗ Lỗi",
                        MessageBoxButtons.OK,
                        result.success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (result.success)
                    {
                        LoadShowTimes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helper Classes

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        private class ShowTimeDisplayModel
        {
            public Guid ShowTimeID { get; set; }
            public string MovieTitle { get; set; }
            public string RoomName { get; set; }
            public string StartTimeDisplay { get; set; }
            public string EndTimeDisplay { get; set; }
            public string PriceDisplay { get; set; }
            public string Status { get; set; }
            public DTO.ShowTime ShowTime { get; set; }
        }

        #endregion

        #endregion


        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private ReaLTaiizor.Controls.ParrotButton btnAddShowtime;
        private ReaLTaiizor.Controls.ParrotButton btnEdit;
        private ReaLTaiizor.Controls.ParrotButton btnDelete;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label lblRoom;
        private ReaLTaiizor.Controls.MaterialComboBox cboRoom;
        private System.Windows.Forms.Label lblMovie;
        private ReaLTaiizor.Controls.MaterialComboBox cboMovie;
        private System.Windows.Forms.Label lblPageSize;
        private ReaLTaiizor.Controls.MaterialComboBox cboPageSize;
        private ReaLTaiizor.Controls.ParrotButton btnFilter;
        private ReaLTaiizor.Controls.ParrotButton btnReset;
        private System.Windows.Forms.Panel paginationPanel;
        private ReaLTaiizor.Controls.ParrotButton btnPageSample;
        private System.Windows.Forms.Panel right_Panel;
        private System.Windows.Forms.Panel head_Right_Panel;
        private System.Windows.Forms.Panel left_Panel;
        private System.Windows.Forms.Label lblInfo;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvShowtimes;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowtimeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}