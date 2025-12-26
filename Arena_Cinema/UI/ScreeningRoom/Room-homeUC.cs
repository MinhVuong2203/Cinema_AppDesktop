using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Common;
using DAL;
using DTO;
using UI.Employee;
using UI.SeatManagement;

namespace UI.ScreeningRoom
{
    public partial class Room_homeUC : UserControl
    {
        private DTO.Room _room;
        private Home _home;
        private RoomBLL _roomBLL = new RoomBLL();

        private List<Room> _allRooms = new List<Room>();
        private string _filterType = "Tất cả"; // Lưu giá trị filter

        public Room_homeUC(Home form, Room room)
        {
            this._room = room;
            this._home = form;
            InitializeComponent();

            cardRoomSample.Visible = false;
            panelRoomsList.AutoScroll = true;

            LoadRoomTypes();
            LoadRoomsWithFilter();
        }

        private void LoadRoomTypes()
        {
            cboRoomType.Items.Clear();
            cboRoomType.Items.Add("Tất cả");
            cboRoomType.Items.AddRange(new[] { "2D", "3D", "IMAX", "VIP" });
            cboRoomType.SelectedIndex = 0;

            cboRoomType.SelectedIndexChanged += (s, e) =>
            {
                _filterType = cboRoomType.SelectedItem.ToString();
                LoadRoomsWithFilter();
            };
        }

        private void LoadRoomsWithFilter()
        {
            panelRoomsList.Controls.Clear();

            // Tạo instance mới để tránh cache
            _roomBLL = new RoomBLL();
            var rooms = _roomBLL.GetAllRooms();

            // Chỉ hiển thị phòng có trạng thái "Bình thường"
            rooms = rooms.Where(r => r.statement == "Bình thường").ToList();

            if (_filterType != "Tất cả")
                rooms = rooms.Where(r => r.RoomType == _filterType).ToList();

            foreach (var room in rooms)
            {
                var card = CloneCard(cardRoomSample);
                FillCard(card, room);
                panelRoomsList.Controls.Add(card);
            }
        }

        private ReaLTaiizor.Controls.MaterialCard CloneCard(ReaLTaiizor.Controls.MaterialCard sample)
        {
            var card = new ReaLTaiizor.Controls.MaterialCard
            {
                Size = sample.Size,
                Margin = sample.Margin,
                BackColor = sample.BackColor,
                Padding = sample.Padding
            };

            var content = new Panel { Dock = DockStyle.Fill };

            foreach (Control c in sample.Controls[0].Controls)
            {
                content.Controls.Add(CloneControl(c));
            }

            card.Controls.Add(content);
            return card;
        }

        private Control CloneControl(Control ctrl)
        {
            if (ctrl is Label lbl) return new Label
            {
                Name = lbl.Name,
                Location = lbl.Location,
                Size = lbl.Size,
                Font = lbl.Font,
                ForeColor = lbl.ForeColor,
                BackColor = lbl.BackColor,
                TextAlign = lbl.TextAlign,
                AutoSize = lbl.AutoSize,
                Padding = lbl.Padding
            };

            if (ctrl is PictureBox pic) return new PictureBox
            {
                Name = pic.Name,
                Location = pic.Location,
                Size = pic.Size,
                SizeMode = pic.SizeMode,
                BorderStyle = pic.BorderStyle
            };

            if (ctrl is ReaLTaiizor.Controls.MaterialButton btn) return new ReaLTaiizor.Controls.MaterialButton
            {
                Name = btn.Name,
                Text = btn.Text,
                Location = btn.Location,
                Size = btn.Size,
                BackColor = btn.BackColor,
                ForeColor = btn.ForeColor
            };

            return new Control { Location = ctrl.Location, Size = ctrl.Size };
        }

