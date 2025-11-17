using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace UI.SeatManagement
{
    public partial class SeatManagementUC : UserControl
    {
        private int _roomId;
        private SeatBLL _seatBLL = new SeatBLL();
        private List<Seat> _seats;
        private Button _draggingButton = null;
        private Point _dragOffset;

        private const int CELL_SIZE = 58;
        private const int OFFSET_Y = 120;
        private const int OFFSET_X = 60; // Thêm offset cho cột chữ cái
        private const int SNAP_GRID = 58;

        private const int MAX_COLS = 17; // Số cột tối đa
        private const int MAX_ROWS = 20; // Số hàng tối đa

        public SeatManagementUC(int roomId)
        {
            _roomId = roomId;
            InitializeComponent();

            pnlCanvas.AutoScroll = true;
            pnlCanvas.MouseWheel += (s, e) => { ((HandledMouseEventArgs)e).Handled = true; };

            DrawGridLabels(); // Vẽ lưới tọa độ
            LoadSeatMap();
        }

        private void DrawGridLabels()
        {
            // === VẼ HÀNG SỐ (1, 2, 3...) - TRÊN CÙNG ===
            for (int col = 0; col < MAX_COLS; col++)
            {
                var lblCol = new Label
                {
                    Text = (col + 1).ToString(),
                    Location = new Point(col * SNAP_GRID + OFFSET_X, OFFSET_Y - 40),
                    Size = new Size(SNAP_GRID, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(220, 53, 69)
                };
                pnlCanvas.Controls.Add(lblCol);
            }

            // === VẼ CỘT CHỮ CÁI (A, B, C...) - BÊN TRÁI ===
            for (int row = 0; row < MAX_ROWS; row++)
            {
                var lblRow = new Label
                {
                    Text = ((char)('A' + row)).ToString(),
                    Location = new Point(5, row * SNAP_GRID + OFFSET_Y),
                    Size = new Size(50, SNAP_GRID),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(220, 53, 69)
                };
                pnlCanvas.Controls.Add(lblRow);
            }
        }

        private void LoadSeatMap()
        {
            _seats = _seatBLL.GetSeatsByRoomId(_roomId);
            lblTitle.Text = $"SƠ ĐỒ GHẾ - PHÒNG {_roomId}";

            // Xóa ghế cũ (GIỮ LẠI label grid và picScreen, pnlLegend)
            var oldButtons = pnlCanvas.Controls.OfType<Button>().ToList();
            foreach (var b in oldButtons) pnlCanvas.Controls.Remove(b);

            foreach (var seat in _seats)
            {
                var btn = CreateSeatButton(seat);
                pnlCanvas.Controls.Add(btn);
                btn.BringToFront(); // Ghế hiện trên label
            }
        }

        private Button CreateSeatButton(Seat seat)
        {
            var btn = new Button
            {
                Width = seat.SeatType == "Ghế đôi" ? CELL_SIZE * 2 + 8 : CELL_SIZE,
                Height = CELL_SIZE,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                Text = seat.SeatType == "Ghế đôi" ? seat.SeatName + "\nCouple" : seat.SeatName,
                Tag = seat,
                Location = new Point(
                    seat.pX * SNAP_GRID + OFFSET_X,
                    seat.pY * SNAP_GRID + OFFSET_Y
                ),
                Cursor = Cursors.SizeAll
            };

            // Màu ghế
            switch (seat.SeatType)
            {
                case "Ghế đôi":
                    btn.BackColor = Color.FromArgb(255, 105, 180);
                    btn.ForeColor = Color.White;
                    break;
                case "Ghế VIP":
                    btn.BackColor = Color.Gold;
                    btn.ForeColor = Color.Black;
                    break;
                default:
                    btn.BackColor = Color.FromArgb(30, 144, 255);
                    btn.ForeColor = Color.White;
                    break;
            }

            // === SỰ KIỆN KÉO THẢ ===
            btn.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _draggingButton = btn;
                    _dragOffset = e.Location;
                    btn.BringToFront();
                }
            };

            btn.MouseMove += (s, e) =>
            {
                if (_draggingButton == btn && e.Button == MouseButtons.Left)
                {
                    int newX = btn.Left + e.X - _dragOffset.X;
                    int newY = btn.Top + e.Y - _dragOffset.Y;

                    newX += Math.Abs(pnlCanvas.AutoScrollPosition.X);
                    newY += Math.Abs(pnlCanvas.AutoScrollPosition.Y);

                    // Giới hạn vùng kéo
                    newX = Math.Max(OFFSET_X, newX);
                    newY = Math.Max(OFFSET_Y, newY);

                    // KÉO MƯỢT - không bám lưới khi đang kéo
                    btn.Location = new Point(
                        newX - Math.Abs(pnlCanvas.AutoScrollPosition.X),
                        newY - Math.Abs(pnlCanvas.AutoScrollPosition.Y)
                    );
                }
            };

            btn.MouseUp += (s, e) =>
            {
                if (_draggingButton == btn)
                {
                    int actualX = btn.Left + Math.Abs(pnlCanvas.AutoScrollPosition.X);
                    int actualY = btn.Top + Math.Abs(pnlCanvas.AutoScrollPosition.Y);

                    // BÁM LƯỚI khi thả
                    int gridX = (int)(Math.Round((double)(actualX - OFFSET_X) / SNAP_GRID) * SNAP_GRID) + OFFSET_X;
                    int gridY = (int)(Math.Round((double)(actualY - OFFSET_Y) / SNAP_GRID) * SNAP_GRID) + OFFSET_Y;

                    // Tính tọa độ logic (pX, pY)
                    int newPX = (gridX - OFFSET_X) / SNAP_GRID;
                    int newPY = (gridY - OFFSET_Y) / SNAP_GRID;

                    var currentSeat = (Seat)btn.Tag;

                    // === KIỂM TRA VA CHẠM VỚI GHẾ KHÁC ===
                    if (currentSeat.pX != newPX || currentSeat.pY != newPY)
                    {
                        // Kiểm tra có ghế nào ở vị trí (newPX, newPY) không
                        var conflictSeat = _seats.FirstOrDefault(st =>
                        st.SeatID != currentSeat.SeatID &&
                        st.pX == newPX &&
                        st.pY == newPY
                    );


                        if (conflictSeat != null)
                        {
                            // Tính tên hàng/cột để hiển thị
                            string colName = (newPX + 1).ToString();
                            string rowName = ((char)('A' + newPY)).ToString();

                            MessageBox.Show(
                                $"Vị trí [{rowName}{colName}] đã có ghế: {conflictSeat.SeatName}\n" +
                                $"Vui lòng chọn vị trí khác!",
                                "Trùng vị trí",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            // Trả ghế về vị trí cũ
                            btn.Location = new Point(
                                currentSeat.pX * SNAP_GRID + OFFSET_X - Math.Abs(pnlCanvas.AutoScrollPosition.X),
                                currentSeat.pY * SNAP_GRID + OFFSET_Y - Math.Abs(pnlCanvas.AutoScrollPosition.Y)
                            );
                        }
                        else
                        {
                            // Không trùng → Lưu vào DB
                            string errorMsg;
                            bool saved = _seatBLL.UpdateSeatPosition(currentSeat.SeatID, newPX, newPY, _roomId, out errorMsg);

                            if (saved)
                            {
                                string colName = (newPX + 1).ToString();
                                string rowName = ((char)('A' + newPY)).ToString();

                                MessageBox.Show(
                                    $"✓ Đã lưu vị trí ghế {currentSeat.SeatName}\n" +
                                    $"Vị trí mới: [{rowName}{colName}] → ({newPX}, {newPY})",
                                    "Thành công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                LoadSeatMap();
                            }
                            else
                            {
                                MessageBox.Show("Lưu thất bại: " + errorMsg, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                LoadSeatMap();
                            }
                        }
                    }
                    else
                    {
                        // Vị trí không đổi, chỉ bám lưới lại
                        btn.Location = new Point(
                            gridX - Math.Abs(pnlCanvas.AutoScrollPosition.X),
                            gridY - Math.Abs(pnlCanvas.AutoScrollPosition.Y)
                        );
                    }

                    _draggingButton = null;
                }
            };

            return btn;
        }
    }
}