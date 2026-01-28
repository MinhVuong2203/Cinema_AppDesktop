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
using DTO;

namespace UI.ScreeningRoom
{
    

    public partial class Deleted_room : UserControl
    {
        private DTO.Room _room;
        private Home _home;
        private RoomBLL _roomBLL = new RoomBLL();
        public Deleted_room(Home home, DTO.Room room)
        {
            _home = home;
            InitializeComponent();

            cardRoomSample.Visible = false;
            panelRoomsList.AutoScroll = true;

            LoadDeletedRooms();
        }

        private void LoadDeletedRooms()
        {
            panelRoomsList.Controls.Clear();
            var deletedRooms = _roomBLL.GetDeletedRooms();

            if (!deletedRooms.Any())
            {
                Label lblEmpty = new Label
                {
                    Text = "Không có phòng nào trong thùng rác",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 14F),
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(20)
                };
                panelRoomsList.Controls.Add(lblEmpty);
                return;
            }

            foreach (var room in deletedRooms)
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
                BackColor = Color.FromArgb(255, 240, 240),
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
            string imgPath = string.IsNullOrEmpty(room.ImageUrl) ? "Image\\Room\\roomDefault.png" : room.ImageUrl;
            try { ImgHelper.DisplayImageFromRelative(imgPath, pic); }
            catch { pic.Image = Properties.Resources.roomDefault; }
            ((Label)p.Controls["lblRoomID"]).Text = $"ID: {room.RoomID} (đã xóa)";
            ((Label)p.Controls["lblEmployeeName"]).Text = room.RoomName;
            ((Label)p.Controls["lblRoomType"]).Text = room.RoomType ?? "Standard";
            ((Label)p.Controls["lblSeatcount"]).Text = $"{room.SeatCount ?? 0} ghế";
            ((Label)p.Controls["lblDescription"]).Text = room.Description ?? "Không có mô tả";
            var btnRestore = (ReaLTaiizor.Controls.MaterialButton)p.Controls["btnKhoiphuc"];
            btnRestore.Text = global::UI.Resources.Lang.KhoiPhuc;
            btnRestore.BackColor = Color.FromArgb(0, 192, 0); 
            btnRestore.ForeColor = Color.White;
            btnRestore.Tag = room.RoomID;
            btnRestore.Click -= BtnRestore_Click; 
            btnRestore.Click += BtnRestore_Click; 
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            int roomId = (int)((Control)sender).Tag;

            if (MessageBox.Show($"Khôi phục phòng ID {roomId}?", "Xác nhận khôi phục",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _roomBLL.RestoreRoom(roomId);
                MessageBox.Show(result);

                LoadDeletedRooms();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new Room_homeUC(_home, _room));
        }

    }
}