        private void FillCard(ReaLTaiizor.Controls.MaterialCard card, Room room)
        {
            var p = (Panel)card.Controls[0];

            // ===== ẢNH =====
            var pic = (PictureBox)p.Controls["ptbRoomImage"];

            if (!string.IsNullOrEmpty(room.ImageUrl))
            {
                try
                {
                    string fullPath = Path.Combine(Application.StartupPath, room.ImageUrl);

                    if (File.Exists(fullPath))
                    {
                        // Dispose ảnh cũ nếu có
                        if (pic.Image != null && pic.Image != Properties.Resources.roomDefault)
                        {
                            pic.Image.Dispose();
                        }

                        // Load ảnh mới
                        using (var img = Image.FromFile(fullPath))
                        {
                            pic.Image = new Bitmap(img);
                        }
                    }
                    else
                    {
                        pic.Image = Properties.Resources.roomDefault;
                    }
                }
                catch
                {
                    pic.Image = Properties.Resources.roomDefault;
                }
            }
            else
            {
                pic.Image = Properties.Resources.roomDefault;
            }

            // ===== CÁC LABEL KHÁC =====
            // ID
            ((Label)p.Controls["lblRoomID"]).Text = $"ID: {room.RoomID}";

            // Tên phòng
            ((Label)p.Controls["lblEmployeeName"]).Text = room.RoomName;

            // Loại phòng
            ((Label)p.Controls["lblRoomType"]).Text = room.RoomType ?? "Standard";

            // Số ghế
            ((Label)p.Controls["lblSeatcount"]).Text = $"{room.SeatCount ?? 0} ghế";

            // Mô tả
            ((Label)p.Controls["lblDescription"]).Text = room.Description ?? "Không có mô tả";

            // ===== NÚT SỬA =====
            var btnSua = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnSua"];
            btnSua.Tag = room.RoomID;
            btnSua.Click -= BtnEdit_Click;
            btnSua.Click += BtnEdit_Click;

            // ===== NÚT XÓA =====
            var btnXoa = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnXoa"];
            btnXoa.Tag = room.RoomID;
            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            // ===== NÚT BẢO TRÌ (THAY ĐỔI TỪ SEAT MANAGEMENT) =====
            var btnMaintenance = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnSeatManagement"];
            btnMaintenance.Tag = room.RoomID;

            // Thay đổi text và màu dựa trên trạng thái hiện tại
            if (room.statement == "Bảo trì")
            {
                btnMaintenance.Text = "Hoạt động";
                btnMaintenance.BackColor = Color.Green;
            }
            else
            {
                btnMaintenance.Text = "Bảo trì";
                btnMaintenance.BackColor = Color.Orange;
            }

            btnMaintenance.Click -= BtnMaintenance_Click;
            btnMaintenance.Click += BtnMaintenance_Click;
        }

        // ===== THAY ĐỔI METHOD NÀY: Từ SeatManagement sang Maintenance =====
        private void BtnMaintenance_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;

            // Tạo BLL mới để tránh cache
            var roomBLL = new RoomBLL();
            var room = roomBLL.GetRoomById(roomId);

            if (room == null)
            {
                MessageBox.Show("Không tìm thấy phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message, result;

            if (room.statement == "Bảo trì")
            {
                // Đang bảo trì -> Chuyển về hoạt động
                message = $"Chuyển phòng '{room.RoomName}' về trạng thái hoạt động?";
                if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    result = roomBLL.SetRoomNormal(roomId);

                    if (result.Contains("thành công"))
                    {
                        MessageBox.Show(result, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Force refresh bằng cách tạo lại control hoàn toàn
                        _home.LoadControl(new Room_homeUC(_home, _room));
                    }
                    else
                    {
                        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Đang hoạt động -> Chuyển sang bảo trì
                message = $"Chuyển phòng '{room.RoomName}' sang trạng thái bảo trì?\n\nPhòng sẽ không hiển thị trong danh sách chính.";
                if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    result = roomBLL.SetRoomMaintenance(roomId);

                    if (result.Contains("thành công"))
                    {
                        MessageBox.Show(result, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Force refresh bằng cách tạo lại control hoàn toàn
                        _home.LoadControl(new Room_homeUC(_home, _room));
                    }
                    else
                    {
                        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;
            var room = _roomBLL.GetRoomById(roomId);
            _home.LoadControl(new AddRoom(_home, room));
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new AddRoom(_home, this._room));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;

            if (MessageBox.Show("Xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string result = _roomBLL.DeleteRoom(roomId);
                MessageBox.Show(result);
                LoadRoomsWithFilter();
            }
        }

        public void RefreshData()
        {
            LoadRoomsWithFilter();
        }

        private void btnDeletedRoom_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new Deleted_room(_home, this._room));
        }

        private void btnSeatManagement_Click_1(object sender, EventArgs e)
        {
            // Method này có thể xóa hoặc giữ lại tùy design form của bạn
        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new maintenanceRoom(_home, this._room));
        }
    }
}