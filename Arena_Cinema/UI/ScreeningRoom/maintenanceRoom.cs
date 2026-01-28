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
using DTO;
using UI.SeatManagement;

namespace UI.ScreeningRoom
{
    public partial class maintenanceRoom : UserControl
    {
        private DTO.Room _room;
        private Home _home;
        private RoomBLL _roomBLL = new RoomBLL();

        public maintenanceRoom(Home home, DTO.Room room)
        {
            this._home = home;
            this._room = room;
            InitializeComponent();

            cardRoomSample.Visible = false;
            panelRoomsList.AutoScroll = true;

            LoadMaintenanceRooms();
        }

        private void LoadMaintenanceRooms()
        {
            panelRoomsList.Controls.Clear();
            _roomBLL = new RoomBLL();
            var allRooms = _roomBLL.GetAllRooms();
            var maintenanceRooms = allRooms.Where(r => r.statement == "Bảo trì").ToList();

            if (!maintenanceRooms.Any())
            {
                var lblEmpty = new Label
                {
                    Text = "Không có phòng nào đang bảo trì",
                    Font = new Font("Segoe UI", 14F, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Padding = new Padding(20)
                };
                panelRoomsList.Controls.Add(lblEmpty);
                return;
            }

            foreach (var room in maintenanceRooms)
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
                ForeColor = btn.ForeColor,
                Icon = btn.Icon
            };

            return new Control { Location = ctrl.Location, Size = ctrl.Size };
        }

        private void FillCard(ReaLTaiizor.Controls.MaterialCard card, Room room)
        {
            var p = (Panel)card.Controls[0];
            var pic = (PictureBox)p.Controls["ptbRoomImage"];

            if (!string.IsNullOrEmpty(room.ImageUrl))
            {
                try
                {
                    string fullPath = Path.Combine(Application.StartupPath, room.ImageUrl);

                    if (File.Exists(fullPath))
                    {
                        if (pic.Image != null && pic.Image != Properties.Resources.roomDefault)
                        {
                            pic.Image.Dispose();
                        }

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
            ((Label)p.Controls["lblRoomID"]).Text = $"ID: {room.RoomID}";
            ((Label)p.Controls["lblEmployeeName"]).Text = room.RoomName;
            ((Label)p.Controls["lblRoomType"]).Text = room.RoomType ?? "Standard";
            ((Label)p.Controls["lblSeatcount"]).Text = $"{room.SeatCount ?? 0} ghế";
            ((Label)p.Controls["lblDescription"]).Text = room.Description ?? "Không có mô tả";
            var btnKhoiPhuc = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnBaoTri"];
            btnKhoiPhuc.Tag = room.RoomID;
            btnKhoiPhuc.Text = "Khôi phục";
            btnKhoiPhuc.BackColor = Color.Green;
            btnKhoiPhuc.Click -= BtnKhoiPhuc_Click;
            btnKhoiPhuc.Click += BtnKhoiPhuc_Click;
            var btnXepGhe = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnXepGhe"];
            btnXepGhe.Tag = room.RoomID;
            btnXepGhe.Text = "Sắp xếp ghế";
            btnXepGhe.BackColor = Color.FromArgb(33, 150, 243);
            btnXepGhe.Click -= BtnXepGhe_Click;
            btnXepGhe.Click += BtnXepGhe_Click;
        }

        private void BtnKhoiPhuc_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;

            var roomBLL = new RoomBLL();
            var room = roomBLL.GetRoomById(roomId);

            if (room == null)
            {
                MessageBox.Show("Không tìm thấy phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = $"Khôi phục phòng '{room.RoomName}' về trạng thái hoạt động?";

            if (MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string result = roomBLL.SetRoomNormal(roomId);

                if (result.Contains("thành công"))
                {
                    MessageBox.Show(result, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMaintenanceRooms(); // Refresh danh sách
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnXepGhe_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;
            _home.LoadControl(new SeatManagementUC(_home, roomId));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new Room_homeUC(_home, _room));
        }

        public void RefreshData()
        {
            LoadMaintenanceRooms();
        }
    }
}