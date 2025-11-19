using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using UI.ScreeningRoom;

namespace UI.SeatManagement
{
    public partial class SeatManagementUC : UserControl
    {
        private DTO.Room _room;
        private Home _home;
        private int _roomId;
        private SeatBLL _seatBLL = new SeatBLL();
        private List<Seat> _seats;
        private Button _draggingButton = null;
        private Point _dragOffset;

        private const int CELL_SIZE = 58;
        private const int OFFSET_Y = 80; 
        private const int OFFSET_X = 60;
        private const int SNAP_GRID = 58;

        private const int MAX_COLS = 17; 
        private int _maxRows = 20;

        public SeatManagementUC(Home home, int roomId)
        {
            _roomId = roomId;
            _home = home;
            InitializeComponent();

            pnlCanvas.AutoScroll = true;
            pnlCanvas.AutoScrollPosition = new Point(0, 0); // Reset về đầu trang
            pnlCanvas.MouseWheel += (s, e) => { ((HandledMouseEventArgs)e).Handled = true; };

            LoadSeatMap();
        }

        private void DrawGridLabels()
        {
            var oldLabels = pnlCanvas.Controls.OfType<Label>().ToList();
            foreach (var lbl in oldLabels) pnlCanvas.Controls.Remove(lbl);

            // Cột tên hàng (A, B, C...)
            for (int row = 0; row < _maxRows; row++)
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

            // tính sồ hàng tối đa của phòng
            if (_seats.Any())
            {
                _maxRows = _seats.Max(s => s.pY) + 1;
            }
            else
            {
                _maxRows = 1;
            }

            pnlCanvas.AutoScrollPosition = new Point(0, 0);

            pnlCanvas.Controls.Clear();
            DrawGridLabels();
            // Tạo button
            foreach (var seat in _seats)
            {
                var btn = CreateSeatButton(seat);
                pnlCanvas.Controls.Add(btn);
                btn.BringToFront();
            }

            // Set kích thước thực của panel ghế
            pnlCanvas.AutoScrollMinSize = new Size(
                MAX_COLS * SNAP_GRID + OFFSET_X + 60,
                _maxRows * SNAP_GRID + OFFSET_Y + 60
            );
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

            // Di chuyển ghế
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
                    // FIX: Tính toán vị trí chính xác với scroll
                    Point scrollPos = pnlCanvas.AutoScrollPosition;
                    int newX = btn.Left + e.X - _dragOffset.X;
                    int newY = btn.Top + e.Y - _dragOffset.Y;

                    // Giới hạn vùng kéo
                    newX = Math.Max(OFFSET_X + scrollPos.X, newX);
                    newY = Math.Max(OFFSET_Y + scrollPos.Y, newY);

                    // Giới hạn không vượt quá MAX_COLS và _maxRows
                    int maxX = (MAX_COLS - 1) * SNAP_GRID + OFFSET_X + scrollPos.X;
                    int maxY = (_maxRows - 1) * SNAP_GRID + OFFSET_Y + scrollPos.Y;

                    newX = Math.Min(maxX, newX);
                    newY = Math.Min(maxY, newY);

                    btn.Location = new Point(newX, newY);
                }
            };

