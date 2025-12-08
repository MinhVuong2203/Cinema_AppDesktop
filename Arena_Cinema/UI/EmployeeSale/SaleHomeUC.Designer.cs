namespace UI.EmployeeSale
{
    partial class SaleHomeUC
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_SaleArea = new System.Windows.Forms.Panel();
            this.panel_SaleProduct = new System.Windows.Forms.Panel();
            this.lb_SaleProduct_Title = new System.Windows.Forms.Label();
            this.hopePictureBox_ = new ReaLTaiizor.Controls.HopePictureBox();
            this.btn_SaleProduct = new ReaLTaiizor.Controls.Button();
            this.panel_SaleTicket = new System.Windows.Forms.Panel();
            this.lb_SaleTicket_Title = new System.Windows.Forms.Label();
            this.hopePictureBox_Icon = new ReaLTaiizor.Controls.HopePictureBox();
            this.btn_SaleTicket = new ReaLTaiizor.Controls.Button();
            this.panelSaleAreaHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEmployeeInfor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_EmpID = new System.Windows.Forms.Label();
            this.lb_EmpIDText = new System.Windows.Forms.Label();
            this.lb_Branch = new System.Windows.Forms.Label();
            this.lb_BranchText = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_EmailText = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_PhoneText = new System.Windows.Forms.Label();
            this.lb_BthDay = new System.Windows.Forms.Label();
            this.lb_BthDayText = new System.Windows.Forms.Label();
            this.lb_Salary = new System.Windows.Forms.Label();
            this.lb_SalaryText = new System.Windows.Forms.Label();
            this.lb_workDate = new System.Windows.Forms.Label();
            this.lb_workDateText = new System.Windows.Forms.Label();
            this.lb_EmName = new System.Windows.Forms.Label();
            this.picAVT = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel_SaleArea.SuspendLayout();
            this.panel_SaleProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox_)).BeginInit();
            this.panel_SaleTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox_Icon)).BeginInit();
            this.panelSaleAreaHeader.SuspendLayout();
            this.panelEmployeeInfor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAVT)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel_SaleArea);
            this.panelMain.Controls.Add(this.panelEmployeeInfor);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1630, 740);
            this.panelMain.TabIndex = 0;
            // 
            // panel_SaleArea
            // 
            this.panel_SaleArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_SaleArea.Controls.Add(this.panel_SaleProduct);
            this.panel_SaleArea.Controls.Add(this.panel_SaleTicket);
            this.panel_SaleArea.Controls.Add(this.panelSaleAreaHeader);
            this.panel_SaleArea.Location = new System.Drawing.Point(715, 28);
            this.panel_SaleArea.Name = "panel_SaleArea";
            this.panel_SaleArea.Size = new System.Drawing.Size(848, 368);
            this.panel_SaleArea.TabIndex = 1;
            // 
            // panel_SaleProduct
            // 
            this.panel_SaleProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_SaleProduct.Controls.Add(this.lb_SaleProduct_Title);
            this.panel_SaleProduct.Controls.Add(this.hopePictureBox_);
            this.panel_SaleProduct.Controls.Add(this.btn_SaleProduct);
            this.panel_SaleProduct.Location = new System.Drawing.Point(449, 84);
            this.panel_SaleProduct.Name = "panel_SaleProduct";
            this.panel_SaleProduct.Size = new System.Drawing.Size(347, 257);
            this.panel_SaleProduct.TabIndex = 2;
            // 
            // lb_SaleProduct_Title
            // 
            this.lb_SaleProduct_Title.AutoSize = true;
            this.lb_SaleProduct_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SaleProduct_Title.Location = new System.Drawing.Point(121, 90);
            this.lb_SaleProduct_Title.Name = "lb_SaleProduct_Title";
            this.lb_SaleProduct_Title.Size = new System.Drawing.Size(118, 28);
            this.lb_SaleProduct_Title.TabIndex = 2;
            this.lb_SaleProduct_Title.Text = global::UI.Resources.Lang.BANSP;
            // 
            // hopePictureBox_
            // 
            this.hopePictureBox_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox_.Image = global::UI.Properties.Resources.popcorn;
            this.hopePictureBox_.Location = new System.Drawing.Point(139, 26);
            this.hopePictureBox_.Name = "hopePictureBox_";
            this.hopePictureBox_.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox_.Size = new System.Drawing.Size(83, 61);
            this.hopePictureBox_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox_.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox_.TabIndex = 1;
            this.hopePictureBox_.TabStop = false;
            this.hopePictureBox_.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btn_SaleProduct
            // 
            this.btn_SaleProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_SaleProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_SaleProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaleProduct.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_SaleProduct.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_SaleProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaleProduct.Image = null;
            this.btn_SaleProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaleProduct.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_SaleProduct.Location = new System.Drawing.Point(99, 184);
            this.btn_SaleProduct.Name = "btn_SaleProduct";
            this.btn_SaleProduct.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_SaleProduct.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_SaleProduct.Size = new System.Drawing.Size(171, 40);
            this.btn_SaleProduct.TabIndex = 0;
            this.btn_SaleProduct.Text = global::UI.Resources.Lang.SANPHAM;
            this.btn_SaleProduct.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_SaleProduct.Click += new System.EventHandler(this.btn_SaleProduct_Click);
            // 
            // panel_SaleTicket
            // 
            this.panel_SaleTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_SaleTicket.Controls.Add(this.lb_SaleTicket_Title);
            this.panel_SaleTicket.Controls.Add(this.hopePictureBox_Icon);
            this.panel_SaleTicket.Controls.Add(this.btn_SaleTicket);
            this.panel_SaleTicket.Location = new System.Drawing.Point(51, 84);
            this.panel_SaleTicket.Name = "panel_SaleTicket";
            this.panel_SaleTicket.Size = new System.Drawing.Size(354, 257);
            this.panel_SaleTicket.TabIndex = 1;
            // 
            // lb_SaleTicket_Title
            // 
            this.lb_SaleTicket_Title.AutoSize = true;
            this.lb_SaleTicket_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SaleTicket_Title.Location = new System.Drawing.Point(125, 90);
            this.lb_SaleTicket_Title.Name = "lb_SaleTicket_Title";
            this.lb_SaleTicket_Title.Size = new System.Drawing.Size(85, 28);
            this.lb_SaleTicket_Title.TabIndex = 2;
            this.lb_SaleTicket_Title.Text = global::UI.Resources.Lang.BanVe;
            // 
            // hopePictureBox_Icon
            // 
            this.hopePictureBox_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox_Icon.Image = global::UI.Properties.Resources.coupon;
            this.hopePictureBox_Icon.Location = new System.Drawing.Point(126, 26);
            this.hopePictureBox_Icon.Name = "hopePictureBox_Icon";
            this.hopePictureBox_Icon.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox_Icon.Size = new System.Drawing.Size(83, 61);
            this.hopePictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox_Icon.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox_Icon.TabIndex = 1;
            this.hopePictureBox_Icon.TabStop = false;
            this.hopePictureBox_Icon.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btn_SaleTicket
            // 
            this.btn_SaleTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_SaleTicket.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_SaleTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaleTicket.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_SaleTicket.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_SaleTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaleTicket.Image = null;
            this.btn_SaleTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaleTicket.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_SaleTicket.Location = new System.Drawing.Point(104, 184);
            this.btn_SaleTicket.Name = "btn_SaleTicket";
            this.btn_SaleTicket.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_SaleTicket.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btn_SaleTicket.Size = new System.Drawing.Size(141, 40);
            this.btn_SaleTicket.TabIndex = 0;
            this.btn_SaleTicket.Text = global::UI.Resources.Lang.BanVe;
            this.btn_SaleTicket.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_SaleTicket.Click += new System.EventHandler(this.btn_SaleTicket_Click);
            // 
            // panelSaleAreaHeader
            // 
            this.panelSaleAreaHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelSaleAreaHeader.Controls.Add(this.label2);
            this.panelSaleAreaHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaleAreaHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSaleAreaHeader.Name = "panelSaleAreaHeader";
            this.panelSaleAreaHeader.Size = new System.Drawing.Size(846, 60);
            this.panelSaleAreaHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = global::UI.Resources.Lang.KVBH;
            // 
            // panelEmployeeInfor
            // 
            this.panelEmployeeInfor.BackColor = System.Drawing.Color.White;
            this.panelEmployeeInfor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmployeeInfor.Controls.Add(this.tableLayoutPanel1);
            this.panelEmployeeInfor.Controls.Add(this.lb_EmName);
            this.panelEmployeeInfor.Controls.Add(this.picAVT);
            this.panelEmployeeInfor.Location = new System.Drawing.Point(28, 28);
            this.panelEmployeeInfor.Name = "panelEmployeeInfor";
            this.panelEmployeeInfor.Padding = new System.Windows.Forms.Padding(20);
            this.panelEmployeeInfor.Size = new System.Drawing.Size(650, 560);
            this.panelEmployeeInfor.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lb_EmpID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_EmpIDText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Branch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_BranchText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Email, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_EmailText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Phone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_PhoneText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_BthDay, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_BthDayText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Salary, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_SalaryText, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_workDate, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_workDateText, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 280);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 245);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lb_EmpID
            // 
            this.lb_EmpID.AutoSize = true;
            this.lb_EmpID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_EmpID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpID.Location = new System.Drawing.Point(3, 0);
            this.lb_EmpID.Name = "lb_EmpID";
            this.lb_EmpID.Size = new System.Drawing.Size(193, 35);
            this.lb_EmpID.TabIndex = 0;
            this.lb_EmpID.Text = global::UI.Resources.Lang.MaNV;
            this.lb_EmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_EmpIDText
            // 
            this.lb_EmpIDText.AutoSize = true;
            this.lb_EmpIDText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_EmpIDText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpIDText.Location = new System.Drawing.Point(202, 0);
            this.lb_EmpIDText.Name = "lb_EmpIDText";
            this.lb_EmpIDText.Size = new System.Drawing.Size(365, 35);
            this.lb_EmpIDText.TabIndex = 1;
            this.lb_EmpIDText.Text = "d0664d19-c343-428c";
            this.lb_EmpIDText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Branch
            // 
            this.lb_Branch.AutoSize = true;
            this.lb_Branch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Branch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Branch.Location = new System.Drawing.Point(3, 35);
            this.lb_Branch.Name = "lb_Branch";
            this.lb_Branch.Size = new System.Drawing.Size(193, 35);
            this.lb_Branch.TabIndex = 2;
            this.lb_Branch.Text = global::UI.Resources.Lang.DiaChi;
            this.lb_Branch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BranchText
            // 
            this.lb_BranchText.AutoSize = true;
            this.lb_BranchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_BranchText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BranchText.Location = new System.Drawing.Point(202, 35);
            this.lb_BranchText.Name = "lb_BranchText";
            this.lb_BranchText.Size = new System.Drawing.Size(365, 35);
            this.lb_BranchText.TabIndex = 3;
            this.lb_BranchText.Text = "450 Lê Văn Việt, quận 9";
            this.lb_BranchText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(3, 70);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(193, 35);
            this.lb_Email.TabIndex = 4;
            this.lb_Email.Text = "Email:";
            this.lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_EmailText
            // 
            this.lb_EmailText.AutoSize = true;
            this.lb_EmailText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_EmailText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmailText.Location = new System.Drawing.Point(202, 70);
            this.lb_EmailText.Name = "lb_EmailText";
            this.lb_EmailText.Size = new System.Drawing.Size(365, 35);
            this.lb_EmailText.TabIndex = 5;
            this.lb_EmailText.Text = "vuonghihihihi@gmail.com";
            this.lb_EmailText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Phone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.Location = new System.Drawing.Point(3, 105);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(193, 35);
            this.lb_Phone.TabIndex = 6;
            this.lb_Phone.Text = global::UI.Resources.Lang.SoDienThoai;
            this.lb_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_PhoneText
            // 
            this.lb_PhoneText.AutoSize = true;
            this.lb_PhoneText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_PhoneText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneText.Location = new System.Drawing.Point(202, 105);
            this.lb_PhoneText.Name = "lb_PhoneText";
            this.lb_PhoneText.Size = new System.Drawing.Size(365, 35);
            this.lb_PhoneText.TabIndex = 7;
            this.lb_PhoneText.Text = "0353534547";
            this.lb_PhoneText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BthDay
            // 
            this.lb_BthDay.AutoSize = true;
            this.lb_BthDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_BthDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BthDay.Location = new System.Drawing.Point(3, 140);
            this.lb_BthDay.Name = "lb_BthDay";
            this.lb_BthDay.Size = new System.Drawing.Size(193, 35);
            this.lb_BthDay.TabIndex = 8;
            this.lb_BthDay.Text = global::UI.Resources.Lang.NgaySinh;
            this.lb_BthDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BthDayText
            // 
            this.lb_BthDayText.AutoSize = true;
            this.lb_BthDayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_BthDayText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BthDayText.Location = new System.Drawing.Point(202, 140);
            this.lb_BthDayText.Name = "lb_BthDayText";
            this.lb_BthDayText.Size = new System.Drawing.Size(365, 35);
            this.lb_BthDayText.TabIndex = 9;
            this.lb_BthDayText.Text = "22/03/2005";
            this.lb_BthDayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Salary
            // 
            this.lb_Salary.AutoSize = true;
            this.lb_Salary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Salary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Salary.Location = new System.Drawing.Point(3, 175);
            this.lb_Salary.Name = "lb_Salary";
            this.lb_Salary.Size = new System.Drawing.Size(193, 35);
            this.lb_Salary.TabIndex = 10;
            this.lb_Salary.Text = global::UI.Resources.Lang.LuongGio;
            this.lb_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_SalaryText
            // 
            this.lb_SalaryText.AutoSize = true;
            this.lb_SalaryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SalaryText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SalaryText.Location = new System.Drawing.Point(202, 175);
            this.lb_SalaryText.Name = "lb_SalaryText";
            this.lb_SalaryText.Size = new System.Drawing.Size(365, 35);
            this.lb_SalaryText.TabIndex = 11;
            this.lb_SalaryText.Text = "50.000 đ";
            this.lb_SalaryText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_workDate
            // 
            this.lb_workDate.AutoSize = true;
            this.lb_workDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_workDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_workDate.Location = new System.Drawing.Point(3, 210);
            this.lb_workDate.Name = "lb_workDate";
            this.lb_workDate.Size = new System.Drawing.Size(193, 35);
            this.lb_workDate.TabIndex = 12;
            this.lb_workDate.Text = global::UI.Resources.Lang.NGAYVAOLAM;
            this.lb_workDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_workDateText
            // 
            this.lb_workDateText.AutoSize = true;
            this.lb_workDateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_workDateText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_workDateText.Location = new System.Drawing.Point(202, 210);
            this.lb_workDateText.Name = "lb_workDateText";
            this.lb_workDateText.Size = new System.Drawing.Size(365, 35);
            this.lb_workDateText.TabIndex = 13;
            this.lb_workDateText.Text = "17/11/2025";
            this.lb_workDateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_EmName
            // 
            this.lb_EmName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lb_EmName.Location = new System.Drawing.Point(20, 220);
            this.lb_EmName.Name = "lb_EmName";
            this.lb_EmName.Size = new System.Drawing.Size(608, 40);
            this.lb_EmName.TabIndex = 1;
            this.lb_EmName.Text = "Nguyễn Minh Vương";
            this.lb_EmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAVT
            // 
            this.picAVT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAVT.Location = new System.Drawing.Point(230, 30);
            this.picAVT.Name = "picAVT";
            this.picAVT.Size = new System.Drawing.Size(180, 180);
            this.picAVT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAVT.TabIndex = 2;
            this.picAVT.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1630, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(77, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Bán Hàng";
            // 
            // SaleHomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "SaleHomeUC";
            this.Size = new System.Drawing.Size(1630, 800);
            this.panelMain.ResumeLayout(false);
            this.panel_SaleArea.ResumeLayout(false);
            this.panel_SaleProduct.ResumeLayout(false);
            this.panel_SaleProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox_)).EndInit();
            this.panel_SaleTicket.ResumeLayout(false);
            this.panel_SaleTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox_Icon)).EndInit();
            this.panelSaleAreaHeader.ResumeLayout(false);
            this.panelSaleAreaHeader.PerformLayout();
            this.panelEmployeeInfor.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAVT)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Component Designer generated code

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelEmployeeInfor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_EmpID;
        private System.Windows.Forms.Label lb_EmpIDText;
        private System.Windows.Forms.Label lb_Branch;
        private System.Windows.Forms.Label lb_BranchText;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_EmailText;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_PhoneText;
        private System.Windows.Forms.Label lb_BthDay;
        private System.Windows.Forms.Label lb_BthDayText;
        private System.Windows.Forms.Label lb_Salary;
        private System.Windows.Forms.Label lb_SalaryText;
        private System.Windows.Forms.Label lb_workDate;
        private System.Windows.Forms.Label lb_workDateText;
        private System.Windows.Forms.Label lb_EmName;
        private System.Windows.Forms.PictureBox picAVT;
        private System.Windows.Forms.Panel panel_SaleArea;
        private System.Windows.Forms.Panel panelSaleAreaHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_SaleProduct;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox_Icon;
        private System.Windows.Forms.Panel panel_SaleTicket;
        private ReaLTaiizor.Controls.Button btn_SaleTicket;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox_;
        private System.Windows.Forms.Label lb_SaleProduct_Title;
        private ReaLTaiizor.Controls.Button btn_SaleProduct;
        private System.Windows.Forms.Label lb_SaleTicket_Title;

        #endregion
    }
}