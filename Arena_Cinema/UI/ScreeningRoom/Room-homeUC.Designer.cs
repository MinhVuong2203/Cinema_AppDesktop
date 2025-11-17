namespace UI.ScreeningRoom
{
    partial class Room_homeUC
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddRoom = new ReaLTaiizor.Controls.ParrotButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRoomsList = new System.Windows.Forms.FlowLayoutPanel();
            this.cardRoomSample = new ReaLTaiizor.Controls.MaterialCard();
            this.panelCardContent = new System.Windows.Forms.Panel();
            this.btnSeatManagement = new ReaLTaiizor.Controls.MaterialButton();
            this.lblSeatcount = new System.Windows.Forms.Label();
            this.btnSua = new ReaLTaiizor.Controls.MaterialButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.btnXoa = new ReaLTaiizor.Controls.MaterialButton();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.ptbRoomImage = new System.Windows.Forms.PictureBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.left_Panel = new System.Windows.Forms.Panel();
            this.lblMovie = new System.Windows.Forms.Label();
            this.cboRoomType = new ReaLTaiizor.Controls.MaterialComboBox();
            this.right_Panel = new System.Windows.Forms.Panel();
            this.btnDeletedRoom = new ReaLTaiizor.Controls.ParrotButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelRoomsList.SuspendLayout();
            this.cardRoomSample.SuspendLayout();
            this.panelCardContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRoomImage)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(1376, 60);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 14);
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
            this.btnAddRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnAddRoom.HoverTextColor = System.Drawing.Color.White;
            this.btnAddRoom.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnAddRoom.Location = new System.Drawing.Point(1206, 0);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(170, 60);
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
            this.panelMain.Controls.Add(this.panelRoomsList);
            this.panelMain.Controls.Add(this.filterPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1376, 737);
            this.panelMain.TabIndex = 3;
            // 
            // panelRoomsList
            // 
            this.panelRoomsList.Controls.Add(this.cardRoomSample);
            this.panelRoomsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoomsList.Location = new System.Drawing.Point(25, 174);
            this.panelRoomsList.Margin = new System.Windows.Forms.Padding(10);
            this.panelRoomsList.Name = "panelRoomsList";
            this.panelRoomsList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelRoomsList.Size = new System.Drawing.Size(1326, 538);
            this.panelRoomsList.TabIndex = 4;
            // 
            // cardRoomSample
            // 
            this.cardRoomSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRoomSample.Controls.Add(this.panelCardContent);
            this.cardRoomSample.Depth = 0;
            this.cardRoomSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRoomSample.Location = new System.Drawing.Point(3, 13);
            this.cardRoomSample.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.cardRoomSample.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cardRoomSample.Name = "cardRoomSample";
            this.cardRoomSample.Padding = new System.Windows.Forms.Padding(15);
            this.cardRoomSample.Size = new System.Drawing.Size(462, 406);
            this.cardRoomSample.TabIndex = 0;
            // 
            // panelCardContent
            // 
            this.panelCardContent.Controls.Add(this.btnSeatManagement);
            this.panelCardContent.Controls.Add(this.lblSeatcount);
            this.panelCardContent.Controls.Add(this.btnSua);
            this.panelCardContent.Controls.Add(this.lblDescription);
            this.panelCardContent.Controls.Add(this.lblRoomType);
            this.panelCardContent.Controls.Add(this.btnXoa);
            this.panelCardContent.Controls.Add(this.lblEmployeeName);
            this.panelCardContent.Controls.Add(this.lblRoomID);
            this.panelCardContent.Controls.Add(this.ptbRoomImage);
            this.panelCardContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardContent.Location = new System.Drawing.Point(15, 15);
            this.panelCardContent.Name = "panelCardContent";
            this.panelCardContent.Size = new System.Drawing.Size(432, 376);
            this.panelCardContent.TabIndex = 0;
            // 
            // btnSeatManagement
            // 
            this.btnSeatManagement.AutoSize = false;
            this.btnSeatManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeatManagement.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSeatManagement.Depth = 0;
            this.btnSeatManagement.HighEmphasis = true;
            this.btnSeatManagement.Icon = global::UI.Properties.Resources.armchair;
            this.btnSeatManagement.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSeatManagement.Location = new System.Drawing.Point(61, 328);
            this.btnSeatManagement.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSeatManagement.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSeatManagement.Name = "btnSeatManagement";
            this.btnSeatManagement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSeatManagement.Size = new System.Drawing.Size(147, 42);
            this.btnSeatManagement.TabIndex = 8;
            this.btnSeatManagement.Text = "Sắp xếp ghế";
            this.btnSeatManagement.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSeatManagement.UseAccentColor = false;
            this.btnSeatManagement.UseVisualStyleBackColor = true;
            // 
            // lblSeatcount
            // 
            this.lblSeatcount.AutoSize = true;
            this.lblSeatcount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSeatcount.Location = new System.Drawing.Point(5, 142);
            this.lblSeatcount.Name = "lblSeatcount";
            this.lblSeatcount.Size = new System.Drawing.Size(134, 28);
            this.lblSeatcount.TabIndex = 7;
            this.lblSeatcount.Text = "Số lượng ghế:";
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = global::UI.Properties.Resources.edit;
            this.btnSua.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSua.Location = new System.Drawing.Point(216, 329);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(100, 42);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDescription.Location = new System.Drawing.Point(4, 193);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(423, 122);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "SĐT: 0123456789";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblRoomType.Location = new System.Drawing.Point(4, 100);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(111, 28);
            this.lblRoomType.TabIndex = 4;
            this.lblRoomType.Text = "Loại phòng";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = global::UI.Properties.Resources.trash;
            this.btnXoa.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(328, 328);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(100, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = true;
            this.btnXoa.UseMnemonic = false;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(4, 54);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(99, 30);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Phòng 1";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.ForeColor = System.Drawing.Color.Brown;
            this.lblRoomID.Location = new System.Drawing.Point(5, 13);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(57, 23);
            this.lblRoomID.TabIndex = 1;
            this.lblRoomID.Text = "Room";
            // 
            // ptbRoomImage
            // 
            this.ptbRoomImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ptbRoomImage.Location = new System.Drawing.Point(176, 10);
            this.ptbRoomImage.Name = "ptbRoomImage";
            this.ptbRoomImage.Size = new System.Drawing.Size(245, 180);
            this.ptbRoomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRoomImage.TabIndex = 0;
            this.ptbRoomImage.TabStop = false;
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
            this.filterPanel.Size = new System.Drawing.Size(1326, 149);
            this.filterPanel.TabIndex = 0;
            // 
            // left_Panel
            // 
            this.left_Panel.Controls.Add(this.lblMovie);
            this.left_Panel.Controls.Add(this.cboRoomType);
            this.left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_Panel.Location = new System.Drawing.Point(15, 15);
            this.left_Panel.Name = "left_Panel";
            this.left_Panel.Size = new System.Drawing.Size(826, 84);
            this.left_Panel.TabIndex = 9;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMovie.Location = new System.Drawing.Point(16, 5);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(84, 20);
            this.lblMovie.TabIndex = 2;
            this.lblMovie.Text = "Loại phòng";
            // 
            // cboRoomType
            // 
            this.cboRoomType.AutoResize = false;
            this.cboRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRoomType.Depth = 0;
            this.cboRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboRoomType.DropDownHeight = 174;
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.DropDownWidth = 121;
            this.cboRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Hint = "-- Chọn loại phòng --";
            this.cboRoomType.IntegralHeight = false;
            this.cboRoomType.ItemHeight = 43;
            this.cboRoomType.Location = new System.Drawing.Point(16, 28);
            this.cboRoomType.MaxDropDownItems = 4;
            this.cboRoomType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(420, 49);
            this.cboRoomType.StartIndex = 0;
            this.cboRoomType.TabIndex = 3;
            // 
            // right_Panel
            // 
            this.right_Panel.Controls.Add(this.btnDeletedRoom);
            this.right_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_Panel.Location = new System.Drawing.Point(847, 15);
            this.right_Panel.Name = "right_Panel";
            this.right_Panel.Size = new System.Drawing.Size(464, 84);
            this.right_Panel.TabIndex = 8;
            // 
            // btnDeletedRoom
            // 
            this.btnDeletedRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnDeletedRoom.ButtonImage = null;
            this.btnDeletedRoom.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDeletedRoom.ButtonText = "Phòng đã xóa";
            this.btnDeletedRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDeletedRoom.ClickTextColor = System.Drawing.Color.White;
            this.btnDeletedRoom.CornerRadius = 5;
            this.btnDeletedRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletedRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeletedRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeletedRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeletedRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnDeletedRoom.HoverTextColor = System.Drawing.Color.White;
            this.btnDeletedRoom.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDeletedRoom.Location = new System.Drawing.Point(294, 0);
            this.btnDeletedRoom.Name = "btnDeletedRoom";
            this.btnDeletedRoom.Size = new System.Drawing.Size(170, 84);
            this.btnDeletedRoom.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDeletedRoom.TabIndex = 3;
            this.btnDeletedRoom.TextColor = System.Drawing.Color.White;
            this.btnDeletedRoom.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDeletedRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeletedRoom.Click += new System.EventHandler(this.btnDeletedRoom_Click);
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
            this.lblInfo.Size = new System.Drawing.Size(1296, 35);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Hiển thị 10 trong tổng số 25 phòng | Trang 1 / 3";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Room_homeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "Room_homeUC";
            this.Size = new System.Drawing.Size(1376, 797);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelRoomsList.ResumeLayout(false);
            this.cardRoomSample.ResumeLayout(false);
            this.panelCardContent.ResumeLayout(false);
            this.panelCardContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRoomImage)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel panelRoomsList;
        private ReaLTaiizor.Controls.MaterialCard cardRoomSample;
        private System.Windows.Forms.Panel panelCardContent;
        private System.Windows.Forms.Label lblSeatcount;
        private ReaLTaiizor.Controls.MaterialButton btnSua;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRoomType;
        private ReaLTaiizor.Controls.MaterialButton btnXoa;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.PictureBox ptbRoomImage;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel left_Panel;
        private System.Windows.Forms.Label lblMovie;
        private ReaLTaiizor.Controls.MaterialComboBox cboRoomType;
        private System.Windows.Forms.Panel right_Panel;
        private ReaLTaiizor.Controls.ParrotButton btnDeletedRoom;
        private ReaLTaiizor.Controls.MaterialButton btnSeatManagement;
        private System.Windows.Forms.Label lblInfo;
    }
}
