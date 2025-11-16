namespace UI
{
    partial class Test
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.airButton1 = new ReaLTaiizor.Controls.AirButton();
            this.SuspendLayout();
            // 
            // airButton1
            // 
            this.airButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.airButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airButton1.Image = null;
            this.airButton1.Location = new System.Drawing.Point(378, 206);
            this.airButton1.Name = "airButton1";
            this.airButton1.NoRounding = false;
            this.airButton1.Size = new System.Drawing.Size(100, 45);
            this.airButton1.TabIndex = 0;
            this.airButton1.Text = "airButton1";
            this.airButton1.Transparent = false;
            this.airButton1.Click += new System.EventHandler(this.airButton1_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.airButton1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AirButton airButton1;
    }
}