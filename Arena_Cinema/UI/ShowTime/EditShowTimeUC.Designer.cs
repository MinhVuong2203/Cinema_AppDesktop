using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UI.Employee;
using UI.Movie;

namespace UI.ShowTime
{
    partial class EditShowTimeUC
    {
        private System.ComponentModel.IContainer components = null;
        private MovieBLL movieBLL;
        private RoomBLL roomBLL;
        private ShowTimeBLL showTimeBLL;
        private Home _home;
        private DTO.Employee _employee;
        private DTO.ShowTime _currentShowTime;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditShowTimeUC));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.btnBack = new ReaLTaiizor.Controls.ParrotButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnCancel = new ReaLTaiizor.Controls.ParrotButton();
            this.btnUpdate = new ReaLTaiizor.Controls.ParrotButton();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblShowTimeID = new System.Windows.Forms.Label();
            this.txtShowTimeID = new System.Windows.Forms.TextBox();
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
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.lblTicketsSoldLabel = new System.Windows.Forms.Label();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();

            // Wire up events
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            this.panelForm.Resize += new System.EventHandler(this.panelForm_Resize);
            this.Load += new System.EventHandler(this.EditShowTimeUC_Load);

            this.panelHeader.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
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
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "✏️ Sửa Suất Chiếu";
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
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.groupBoxInfo);
            this.panelForm.Controls.Add(this.groupBoxTime);
            this.panelForm.Controls.Add(this.groupBoxStatus);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(50, 30);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(40);
            this.panelForm.Size = new System.Drawing.Size(1260, 660);
            this.panelForm.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnCancel.ButtonText = "✖ Hủy";
            this.btnCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCancel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.CornerRadius = 5;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnCancel.Location = new System.Drawing.Point(419, 652);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnUpdate.ButtonImage = null;
            this.btnUpdate.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnUpdate.ButtonText = "💾 Cập Nhật";
            this.btnUpdate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUpdate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.CornerRadius = 5;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(79)))));
            this.btnUpdate.HoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnUpdate.Location = new System.Drawing.Point(113, 652);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 45);
            this.btnUpdate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblShowTimeID);
            this.groupBoxInfo.Controls.Add(this.txtShowTimeID);
            this.groupBoxInfo.Controls.Add(this.lblMovie);
            this.groupBoxInfo.Controls.Add(this.cboMovie);
            this.groupBoxInfo.Controls.Add(this.lblRoom);
            this.groupBoxInfo.Controls.Add(this.cboRoom);
            this.groupBoxInfo.Controls.Add(this.lblPrice);
            this.groupBoxInfo.Controls.Add(this.txtPrice);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.groupBoxInfo.Location = new System.Drawing.Point(113, 43);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(1035, 305);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "📋 Thông Tin Suất Chiếu";
            // 
            // lblShowTimeID
            // 
            this.lblShowTimeID.AutoSize = true;
            this.lblShowTimeID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblShowTimeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblShowTimeID.Location = new System.Drawing.Point(30, 35);
            this.lblShowTimeID.Name = "lblShowTimeID";
            this.lblShowTimeID.Size = new System.Drawing.Size(106, 20);
            this.lblShowTimeID.TabIndex = 0;
            this.lblShowTimeID.Text = "Mã Suất Chiếu";
            // 
            // txtShowTimeID
            // 
            this.txtShowTimeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtShowTimeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShowTimeID.Enabled = false;
            this.txtShowTimeID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtShowTimeID.Location = new System.Drawing.Point(30, 58);
            this.txtShowTimeID.Name = "txtShowTimeID";
            this.txtShowTimeID.ReadOnly = true;
            this.txtShowTimeID.Size = new System.Drawing.Size(962, 30);
            this.txtShowTimeID.TabIndex = 1;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMovie.Location = new System.Drawing.Point(30, 105);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(85, 20);
            this.lblMovie.TabIndex = 2;
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
            this.cboMovie.Location = new System.Drawing.Point(30, 128);
            this.cboMovie.MaxDropDownItems = 4;
            this.cboMovie.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(426, 49);
            this.cboMovie.StartIndex = 0;
            this.cboMovie.TabIndex = 3;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRoom.Location = new System.Drawing.Point(566, 105);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(94, 20);
            this.lblRoom.TabIndex = 4;
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
            this.cboRoom.Location = new System.Drawing.Point(566, 128);
            this.cboRoom.MaxDropDownItems = 4;
            this.cboRoom.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(426, 49);
            this.cboRoom.StartIndex = 0;
            this.cboRoom.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPrice.Location = new System.Drawing.Point(30, 195);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(102, 20);
            this.lblPrice.TabIndex = 6;
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
            this.txtPrice.Location = new System.Drawing.Point(30, 218);
            this.txtPrice.MaxLength = 50;
            this.txtPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(426, 50);
            this.txtPrice.TabIndex = 7;
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
            this.groupBoxTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.groupBoxTime.Location = new System.Drawing.Point(113, 365);
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
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblEndTime.Location = new System.Drawing.Point(566, 40);
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
            this.lblNote.Location = new System.Drawing.Point(30, 115);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(342, 19);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "* Giờ kết thúc tự động tính dựa trên thời lượng phim.";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.lblTicketsSoldLabel);
            this.groupBoxStatus.Controls.Add(this.lblTicketsSold);
            this.groupBoxStatus.Controls.Add(this.lblStatusLabel);
            this.groupBoxStatus.Controls.Add(this.lblStatus);
            this.groupBoxStatus.Controls.Add(this.lblWarning);
            this.groupBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.groupBoxStatus.Location = new System.Drawing.Point(113, 537);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(1035, 95);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "ℹ️ Trạng Thái";
            // 
            // lblTicketsSoldLabel
            // 
            this.lblTicketsSoldLabel.AutoSize = true;
            this.lblTicketsSoldLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTicketsSoldLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTicketsSoldLabel.Location = new System.Drawing.Point(30, 35);
            this.lblTicketsSoldLabel.Name = "lblTicketsSoldLabel";
            this.lblTicketsSoldLabel.Size = new System.Drawing.Size(91, 20);
            this.lblTicketsSoldLabel.TabIndex = 0;
            this.lblTicketsSoldLabel.Text = "Số vé đã bán:";
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTicketsSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTicketsSold.Location = new System.Drawing.Point(127, 35);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(18, 20);
            this.lblTicketsSold.TabIndex = 1;
            this.lblTicketsSold.Text = "0";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblStatusLabel.Location = new System.Drawing.Point(350, 35);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(80, 20);
            this.lblStatusLabel.TabIndex = 2;
            this.lblStatusLabel.Text = "Trạng thái:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblStatus.Location = new System.Drawing.Point(436, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Sắp chiếu";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblWarning.Location = new System.Drawing.Point(30, 65);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 19);
            this.lblWarning.TabIndex = 4;
            // 
            // EditShowTimeUC
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "EditShowTimeUC";
            this.Size = new System.Drawing.Size(1360, 780);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.right_panel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader, panelMain, panelForm, right_panel;
        private GroupBox groupBoxInfo, groupBoxTime, groupBoxStatus;
        private Label lblTitle, lblShowTimeID, lblMovie, lblRoom, lblPrice;
        private Label lblStartTime, lblEndTime, lblNote;
        private Label lblTicketsSoldLabel, lblTicketsSold, lblStatusLabel, lblStatus, lblWarning;
        private TextBox txtShowTimeID;
        private ReaLTaiizor.Controls.MaterialComboBox cboMovie, cboRoom;
        private ReaLTaiizor.Controls.MaterialTextBox txtPrice;
        private DateTimePicker dtpStartTime, dtpEndTime;
        private ReaLTaiizor.Controls.ParrotButton btnUpdate, btnCancel, btnBack;

        #region Logic Functions

        public void InitializeData(Home home, DTO.Employee employee, DTO.ShowTime showTime)
        {
            _home = home;
            _employee = employee;
            _currentShowTime = showTime;
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
                LoadShowTimeData();
                LoadStatusInfo();
                CheckEditability();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMovies()
        {
            var movies = movieBLL.GetAllMovies()
                .Where(m => movieBLL.GetMovieStatus(m) == "Đang chiếu" ||
                           movieBLL.GetMovieStatus(m) == "Sắp chiếu").ToList();

            cboMovie.Items.Clear();
            cboMovie.Items.Add("-- Chọn Phim --");
            movies.ForEach(m => cboMovie.Items.Add(new ComboBoxItem
            {
                Text = m.Title,
                Value = m.MovieID
            }));
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
        }

        private void LoadShowTimeData()
        {
            if (_currentShowTime == null) return;

            // Load thông tin cơ bản
            txtShowTimeID.Text = _currentShowTime.ShowTimeID.ToString();
            dtpStartTime.Value = _currentShowTime.StartTime;
            txtPrice.Text = _currentShowTime.Price.ToString();

            // Chọn phim
            for (int i = 1; i < cboMovie.Items.Count; i++)
            {
                if (cboMovie.Items[i] is ComboBoxItem item &&
                    (int)item.Value == _currentShowTime.MovieID)
                {
                    cboMovie.SelectedIndex = i;
                    break;
                }
            }

            // Chọn phòng
            for (int i = 1; i < cboRoom.Items.Count; i++)
            {
                if (cboRoom.Items[i] is ComboBoxItem item &&
                    (int)item.Value == _currentShowTime.RoomID)
                {
                    cboRoom.SelectedIndex = i;
                    break;
                }
            }

            // Cập nhật thời gian kết thúc
            UpdateEndTime();
        }

        private void LoadStatusInfo()
        {
            if (_currentShowTime == null) return;

            // Đếm số vé đã bán
            int ticketsSold = showTimeBLL.CountTicketsSold(_currentShowTime.ShowTimeID);
            lblTicketsSold.Text = ticketsSold.ToString();
            lblTicketsSold.ForeColor = ticketsSold > 0
                ? Color.FromArgb(220, 53, 69)
                : Color.FromArgb(40, 167, 69);

            // Hiển thị trạng thái
            string status = showTimeBLL.GetShowTimeStatus(_currentShowTime);
            lblStatus.Text = status;

            switch (status)
            {
                case "Sắp chiếu":
                    lblStatus.ForeColor = Color.FromArgb(40, 167, 69);
                    break;
                case "Đang chiếu":
                    lblStatus.ForeColor = Color.FromArgb(255, 193, 7);
                    break;
                case "Đã chiếu":
                    lblStatus.ForeColor = Color.FromArgb(108, 117, 125);
                    break;
            }
        }

        private void CheckEditability()
        {
            if (_currentShowTime == null) return;

            int ticketsSold = showTimeBLL.CountTicketsSold(_currentShowTime.ShowTimeID);

            if (ticketsSold > 0)
            {
                lblWarning.Text = $"⚠️ Cảnh báo: Suất chiếu này đã có {ticketsSold} vé được bán. Việc chỉnh sửa có thể ảnh hưởng đến khách hàng!";
                lblWarning.ForeColor = Color.FromArgb(220, 53, 69);
            }
            else
            {
                lblWarning.Text = "✓ Suất chiếu này chưa có vé nào được bán, có thể chỉnh sửa thoải mái.";
                lblWarning.ForeColor = Color.FromArgb(40, 167, 69);
            }
        }

        private void UpdateEndTime()
        {
            if (cboMovie.SelectedIndex > 0 && cboMovie.SelectedItem is ComboBoxItem item)
            {
                var movie = movieBLL.GetMovieById((int)item.Value);
                if (movie != null)
                {
                    dtpEndTime.Value = dtpStartTime.Value.AddMinutes(movie.DurationMinutes);
                }
            }
        }

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEndTime();
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateEndTime();
        }

        private bool ValidateInput()
        {
            if (cboMovie.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboRoom.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Giá vé không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpStartTime.Value < DateTime.Now.AddHours(-1))
            {
                var result = MessageBox.Show(
                    "Giờ bắt đầu trong quá khứ. Bạn có chắc chắn muốn tiếp tục?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return false;
            }

            // Kiểm tra nếu đã có vé bán
            int ticketsSold = showTimeBLL.CountTicketsSold(_currentShowTime.ShowTimeID);
            if (ticketsSold > 0)
            {
                var result = MessageBox.Show(
                    $"Suất chiếu này đã có {ticketsSold} vé được bán.\n" +
                    $"Việc thay đổi có thể ảnh hưởng đến khách hàng.\n\n" +
                    $"Bạn có chắc chắn muốn cập nhật?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return false;
            }

            return true;
        }

        private void SaveShowTime()
        {
            try
            {
                if (!ValidateInput()) return;

                // Lấy dữ liệu từ form
                var movieItem = cboMovie.SelectedItem as ComboBoxItem;
                var roomItem = cboRoom.SelectedItem as ComboBoxItem;
                decimal price = decimal.Parse(txtPrice.Text);

                // Cập nhật thông tin
                _currentShowTime.MovieID = (int)movieItem.Value;
                _currentShowTime.RoomID = (int)roomItem.Value;
                _currentShowTime.StartTime = dtpStartTime.Value;
                _currentShowTime.Price = price;

                // Gọi BLL để cập nhật
                var result = showTimeBLL.UpdateShowTime(_currentShowTime);

                if (result.success)
                {
                    MessageBox.Show(result.message, "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Quay lại trang danh sách
                    Movie_MainUC movieMain = new Movie_MainUC(_home, _employee);
                    _home.LoadControl(movieMain);
                }
                else
                {
                    MessageBox.Show(result.message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        #endregion

        #region Auto Center Layout

        

        private void panelForm_Resize(object sender, EventArgs e)
        {
            CenterControlsInPanel();
        }

        private void CenterControlsInPanel()
        {
            if (panelForm == null) return;

            int panelWidth = panelForm.ClientSize.Width;
            int groupBoxWidth = 1035;
            int centerX = (panelWidth - groupBoxWidth) / 2;
            if (centerX < 40) centerX = 40;

            // Căn giữa các GroupBox
            if (groupBoxInfo != null)
                groupBoxInfo.Location = new Point(centerX, groupBoxInfo.Location.Y);

            if (groupBoxTime != null)
                groupBoxTime.Location = new Point(centerX, groupBoxTime.Location.Y);

            if (groupBoxStatus != null)
                groupBoxStatus.Location = new Point(centerX, groupBoxStatus.Location.Y);

            // Căn giữa các nút
            int buttonAreaWidth = 200 + 150 + 106;
            int buttonStartX = (panelWidth - buttonAreaWidth) / 2;
            if (buttonStartX < 40) buttonStartX = 40;

            if (btnUpdate != null)
                btnUpdate.Location = new Point(buttonStartX, btnUpdate.Location.Y);

            if (btnCancel != null)
                btnCancel.Location = new Point(buttonStartX + 200 + 106, btnCancel.Location.Y);
        }

        #endregion
    }
}