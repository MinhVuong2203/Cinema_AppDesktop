namespace UI.ScreeningRoom
{
    partial class maintenanceRoom
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
            this.btnBack = new ReaLTaiizor.Controls.ParrotButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRoomsList = new System.Windows.Forms.FlowLayoutPanel();
            this.cardRoomSample = new ReaLTaiizor.Controls.MaterialCard();
            this.panelCardContent = new System.Windows.Forms.Panel();
            this.lblSeatcount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.btnBaoTri = new ReaLTaiizor.Controls.MaterialButton();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.ptbRoomImage = new System.Windows.Forms.PictureBox();
            this.btnXepGhe = new ReaLTaiizor.Controls.MaterialButton();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelRoomsList.SuspendLayout();
            this.cardRoomSample.SuspendLayout();
            this.panelCardContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRoomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1271, 60);
            this.panelHeader.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBack.ButtonImage = null;
            this.btnBack.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnBack.ButtonText = global::UI.Resources.Lang.QuayLai;
            this.btnBack.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnBack.ClickTextColor = System.Drawing.Color.White;
            this.btnBack.CornerRadius = 5;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBack.Location = new System.Drawing.Point(1134, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 60);
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
            this.lblTitle.Size = new System.Drawing.Size(236, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Phòng đang bảo trì";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.panelRoomsList);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1271, 734);
            this.panelMain.TabIndex = 6;
            // 
            // panelRoomsList
            // 
            this.panelRoomsList.Controls.Add(this.cardRoomSample);
            this.panelRoomsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoomsList.Location = new System.Drawing.Point(25, 25);
            this.panelRoomsList.Margin = new System.Windows.Forms.Padding(0);
            this.panelRoomsList.Name = "panelRoomsList";
            this.panelRoomsList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelRoomsList.Size = new System.Drawing.Size(1221, 684);
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
            this.panelCardContent.Controls.Add(this.btnXepGhe);
            this.panelCardContent.Controls.Add(this.lblSeatcount);
            this.panelCardContent.Controls.Add(this.lblDescription);
            this.panelCardContent.Controls.Add(this.lblRoomType);
            this.panelCardContent.Controls.Add(this.btnBaoTri);
            this.panelCardContent.Controls.Add(this.lblEmployeeName);
            this.panelCardContent.Controls.Add(this.lblRoomID);
            this.panelCardContent.Controls.Add(this.ptbRoomImage);
            this.panelCardContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardContent.Location = new System.Drawing.Point(15, 15);
            this.panelCardContent.Name = "panelCardContent";
            this.panelCardContent.Size = new System.Drawing.Size(432, 376);
            this.panelCardContent.TabIndex = 0;
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
            // btnBaoTri
            // 
            this.btnBaoTri.AutoSize = false;
            this.btnBaoTri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBaoTri.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoTri.Depth = 0;
            this.btnBaoTri.HighEmphasis = true;
            this.btnBaoTri.Icon = null;
            this.btnBaoTri.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnBaoTri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoTri.Location = new System.Drawing.Point(306, 328);
            this.btnBaoTri.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoTri.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoTri.Size = new System.Drawing.Size(122, 42);
            this.btnBaoTri.TabIndex = 2;
            this.btnBaoTri.Text = global::UI.Resources.Lang.KhoiPhuc;
            this.btnBaoTri.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaoTri.UseAccentColor = true;
            this.btnBaoTri.UseMnemonic = false;
            this.btnBaoTri.UseVisualStyleBackColor = false;
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
            // btnXepGhe
            // 
            this.btnXepGhe.AutoSize = false;
            this.btnXepGhe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXepGhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXepGhe.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXepGhe.Depth = 0;
            this.btnXepGhe.HighEmphasis = true;
            this.btnXepGhe.Icon = null;
            this.btnXepGhe.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXepGhe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXepGhe.Location = new System.Drawing.Point(105, 328);
            this.btnXepGhe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXepGhe.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXepGhe.Name = "btnXepGhe";
            this.btnXepGhe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXepGhe.Size = new System.Drawing.Size(151, 42);
            this.btnXepGhe.TabIndex = 8;
            this.btnXepGhe.Text = "Sắp xếp ghế";
            this.btnXepGhe.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXepGhe.UseAccentColor = true;
            this.btnXepGhe.UseMnemonic = false;
            this.btnXepGhe.UseVisualStyleBackColor = false;
            // 
            // maintenanceRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "maintenanceRoom";
            this.Size = new System.Drawing.Size(1271, 794);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelRoomsList.ResumeLayout(false);
            this.cardRoomSample.ResumeLayout(false);
            this.panelCardContent.ResumeLayout(false);
            this.panelCardContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRoomImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private ReaLTaiizor.Controls.ParrotButton btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel panelRoomsList;
        private ReaLTaiizor.Controls.MaterialCard cardRoomSample;
        private System.Windows.Forms.Panel panelCardContent;
        private System.Windows.Forms.Label lblSeatcount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRoomType;
        private ReaLTaiizor.Controls.MaterialButton btnBaoTri;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.PictureBox ptbRoomImage;
        private ReaLTaiizor.Controls.MaterialButton btnXepGhe;
    }
}
