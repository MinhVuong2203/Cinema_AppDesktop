using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using UI.Employee;

namespace UI.ShowTime
{
    partial class AddShowTimeUC
    {
        private System.ComponentModel.IContainer components = null;
        private MovieBLL movieBLL;
        private RoomBLL roomBLL;
        private ShowTimeBLL showTimeBLL;
        private Home _home;
        private DTO.Employee _employee;

        public bool IsEditMode { get; set; } = false;
        public Guid CurrentShowTimeId { get; set; } = Guid.Empty;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.btnBack = new ReaLTaiizor.Controls.ParrotButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnCancel = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSave = new ReaLTaiizor.Controls.ParrotButton();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.cboMovie = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cboRoom = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new ReaLTaiizor.Controls.MaterialTextBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblNote = new System.Windows.Forms.Label();
            this.groupBoxTimeline = new System.Windows.Forms.GroupBox();
            this.panelTimeline = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxTimeline.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.right_panel);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.btnBack);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_panel.Location = new System.Drawing.Point(1195, 0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(165, 60);
            this.right_panel.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBack.ButtonImage = null;
            this.btnBack.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnBack.ButtonText = "← Quay lại";
            this.btnBack.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnBack.ClickTextColor = System.Drawing.Color.White;
            this.btnBack.CornerRadius = 5;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBack.Location = new System.Drawing.Point(14, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 40);
            this.btnBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBack.TabIndex = 2;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎬 Thêm Suất Chiếu";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this.panelMain.Size = new System.Drawing.Size(1360, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.AutoScroll = true;
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.btnCancel);
            this.panelForm.Controls.Add(this.btnSave);
            this.panelForm.Controls.Add(this.groupBoxInfo);
            this.panelForm.Controls.Add(this.groupBoxTime);
            this.panelForm.Controls.Add(this.groupBoxTimeline);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(50, 30);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(40);
            this.panelForm.Size = new System.Drawing.Size(1260, 660);
            this.panelForm.TabIndex = 0;
            this.panelForm.Resize += new System.EventHandler(this.panelForm_Resize);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnCancel.ButtonText = "Hủy";
            this.btnCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCancel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.CornerRadius = 5;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnCancel.Location = new System.Drawing.Point(419, 705);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSave.ButtonImage = null;
            this.btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnSave.ButtonText = " Lưu";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(113, 705);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 45);
            this.btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 0;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblMovie);
            this.groupBoxInfo.Controls.Add(this.cboMovie);
            this.groupBoxInfo.Controls.Add(this.lblRoom);
            this.groupBoxInfo.Controls.Add(this.cboRoom);
            this.groupBoxInfo.Controls.Add(this.lblPrice);
            this.groupBoxInfo.Controls.Add(this.txtPrice);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxInfo.Location = new System.Drawing.Point(113, 43);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(1035, 250);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "📋 Thông Tin Suất Chiếu";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMovie.Location = new System.Drawing.Point(30, 40);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(85, 20);
            this.lblMovie.TabIndex = 0;
            this.lblMovie.Text = "Chọn Phim";
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
            this.cboMovie.Hint = "-- Chọn Phim --";
            this.cboMovie.IntegralHeight = false;
            this.cboMovie.ItemHeight = 43;
            this.cboMovie.Location = new System.Drawing.Point(30, 65);
            this.cboMovie.MaxDropDownItems = 4;
            this.cboMovie.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(426, 49);
            this.cboMovie.StartIndex = 0;
            this.cboMovie.TabIndex = 1;
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRoom.Location = new System.Drawing.Point(562, 40);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(94, 20);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Chọn Phòng";
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
            this.cboRoom.Hint = "-- Chọn Phòng --";
            this.cboRoom.IntegralHeight = false;
            this.cboRoom.ItemHeight = 43;
            this.cboRoom.Location = new System.Drawing.Point(566, 65);
            this.cboRoom.MaxDropDownItems = 4;
            this.cboRoom.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(426, 49);
            this.cboRoom.StartIndex = 0;
            this.cboRoom.TabIndex = 3;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPrice.Location = new System.Drawing.Point(30, 140);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(102, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá Vé (VNĐ)";
            // 
            // txtPrice
            // 
            this.txtPrice.AnimateReadOnly = false;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.Hint = "Nhập giá vé (VD: 85000)";
            this.txtPrice.LeadingIcon = null;
            this.txtPrice.Location = new System.Drawing.Point(30, 165);
            this.txtPrice.MaxLength = 50;
            this.txtPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(426, 50);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Text = "";
            this.txtPrice.TrailingIcon = null;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.lblStartTime);
            this.groupBoxTime.Controls.Add(this.dtpStartTime);
            this.groupBoxTime.Controls.Add(this.lblEndTime);
            this.groupBoxTime.Controls.Add(this.dtpEndTime);
            this.groupBoxTime.Controls.Add(this.lblNote);
            this.groupBoxTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxTime.Location = new System.Drawing.Point(113, 310);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(1035, 155);
            this.groupBoxTime.TabIndex = 1;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "⏰ Thời Gian Chiếu";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblStartTime.Location = new System.Drawing.Point(30, 40);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(93, 20);
            this.lblStartTime.TabIndex = 0;
            this.lblStartTime.Text = "Giờ Bắt Đầu";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(30, 65);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(426, 30);
            this.dtpStartTime.TabIndex = 1;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblEndTime.Location = new System.Drawing.Point(562, 42);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(169, 20);
            this.lblEndTime.TabIndex = 2;
            this.lblEndTime.Text = "Giờ Kết Thúc (Dự kiến)";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(566, 65);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(426, 30);
            this.dtpEndTime.TabIndex = 3;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblNote.Location = new System.Drawing.Point(30, 120);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(342, 19);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "* Giờ kết thúc tự động tính dựa trên thời lượng phim.";
            // 
            // groupBoxTimeline
            // 
            this.groupBoxTimeline.Controls.Add(this.panelTimeline);
            this.groupBoxTimeline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxTimeline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxTimeline.Location = new System.Drawing.Point(113, 480);
            this.groupBoxTimeline.Name = "groupBoxTimeline";
            this.groupBoxTimeline.Size = new System.Drawing.Size(1035, 200);
            this.groupBoxTimeline.TabIndex = 2;
            this.groupBoxTimeline.TabStop = false;
            this.groupBoxTimeline.Text = "📅 Lịch Chiếu Trong Ngày";
            // 
            // panelTimeline
            // 
            this.panelTimeline.BackColor = System.Drawing.Color.White;
            this.panelTimeline.Location = new System.Drawing.Point(30, 35);
            this.panelTimeline.Name = "panelTimeline";
            this.panelTimeline.Size = new System.Drawing.Size(975, 150);
            this.panelTimeline.TabIndex = 0;
            this.panelTimeline.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTimeline_Paint);
            // 
            // AddShowTimeUC
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "AddShowTimeUC";
            this.Size = new System.Drawing.Size(1360, 780);
            this.Load += new System.EventHandler(this.AddShowTimeUC_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.right_panel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxTimeline.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader, panelMain, panelForm;
        private GroupBox groupBoxInfo, groupBoxTime, groupBoxTimeline;
        private Label lblTitle, lblMovie, lblRoom, lblPrice, lblStartTime, lblEndTime;
        private ReaLTaiizor.Controls.MaterialComboBox cboMovie, cboRoom;
        private ReaLTaiizor.Controls.MaterialTextBox txtPrice;
        private DateTimePicker dtpStartTime, dtpEndTime;
        private ReaLTaiizor.Controls.ParrotButton btnSave, btnCancel;
        private Panel right_panel;
        private ReaLTaiizor.Controls.ParrotButton btnBack;
        private Label lblNote;
        private Panel panelTimeline;

        #region Logic Functions

        private void InitializeData(Home home, DTO.Employee employee)
        {
            _home = home;
            _employee = employee;
            movieBLL = new MovieBLL();
            roomBLL = new RoomBLL();
            showTimeBLL = new ShowTimeBLL();
        }

        private void LoadInitialData()
        {
            try
            {
                LoadMovies();
                LoadRooms();
                SetDefaultValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMovies()
        {
            var movies = movieBLL.GetAllMovies()
                .Where(m => movieBLL.GetMovieStatus(m) == "Đang chiếu" ||
                           movieBLL.GetMovieStatus(m) == "Sắp chiếu").ToList();

            cboMovie.Items.Clear();
            cboMovie.Items.Add("-- Chọn Phim --");
            movies.ForEach(m => cboMovie.Items.Add(new ComboBoxItem { Text = m.Title, Value = m.MovieID }));
            cboMovie.SelectedIndex = 0;
        }

        private void LoadRooms()
        {
            var rooms = roomBLL.GetAllRooms();
            cboRoom.Items.Clear();
            cboRoom.Items.Add("-- Chọn Phòng --");
            rooms.ForEach(r => cboRoom.Items.Add(new ComboBoxItem
            {
                Text = $"Phòng {r.RoomID} - {r.RoomName}",
                Value = r.RoomID
            }));
            cboRoom.SelectedIndex = 0;
        }

        private void SetDefaultValues()
        {
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now.AddHours(2);
            txtPrice.Text = "85000";
        }

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMovie.SelectedIndex > 0 && cboMovie.SelectedItem is ComboBoxItem item)
            {
                var movie = movieBLL.GetMovieById((int)item.Value);
                if (movie != null)
                    dtpEndTime.Value = dtpStartTime.Value.AddMinutes(movie.DurationMinutes);
            }
            
            // Refresh timeline khi đổi phim
            panelTimeline.Invalidate();
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomTimeline();
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedStartTime = dtpStartTime.Value;

                // ✅ THÊM: Kiểm tra ngày khởi chiếu của phim
                if (cboMovie.SelectedIndex > 0 && cboMovie.SelectedItem is ComboBoxItem movieItem)
                {
                    var movie = movieBLL.GetMovieById((int)movieItem.Value);
                    if (movie != null && movie.StartTime.HasValue)
                    {
                        DateTime movieStartDate = movie.StartTime.Value.Date;
                        DateTime showTimeDate = selectedStartTime.Date;

                        if (showTimeDate < movieStartDate)
                        {
                            MessageBox.Show(
                                $"⚠️ Suất chiếu không thể trước ngày khởi chiếu của phim!\n\n" +
                                $"Phim: {movie.Title}\n" +
                                $"Ngày khởi chiếu: {movieStartDate:dd/MM/yyyy}\n\n" +
                                $"Vui lòng chọn ngày từ {movieStartDate:dd/MM/yyyy} trở đi.",
                                "Kiểm tra ngày khởi chiếu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            // Tự động đặt về ngày khởi chiếu của phim
                            dtpStartTime.Value = movieStartDate.AddHours(selectedStartTime.Hour);
                            return;
                        }
                    }
                }

                // Kiểm tra giờ mở cửa: 8h - 23h
                if (selectedStartTime.Hour < 8 || selectedStartTime.Hour >= 23)
                {
                    MessageBox.Show(
                        "⚠️ Suất chiếu phải trong khung giờ 8:00 - 23:00!",
                        "Kiểm tra giờ mở cửa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    dtpStartTime.Value = DateTime.Today.AddHours(8);
                    return;
                }

                if (cboMovie.SelectedIndex > 0 && cboMovie.SelectedItem is ComboBoxItem item)
                {
                    var movie = movieBLL.GetMovieById((int)item.Value);
                    if (movie != null)
                    {
                        // Tính thời gian kết thúc
                        DateTime endTime = selectedStartTime.AddMinutes(movie.DurationMinutes);

                        // Kiểm tra endTime không vượt quá 23:00
                        if (endTime.Hour > 23 || (endTime.Hour == 23 && endTime.Minute > 0))
                        {
                            MessageBox.Show(
                                $"⚠️ Suất chiếu kết thúc lúc {endTime:HH:mm} vượt quá 23:00!\n" +
                                $"Vui lòng chọn thời gian khác.",
                                "Kiểm tra giờ kết thúc",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            dtpStartTime.Value = DateTime.Today.AddHours(8);
                            return;
                        }

                        dtpEndTime.Value = endTime;

                        // Kiểm tra khoảng cách 15 phút giữa các suất chiếu
                        if (cboRoom.SelectedIndex > 0 && cboRoom.SelectedItem is ComboBoxItem roomItem)
                        {
                            int roomId = (int)roomItem.Value;
                            var otherShowTimes = showTimeBLL.GetShowTimesByRoom(roomId);

                            foreach (var showTime in otherShowTimes)
                            {
                                // Bỏ qua suất chiếu hiện tại nếu đang edit
                                if (IsEditMode && showTime.ShowTimeID == CurrentShowTimeId)
                                    continue;

                                DateTime existingEndTime = showTime.StartTime.AddMinutes(showTime.Movie.DurationMinutes);

                                // Kiểm tra xung đột: startTime mới phải >= existingEndTime + 15 phút
                                if (selectedStartTime < existingEndTime.AddMinutes(15))
                                {
                                    // Kiểm tra xung đột ngược: endTime mới phải <= existingStartTime - 15 phút
                                    if (endTime > showTime.StartTime.AddMinutes(-15))
                                    {
                                        MessageBox.Show(
                                            $"⚠️ Lịch chiếu trùng lặp!\n\n" +
                                            $"Phim: {showTime.Movie.Title}\n" +
                                            $"Thời gian: {showTime.StartTime:dd/MM/yyyy HH:mm} - {existingEndTime:HH:mm}\n\n" +
                                            $"Các suất chiếu phải cách nhau tối thiểu 15 phút.\n" +
                                            $"Vui lòng chọn thời gian khác.",
                                            "Cảnh báo lịch chiếu",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning
                                        );
                                        dtpStartTime.Value = existingEndTime.AddMinutes(15);
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }

                // Refresh timeline khi đổi thời gian
                panelTimeline.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cboMovie.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboRoom.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Giá vé không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpStartTime.Value < DateTime.Now.AddHours(-1))
            {
                var result = MessageBox.Show("Giờ bắt đầu trong quá khứ. Tiếp tục?", "Cảnh báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return result == DialogResult.Yes;
            }
            return true;
        }

       

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        #endregion

        #region Timeline Drawing

        private void panelTimeline_Paint(object sender, PaintEventArgs e)
        {
            if (cboRoom.SelectedIndex <= 0)
            {
                DrawEmptyTimeline(e.Graphics);
                return;
            }

            DrawTimeline(e.Graphics);
        }

        private void DrawEmptyTimeline(Graphics g)
        {
            string message = "Vui lòng chọn phòng để xem lịch chiếu";
            Font font = new Font("Segoe UI", 10F, FontStyle.Italic);
            SizeF size = g.MeasureString(message, font);
            
            float x = (panelTimeline.Width - size.Width) / 2;
            float y = (panelTimeline.Height - size.Height) / 2;
            
            g.DrawString(message, font, Brushes.Gray, x, y);
        }

        private void DrawTimeline(Graphics g)
        {
            try
            {
                int width = panelTimeline.Width;
                int height = panelTimeline.Height;
                
                // Vẽ nền
                g.Clear(Color.FromArgb(250, 250, 250));
                
                // Thông số timeline
                int startHour = 8;  // 8:00 AM
                int endHour = 23;   // 11:00 PM
                int totalHours = endHour - startHour;
                
                float timelineY = 40;
                float timelineHeight = height - 80;
                float hourWidth = (width - 60) / (float)totalHours;
                
                // Vẽ trục thời gian
                Pen axisPen = new Pen(Color.FromArgb(200, 200, 200), 2);
                g.DrawLine(axisPen, 30, timelineY, width - 30, timelineY);
                
                // Vẽ các mốc giờ
                Font hourFont = new Font("Segoe UI", 8F);
                for (int i = 0; i <= totalHours; i++)
                {
                    float x = 30 + (i * hourWidth);
                    int hour = startHour + i;
                    
                    // Vẽ vạch mốc
                    g.DrawLine(axisPen, x, timelineY - 5, x, timelineY + 5);
                    
                    // Vẽ nhãn giờ
                    string hourLabel = $"{hour:00}:00";
                    SizeF labelSize = g.MeasureString(hourLabel, hourFont);
                    g.DrawString(hourLabel, hourFont, Brushes.Black, x - labelSize.Width / 2, timelineY - 25);
                }
                
                // Lấy danh sách suất chiếu trong ngày
                if (cboRoom.SelectedItem is ComboBoxItem roomItem)
                {
                    int roomId = (int)roomItem.Value;
                    DateTime today = dtpStartTime.Value.Date;
                    DateTime tomorrow = today.AddDays(1);
                    
                    var showTimes = showTimeBLL.GetShowTimesByRoom(roomId)
                        .Where(st => st.StartTime >= today && st.StartTime < tomorrow)
                        .OrderBy(st => st.StartTime)
                        .ToList();
                    
                    // Vẽ các suất chiếu
                    float blockY = timelineY + 20;
                    float blockHeight = 50;
                    
                    foreach (var showTime in showTimes)
                    {
                        var movie = movieBLL.GetMovieById(showTime.MovieID);
                        if (movie == null) continue;
                        
                        DateTime endTime = showTime.StartTime.AddMinutes(movie.DurationMinutes);
                        
                        // Tính vị trí X
                        float startX = 30 + ((float)(showTime.StartTime.Hour - startHour) + (showTime.StartTime.Minute / 60f)) * hourWidth;
                        float blockWidth = ((movie.DurationMinutes / 60f) * hourWidth);
                        
                        // Màu sắc
                        Color blockColor = Color.FromArgb(220, 53, 69);
                        Color borderColor = Color.FromArgb(180, 40, 55);
                        
                        // Kiểm tra nếu là suất chiếu đang chọn (khi edit)
                        if (IsEditMode && showTime.ShowTimeID == CurrentShowTimeId)
                        {
                            blockColor = Color.FromArgb(40, 167, 69); // Màu xanh
                            borderColor = Color.FromArgb(30, 140, 50);
                        }
                        
                        // Vẽ block suất chiếu
                        using (SolidBrush brush = new SolidBrush(blockColor))
                        using (Pen pen = new Pen(borderColor, 2))
                        {
                            RectangleF rect = new RectangleF(startX, blockY, blockWidth, blockHeight);
                            g.FillRectangle(brush, rect);
                            g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
                        }
                        
                        // Vẽ thông tin phim
                        Font titleFont = new Font("Segoe UI", 8F, FontStyle.Bold);
                        Font timeFont = new Font("Segoe UI", 7F);
                        
                        string title = movie.Title.Length > 20 ? movie.Title.Substring(0, 17) + "..." : movie.Title;
                        string timeText = $"{showTime.StartTime:HH:mm} - {endTime:HH:mm}";
                        
                        SizeF titleSize = g.MeasureString(title, titleFont);
                        SizeF timeSize = g.MeasureString(timeText, timeFont);
                        
                        // Vẽ text với shadow để dễ đọc
                        g.DrawString(title, titleFont, Brushes.White, 
                            startX + (blockWidth - titleSize.Width) / 2, 
                            blockY + 10);
                            
                        g.DrawString(timeText, timeFont, Brushes.White, 
                            startX + (blockWidth - timeSize.Width) / 2, 
                            blockY + 30);
                    }
                    
                    // Vẽ suất chiếu mới đang thêm (preview)
                    if (cboMovie.SelectedIndex > 0 && cboMovie.SelectedItem is ComboBoxItem movieItem)
                    {
                        var movie = movieBLL.GetMovieById((int)movieItem.Value);
                        if (movie != null)
                        {
                            DateTime newStart = dtpStartTime.Value;
                            DateTime newEnd = newStart.AddMinutes(movie.DurationMinutes);
                            
                            if (newStart.Date == today)
                            {
                                float startX = 30 + ((float)(newStart.Hour - startHour) + (newStart.Minute / 60f)) * hourWidth;
                                float blockWidth = ((movie.DurationMinutes / 60f) * hourWidth);
                                
                                // Vẽ với viền đứt nét (preview)
                                using (Pen pen = new Pen(Color.FromArgb(0, 123, 255), 2))
                                {
                                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                                    RectangleF rect = new RectangleF(startX, blockY, blockWidth, blockHeight);
                                    
                                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, 0, 123, 255)))
                                    {
                                        g.FillRectangle(brush, rect);
                                    }
                                    
                                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
                                    
                                    // Text
                                    Font titleFont = new Font("Segoe UI", 8F, FontStyle.Bold);
                                    Font timeFont = new Font("Segoe UI", 7F);
                                    
                                    string title = "(Mới) " + (movie.Title.Length > 15 ? movie.Title.Substring(0, 12) + "..." : movie.Title);
                                    string timeText = $"{newStart:HH:mm} - {newEnd:HH:mm}";
                                    
                                    SizeF titleSize = g.MeasureString(title, titleFont);
                                    SizeF timeSize = g.MeasureString(timeText, timeFont);
                                    
                                    g.DrawString(title, titleFont, Brushes.DarkBlue, 
                                        startX + (blockWidth - titleSize.Width) / 2, 
                                        blockY + 10);
                                        
                                    g.DrawString(timeText, timeFont, Brushes.DarkBlue, 
                                        startX + (blockWidth - timeSize.Width) / 2, 
                                        blockY + 30);
                                }
                            }
                        }
                    }
                    
                    // Chú thích
                    Font legendFont = new Font("Segoe UI", 8F);
                    g.DrawString("■ Suất chiếu hiện tại", legendFont, new SolidBrush(Color.FromArgb(220, 53, 69)), 30, height - 25);
                    g.DrawString("▪ Suất chiếu mới", legendFont, new SolidBrush(Color.FromArgb(0, 123, 255)), 180, height - 25);
                }
            }
            catch (Exception ex)
            {
                Font errorFont = new Font("Segoe UI", 9F);
                g.DrawString("Lỗi: " + ex.Message, errorFont, Brushes.Red, 10, 10);
            }
        }

        private void LoadRoomTimeline()
        {
            panelTimeline.Invalidate(); // Vẽ lại timeline
        }

        #endregion

        #region Auto Center Layout

        private void AddShowTimeUC_Load(object sender, EventArgs e)
        {
            // Căn giữa controls khi load lần đầu
            CenterControlsInPanel();
        }

        private void panelForm_Resize(object sender, EventArgs e)
        {
            // Căn giữa controls khi resize
            CenterControlsInPanel();
        }

        private void CenterControlsInPanel()
        {
            if (panelForm == null) return;

            // Tính toán vị trí X để căn giữa các GroupBox
            int panelWidth = panelForm.ClientSize.Width;
            int groupBoxWidth = 1035; // Chiều rộng của GroupBox

            // Tính toán X để căn giữa
            int centerX = (panelWidth - groupBoxWidth) / 2;

            // Đảm bảo không bị âm
            if (centerX < 40) centerX = 40;

            // Căn giữa groupBoxInfo
            if (groupBoxInfo != null)
            {
                groupBoxInfo.Location = new Point(centerX, groupBoxInfo.Location.Y);
            }

            // Căn giữa groupBoxTime
            if (groupBoxTime != null)
            {
                groupBoxTime.Location = new Point(centerX, groupBoxTime.Location.Y);
            }

            // Căn giữa groupBoxTimeline
            if (groupBoxTimeline != null)
            {
                groupBoxTimeline.Location = new Point(centerX, groupBoxTimeline.Location.Y);
            }

            // Căn giữa các nút
            int buttonAreaWidth = 200 + 150 + 100; // btnSave + btnCancel + spacing
            int buttonStartX = (panelWidth - buttonAreaWidth) / 2;

            if (buttonStartX < 40) buttonStartX = 40;

            if (btnSave != null)
            {
                btnSave.Location = new Point(buttonStartX, btnSave.Location.Y);
            }

            if (btnCancel != null)
            {
                btnCancel.Location = new Point(buttonStartX + 200 + 106, btnCancel.Location.Y);
            }
        }

        #endregion
    }
}