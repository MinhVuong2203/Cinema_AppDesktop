using System;
using System.Drawing;
using System.Windows.Forms;
using DTO;

namespace UI.SeatManagement
{
    public partial class EditSeatForm : Form
    {
        public Seat EditedSeat { get; private set; }
        public bool IsDelete { get; private set; }
        private Seat _originalSeat;

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private Panel pnlSeatInfo;
        private Label lblSeatDisplay;
        private Label lblSeatId;
        private Label lblSeatName;
        private TextBox txtSeatName;
        private Label lblSeatNameHint;
        private Label lblSeatType;
        private ComboBox cboSeatType;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;

        public EditSeatForm(Seat seat)
        {
            _originalSeat = seat;
            InitializeComponent();
            InitializeControls();
            LoadSeatData();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ClientSize = new Size(560, 500);
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
                Text = "Chỉnh Sửa Ghế",
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

            // ========== SEAT INFO PANEL ==========
            pnlSeatInfo = new Panel
            {
                BackColor = Color.FromArgb(248, 249, 250),
                Location = new Point(30, 100),
                Size = new Size(500, 80),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlSeatInfo);

            lblSeatDisplay = new Label
            {
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 102, 204),
                Location = new Point(15, 15),
                Size = new Size(470, 35),
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlSeatInfo.Controls.Add(lblSeatDisplay);

            lblSeatId = new Label
            {
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(15, 50),
                Size = new Size(470, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlSeatInfo.Controls.Add(lblSeatId);

            // ========== TÊN GHẾ ==========
            lblSeatName = new Label
            {
                Text = "Tên Ghế",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(30, 200),
                AutoSize = true
            };
            this.Controls.Add(lblSeatName);

            txtSeatName = new TextBox
            {
                Font = new Font("Segoe UI", 12F),
                Location = new Point(30, 225),
                Size = new Size(500, 34),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(txtSeatName);

            lblSeatNameHint = new Label
            {
                Text = "Tên ghế phải duy nhất trong phòng",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(32, 262),
                AutoSize = true
            };
            this.Controls.Add(lblSeatNameHint);

            // ========== LOẠI GHẾ ==========
            lblSeatType = new Label
            {
                Text = "Loại Ghế",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(30, 290),
                AutoSize = true
            };
            this.Controls.Add(lblSeatType);

            cboSeatType = new ComboBox
            {
                Font = new Font("Segoe UI", 12F),
                Location = new Point(30, 315),
                Size = new Size(500, 34),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboSeatType.Items.AddRange(new object[] { "Ghế Thường", "Ghế VIP" });
            this.Controls.Add(cboSeatType);

            // ========== BUTTONS ==========
            btnSave = new Button
            {
                Text = "Lưu Thay Đổi",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(500, 50),
                Location = new Point(30, 370),
                Cursor = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            btnDelete = new Button
            {
                Text = "Xóa Ghế",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(240, 50),
                Location = new Point(30, 430),
                Cursor = Cursors.Hand
            };
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            btnCancel = new Button
            {
                Text = "Hủy",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(240, 50),
                Location = new Point(290, 430),
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            this.Controls.Add(btnCancel);
        }

        private void LoadSeatData()
        {
            // Hiển thị tên ghế lớn
            lblSeatDisplay.Text = _originalSeat.SeatName;

            // Hiển thị ID
            lblSeatId.Text = $"ID: ST-{_originalSeat.SeatID.ToString().PadLeft(8, '0')}";

            // Load tên ghế vào textbox
            txtSeatName.Text = _originalSeat.SeatName;

            // Set loại ghế
            if (_originalSeat.SeatType == "Ghế VIP")
                cboSeatType.SelectedIndex = 1;
            else
                cboSeatType.SelectedIndex = 0; // Ghế Thường
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string seatName = txtSeatName.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(seatName))
            {
                MessageBox.Show("Vui lòng nhập tên ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSeatName.Focus();
                return;
            }

            // Map từ text hiển thị sang giá trị database
            string selectedType = cboSeatType.SelectedItem.ToString();
            string seatType = selectedType == "Ghế VIP" ? "Ghế VIP" : "Ghế thường";

            // Tạo seat đã chỉnh sửa
            EditedSeat = new Seat
            {
                SeatID = _originalSeat.SeatID,
                SeatName = seatName,
                SeatType = seatType,
                RoomID = _originalSeat.RoomID,
                IsDeleted = false,
                pX = _originalSeat.pX,
                pY = _originalSeat.pY
            };

            IsDelete = false;
            this.DialogResult = DialogResult.OK;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Bạn có chắc muốn xóa ghế {_originalSeat.SeatName}?\n\n" +
                $"Ghế sẽ bị xóa khỏi sơ đồ phòng.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                IsDelete = true;
                EditedSeat = _originalSeat;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}