namespace UI.SeatManagement
{
    partial class SeatManagementUC
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRoomsList = new System.Windows.Forms.FlowLayoutPanel();
            this.ColPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SeatLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cardSeatSample = new ReaLTaiizor.Controls.MaterialCard();
            this.panelCardContent = new System.Windows.Forms.Panel();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelRoomsList.SuspendLayout();
            this.SeatLayoutPanel.SuspendLayout();
            this.cardSeatSample.SuspendLayout();
            this.panelCardContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1692, 60);
            this.panelHeader.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản lý ghế của:";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.panelRoomsList);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1692, 885);
            this.panelMain.TabIndex = 6;
            // 
            // panelRoomsList
            // 
            this.panelRoomsList.Controls.Add(this.ColPanel);
            this.panelRoomsList.Controls.Add(this.SeatLayoutPanel);
            this.panelRoomsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoomsList.Location = new System.Drawing.Point(25, 25);
            this.panelRoomsList.Margin = new System.Windows.Forms.Padding(10);
            this.panelRoomsList.Name = "panelRoomsList";
            this.panelRoomsList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelRoomsList.Size = new System.Drawing.Size(1642, 835);
            this.panelRoomsList.TabIndex = 4;
            // 
            // ColPanel
            // 
            this.ColPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ColPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColPanel.Location = new System.Drawing.Point(3, 13);
            this.ColPanel.Name = "ColPanel";
            this.ColPanel.Padding = new System.Windows.Forms.Padding(15);
            this.ColPanel.Size = new System.Drawing.Size(1312, 50);
            this.ColPanel.TabIndex = 2;
            // 
            // SeatLayoutPanel
            // 
            this.SeatLayoutPanel.Controls.Add(this.cardSeatSample);
            this.SeatLayoutPanel.Location = new System.Drawing.Point(3, 69);
            this.SeatLayoutPanel.Name = "SeatLayoutPanel";
            this.SeatLayoutPanel.Size = new System.Drawing.Size(1636, 791);
            this.SeatLayoutPanel.TabIndex = 0;
            // 
            // cardSeatSample
            // 
            this.cardSeatSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSeatSample.Controls.Add(this.panelCardContent);
            this.cardSeatSample.Depth = 0;
            this.cardSeatSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSeatSample.Location = new System.Drawing.Point(3, 3);
            this.cardSeatSample.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.cardSeatSample.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cardSeatSample.Name = "cardSeatSample";
            this.cardSeatSample.Padding = new System.Windows.Forms.Padding(15);
            this.cardSeatSample.Size = new System.Drawing.Size(76, 58);
            this.cardSeatSample.TabIndex = 0;
            // 
            // panelCardContent
            // 
            this.panelCardContent.Controls.Add(this.lblRoomName);
            this.panelCardContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardContent.Location = new System.Drawing.Point(15, 15);
            this.panelCardContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelCardContent.Name = "panelCardContent";
            this.panelCardContent.Size = new System.Drawing.Size(46, 28);
            this.panelCardContent.TabIndex = 0;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblRoomName.Location = new System.Drawing.Point(3, 0);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(42, 23);
            this.lblRoomName.TabIndex = 2;
            this.lblRoomName.Text = "A01";
            // 
            // SeatManagementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "SeatManagementUC";
            this.Size = new System.Drawing.Size(1692, 945);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelRoomsList.ResumeLayout(false);
            this.SeatLayoutPanel.ResumeLayout(false);
            this.cardSeatSample.ResumeLayout(false);
            this.panelCardContent.ResumeLayout(false);
            this.panelCardContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel SeatLayoutPanel;
        private ReaLTaiizor.Controls.MaterialCard cardSeatSample;
        private System.Windows.Forms.Panel panelCardContent;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel panelRoomsList;
        private System.Windows.Forms.Panel ColPanel;
    }
}
