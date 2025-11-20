using System;
using System.Drawing;
using System.Windows.Forms;
using DTO;

namespace UI.SeatManagement
{
    public partial class AddSeatForm : Form
    {
        public Seat NewSeat { get; private set; }
        private int _roomId;

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private Label lblSeatName;
        private TextBox txtSeatName;
        private Label lblSeatNameHint;
        private Label lblSeatType;
        private ComboBox cboSeatType;
        private Button btnAdd;
        private Button btnCancel;

        public AddSeatForm(int roomId)
        {
            _roomId = roomId;
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ClientSize = new Size(560, 400);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9F);

            this.ResumeLayout(false);
        }

        private void InitializeControls()
        {
            // ========== HEADER ==========
            pnlHeader = new Panel
            {
                BackColor = Color.FromArgb(0, 102, 204),
                Dock = DockStyle.Top,
                Height = 70
            };
            this.Controls.Add(pnlHeader);

            lblTitle = new Label
            {
                Text = "Thêm Ghế Mới",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 22),
                AutoSize = true
            };
            pnlHeader.Controls.Add(lblTitle);

            btnClose = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(45, 45),
                Location = new Point(505, 12),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 53, 69);
            btnClose.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            pnlHeader.Controls.Add(btnClose);

            // ========== TÊN GHẾ ==========
            lblSeatName = new Label
            {
                Text = "Tên Ghế *",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(30, 100),
                AutoSize = true
            };
            this.Controls.Add(lblSeatName);

            txtSeatName = new TextBox
            {
                Font = new Font("Segoe UI", 12F),
                Location = new Point(30, 125),
                Size = new Size(500, 34),
                BorderStyle = BorderStyle.FixedSingle,
                Text = "Ví dụ: Q01, VIP01",
                ForeColor = Color.Gray
            };
            this.Controls.Add(txtSeatName);

            // Placeholder behavior
            txtSeatName.Enter += (s, e) =>
            {
                if (txtSeatName.Text == "Ví dụ: Q01, VIP01")
                {
                    txtSeatName.Text = "";
                    txtSeatName.ForeColor = Color.Black;
                }
            };
            txtSeatName.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSeatName.Text))
                {
                    txtSeatName.Text = "Ví dụ: Q01, VIP01";
                    txtSeatName.ForeColor = Color.Gray;
                }
            };

            lblSeatNameHint = new Label
            {
                Text = "Tên ghế phải duy nhất trong phòng (A-Z + số)",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(32, 162),
                AutoSize = true
            };
            this.Controls.Add(lblSeatNameHint);

            // ========== LOẠI GHẾ ==========
            lblSeatType = new Label
            {
                Text = "Loại Ghế",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(30, 195),
                AutoSize = true
            };
            this.Controls.Add(lblSeatType);

            cboSeatType = new ComboBox
            {
                Font = new Font("Segoe UI", 12F),
                Location = new Point(30, 220),
                Size = new Size(500, 34),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboSeatType.Items.AddRange(new object[] { "Ghế Thường", "Ghế VIP" });
            cboSeatType.SelectedIndex = 0;
            this.Controls.Add(cboSeatType);

            // ========== BUTTONS ==========
            btnAdd = new Button
            {
                Text = "Thêm Ghế",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(240, 50),
                Location = new Point(30, 290),
                Cursor = Cursors.Hand
            };
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            btnCancel = new Button
            {
                Text = "Hủy",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(240, 50),
                Location = new Point(290, 290),
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            this.Controls.Add(btnCancel);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string seatName = txtSeatName.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(seatName) || seatName == "Ví dụ: Q01, VIP01")
            {
                MessageBox.Show("Vui lòng nhập tên ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSeatName.Focus();
                return;
            }

            // Map từ text hiển thị sang giá trị database
            string selectedType = cboSeatType.SelectedItem.ToString();
            string seatType = selectedType == "Ghế VIP" ? "Ghế VIP" : "Ghế thường";

            NewSeat = new Seat
            {
                SeatName = seatName,
                SeatType = seatType,
                RoomID = _roomId,
                IsDeleted = false,
                pX = -1, // Sẽ được tính trong UC
                pY = -1
            };

            this.DialogResult = DialogResult.OK;
        }
    }
}