            btn.MouseUp += (s, e) =>
            {
                if (_draggingButton == btn)
                {
                    // FIX: Tính toán chính xác với scroll position
                    Point scrollPos = pnlCanvas.AutoScrollPosition;

                    // Vị trí tuyệt đối (không bị ảnh hưởng bởi scroll)
                    int absoluteX = btn.Left - scrollPos.X;
                    int absoluteY = btn.Top - scrollPos.Y;

                    // BÁM LƯỚI khi thả
                    int gridX = (int)Math.Round((double)(absoluteX - OFFSET_X) / SNAP_GRID) * SNAP_GRID + OFFSET_X;
                    int gridY = (int)Math.Round((double)(absoluteY - OFFSET_Y) / SNAP_GRID) * SNAP_GRID + OFFSET_Y;

                    // Tính tọa độ logic (pX, pY)
                    int newPX = (gridX - OFFSET_X) / SNAP_GRID;
                    int newPY = (gridY - OFFSET_Y) / SNAP_GRID;

                    // Giới hạn không vượt quá MAX_COLS và _maxRows
                    newPX = Math.Max(0, Math.Min(MAX_COLS - 1, newPX));
                    newPY = Math.Max(0, Math.Min(_maxRows - 1, newPY));

                    var currentSeat = (Seat)btn.Tag;

                    if (currentSeat.pX != newPX || currentSeat.pY != newPY)
                    {
                        // Kiểm tra trùng vị trí - Xử lý đặc biệt cho ghế đôi
                        List<Seat> conflictSeats = new List<Seat>();

                        if (currentSeat.SeatType == "Ghế đôi")
                        {
                            // Ghế đôi chiếm 2 vị trí: (newPX, newPY) và (newPX+1, newPY)
                            var conflict1 = _seats.FirstOrDefault(st =>
                                st.SeatID != currentSeat.SeatID &&
                                st.pX == newPX &&
                                st.pY == newPY
                            );
                            var conflict2 = _seats.FirstOrDefault(st =>
                                st.SeatID != currentSeat.SeatID &&
                                st.pX == newPX + 1 &&
                                st.pY == newPY
                            );

                            if (conflict1 != null) conflictSeats.Add(conflict1);
                            if (conflict2 != null) conflictSeats.Add(conflict2);
                        }
                        else
                        {
                            // Ghế thường chỉ kiểm tra 1 vị trí
                            var conflict = _seats.FirstOrDefault(st =>
                                st.SeatID != currentSeat.SeatID &&
                                st.pX == newPX &&
                                st.pY == newPY
                            );
                            if (conflict != null) conflictSeats.Add(conflict);
                        }

                        if (conflictSeats.Any())
                        {
                            string colName = (newPX + 1).ToString();
                            string rowName = ((char)('A' + newPY)).ToString();

                            string conflictNames = string.Join(", ", conflictSeats.Select(st => st.SeatName));

                            MessageBox.Show(
                                $"Vị trí [{rowName}{colName}] đã có ghế: {conflictNames}\n" +
                                $"Vui lòng chọn vị trí khác!",
                                "Trùng vị trí",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            // Trả về vị trí cũ
                            btn.Location = new Point(
                                currentSeat.pX * SNAP_GRID + OFFSET_X + scrollPos.X,
                                currentSeat.pY * SNAP_GRID + OFFSET_Y + scrollPos.Y
                            );
                        }
                        else
                        {
                            string errorMsg;
                            bool saved = _seatBLL.UpdateSeatPosition(currentSeat.SeatID, newPX, newPY, _roomId, out errorMsg);

                            if (saved)
                            {
                                // ✅ RELOAD LẠI DỮ LIỆU ĐỂ LẤY TÊN MỚI TỪ TRIGGER
                                _seats = _seatBLL.GetSeatsByRoomId(_roomId);
                                LoadSeatMap();
                                var updatedSeat = _seatBLL.GetSeatByIdIncludeDeleted(currentSeat.SeatID);
                                if (updatedSeat != null)
                                {
                                    string colName = (newPX + 1).ToString();
                                    string rowName = ((char)('A' + newPY)).ToString();

                                    MessageBox.Show(
                                        $"✓ Đã lưu vị trí ghế\n" +
                                        $"Tên mới: {updatedSeat.SeatName}\n" +
                                        $"Vị trí: [{rowName}{colName}] → ({newPX}, {newPY})",
                                        "Thành công",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                                
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
                        // Snap lại vị trí nếu không di chuyển
                        btn.Location = new Point(
                            gridX + scrollPos.X,
                            gridY + scrollPos.Y
                        );
                    }

                    _draggingButton = null;
                }
            };

            return btn;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            var roomBLL = new RoomBLL();
            var room = roomBLL.GetRoomById(_roomId);
            _home.LoadControl(new Room_homeUC(_home, room));
        }
    }
}