namespace UI.EmployeeSale
{
    partial class TicketPaymentInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblTotal;

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
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblInvoiceID
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(20, 20);
            this.lblInvoiceID.Size = new System.Drawing.Size(300, 25);

            // lblEmployee
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(20, 50);
            this.lblEmployee.Size = new System.Drawing.Size(300, 25);

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 80);
            this.lblDate.Size = new System.Drawing.Size(300, 25);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 110);
            this.lblStatus.Size = new System.Drawing.Size(300, 25);

            // lblTickets
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(20, 150);
            this.lblTickets.Size = new System.Drawing.Size(500, 60);

            // lblProducts
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(20, 220);
            this.lblProducts.Size = new System.Drawing.Size(500, 60);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(20, 300);
            this.lblTotal.Size = new System.Drawing.Size(300, 40);

            // TicketPaymentInfo
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblTotal);

            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
