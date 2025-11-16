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

        public Room_homeUC(Home form, Room room)
        {
            this._room = room;
            this._home = form;
            InitializeComponent();
            LoadcboRoomType();
            LoadCardRooms(_roomBLL.GetAllRooms());
        }

        public void LoadcboRoomType()
        {
            cboRoomType.Items.Clear();
            cboRoomType.Items.Add("Tất cả");
            RoomDAL roomDAL = new RoomDAL();
            var roomTypes = roomDAL.GetAllRoomType();
            foreach (var type in roomTypes)
            {
                cboRoomType.Items.Add(type);
            }
            cboRoomType.SelectedIndex = 0; // Chọn mục đầu tiên làm mặc định
        }

        private ReaLTaiizor.Controls.MaterialCard CloneCard(ReaLTaiizor.Controls.MaterialCard sample)
        {
            var card = new ReaLTaiizor.Controls.MaterialCard
            {
                Size = sample.Size,
                Margin = sample.Margin,
                BackColor = sample.BackColor,
                Padding = sample.Padding,
                Depth = sample.Depth
            };

            var panelContent = new Panel { Dock = DockStyle.Fill };

            foreach (Control c in sample.Controls[0].Controls)
            {
                Control clone = CloneControl(c);
                panelContent.Controls.Add(clone);
            }

            card.Controls.Add(panelContent);
            return card;
        }

        private Control CloneControl(Control original)
        {
            if (original is Label lbl) return new Label
            {
                Name = lbl.Name,
                Location = lbl.Location,
                Size = lbl.Size,
                Font = lbl.Font,
                ForeColor = lbl.ForeColor,
                BackColor = lbl.BackColor,
                TextAlign = lbl.TextAlign,
                AutoSize = lbl.AutoSize,
                Padding = lbl.Padding,
                MaximumSize = lbl.MaximumSize
            };

            if (original is PictureBox pic) return new PictureBox
            {
                Name = pic.Name,
                Location = pic.Location,
                Size = pic.Size,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = pic.BackColor,
                BorderStyle = pic.BorderStyle,
                TabStop = false
            };

            if (original is ReaLTaiizor.Controls.MaterialButton btn) return new ReaLTaiizor.Controls.MaterialButton
            {
                Name = btn.Name,
                Text = btn.Text,
                Location = btn.Location,
                Size = btn.Size,
                BackColor = btn.BackColor,
                ForeColor = btn.ForeColor,
                Icon = btn.Icon,
                Type = btn.Type,
                HighEmphasis = btn.HighEmphasis
            };

            return new Control { Location = original.Location, Size = original.Size };
        }

        public void LoadCardRooms(List<Room> rooms)
        {
            panelRoomsList.Controls.Clear();
            if (cardRoomSample.Visible == false)
                panelRoomsList.Controls.Add(cardRoomSample); // để clone

            foreach (var room in rooms)
            {
                // Bỏ qua phòng đã xóa
                if (room.IsDeleted) continue;

                // Clone card mẫu
                var card = CloneCard(cardRoomSample);
                var panelContent = (Panel)card.Controls[0];

                // === ẢNH PHÒNG ===
                var pic = (PictureBox)panelContent.Controls["pictureBoxEmployee"];
                string imgPath = string.IsNullOrEmpty(room.ImageUrl)
                    ? "Image\\Room\\roomDefault.png"
                    : room.ImageUrl;

                try
                {
                    ImgHelper.DisplayImageFromRelative(imgPath, pic);
                }
                catch
                {
                    ImgHelper.DisplayImageFromRelative("Image\\Room\\roomDefault.png", pic);
                }

                // === ID PHÒNG ===
                var lblId = (Label)panelContent.Controls["lblRoomID"];
                lblId.Text = $"ID: {room.RoomID}";

                // === TÊN PHÒNG ===
                var lblName = (Label)panelContent.Controls["lblEmployeeName"];
                lblName.Text = room.RoomName;
                lblName.MaximumSize = new Size(300, 0);

                // === LOẠI PHÒNG (dùng lại lblRole) ===
                var lblType = (Label)panelContent.Controls["lblRoomType"];
                lblType.Text = room.RoomType ?? "Standard";
                lblType.BackColor = Color.FromArgb(33, 150, 243);
                lblType.ForeColor = Color.White;
                lblType.Padding = new Padding(8, 3, 8, 3);

                // === SỐ GHẾ (dùng lại lblEmail) ===
                var lblSeats = (Label)panelContent.Controls["lblSeatcount"];
                lblSeats.Text = $"Số ghế: {room.SeatCount ?? 0}";

                // === MÔ TẢ (dùng lại lblPhone) ===
                var lblDesc = (Label)panelContent.Controls["lblDescription"];
                lblDesc.Text = room.Description ?? "Không có mô tả";
                lblDesc.MaximumSize = new Size(300, 0);

                // === NÚT SỬA ===
                var btnEdit = (ReaLTaiizor.Controls.MaterialButton)panelContent.Controls["btnSua"];
                btnEdit.Tag = room.RoomID;
                btnEdit.Click -= BtnEdit_Click;
                btnEdit.Click += BtnEdit_Click;

                // === NÚT XÓA ===
                var btnDelete = (ReaLTaiizor.Controls.MaterialButton)panelContent.Controls["btnXoa"];
                btnDelete.Tag = room.RoomID;
                //btnDelete.Click -= BtnDelete_Click;
                //btnDelete.Click += BtnDelete_Click;

                // Thêm card vào panel
                panelRoomsList.Controls.Add(card);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //ReaLTaiizor.Controls.MaterialButton btn = sender as ReaLTaiizor.Controls.MaterialButton;
            //if (btn != null && btn.Tag != null)
            //{
            //    Guid employeeId = (Guid)btn.Tag;
            //    // Xử lý sửa nhân viên với employeeId
            //    MessageBox.Show($"Sửa nhân viên ID: {employeeId}");

            //    // TODO: Mở form sửa nhân viên hoặc xử lý logic khác
            //}
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new AddRoom(_home, this._room));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
