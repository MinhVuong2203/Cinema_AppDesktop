using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Common;
using DAL;
using DTO;
using UI.Employee;

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

            var rooms = _roomBLL.GetAllRooms();

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

            // Ảnh
            var pic = (PictureBox)p.Controls["ptbRoomImage"];

            // ƯU TIÊN: Ảnh từ DB
            if (!string.IsNullOrEmpty(room.ImageUrl))
            {
                try
                {
                    ImgHelper.DisplayImageFromRelative(room.ImageUrl, pic);
                    return; // Thành công → thoát
                }
                catch { } // Lỗi → dùng mặc định
            }

            // DÙNG ẢNH NHÚNG TỪ RESOURCES
            pic.Image = Properties.Resources.roomDefault;

            // ID
            ((Label)p.Controls["lblRoomID"]).Text = $"ID: {room.RoomID}";

            // Tên phòng (dùng lại lblEmployeeName)
            ((Label)p.Controls["lblEmployeeName"]).Text = room.RoomName;

            // Loại phòng
            ((Label)p.Controls["lblRoomType"]).Text = room.RoomType ?? "Standard";

            // Số ghế
            ((Label)p.Controls["lblSeatcount"]).Text = $"{room.SeatCount ?? 0} ghế";

            // Mô tả
            ((Label)p.Controls["lblDescription"]).Text = room.Description ?? "Không có mô tả";

            // Nút Sửa
            var btnSua = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnSua"];
            btnSua.Tag = room.RoomID;
            btnSua.Click -= BtnEdit_Click;
            btnSua.Click += BtnEdit_Click;

            // Nút Xóa
            var btnXoa = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnXoa"];
            btnXoa.Tag = room.RoomID;
            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;
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

    }
}
