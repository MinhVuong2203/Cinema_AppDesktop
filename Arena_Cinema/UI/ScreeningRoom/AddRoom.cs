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

namespace UI.ScreeningRoom
{
    public partial class AddRoom : UserControl
    {
        private DTO.Room _room;
        private Home _home;
        private RoomBLL _roomBLL = new RoomBLL();
        private string _currentImagePath;

        public AddRoom(Home home, DTO.Room room)
        {
            InitializeComponent();
            this._room = room;
            this._home = home;
            _roomBLL = new RoomBLL();
            LoadDataToForm();
        }

        private void LoadDataToForm()
        {
            if (_room == null) _room = new Room();
            lblTitle.Text = _room.RoomID == 0 ? "Thêm phòng chiếu mới" : $"Sửa phòng - ID: {_room.RoomID}";

            txtRoomName.Text = _room.RoomName ?? "";
            txtSeatCount.Text = _room.SeatCount > 0 ? _room.SeatCount.ToString() : "";
            txtDescription.Text = _room.Description ?? "";
            if (cboRoomType.Items.Count == 0)
            {
                cboRoomType.Items.AddRange(new string[] { "2D", "3D", "IMAX", "VIP" });
            }

            if (!string.IsNullOrEmpty(_room.RoomType) && cboRoomType.Items.Contains(_room.RoomType))
            {
                cboRoomType.SelectedItem = _room.RoomType;
            }
            else
            {
                cboRoomType.SelectedIndex = 0; 
            }

            //Ảnh phòng
            if (!string.IsNullOrEmpty(_room.ImageUrl))
            {
                try
                {
                    ImgHelper.DisplayImageFromRelative(_room.ImageUrl, ptbRoomImage);
                    _currentImagePath = _room.ImageUrl;
                    return;
                }
                catch { }
            }

            ptbRoomImage.Image = Properties.Resources.roomDefault;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Chọn ảnh phòng chiếu";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbRoomImage.Image = Image.FromFile(ofd.FileName);

                    // Tạo đường dẫn lưu trong dự án
                    string fileName = Path.GetFileName(ofd.FileName);
                    string relativePath = Path.Combine("Image\\Room", fileName);

                    // Copy vào thư mục dự án
                    string fullPath = Path.Combine(Application.StartupPath, relativePath);
                    Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
                    File.Copy(ofd.FileName, fullPath, true);

                    _currentImagePath = relativePath; // Lưu đường dẫn tương đối
                }
            }
        }



        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên phòng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboRoomType.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập loại phòng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng tên phòng
            bool nameExists = _roomBLL.IsRoomNameExists(txtRoomName.Text.Trim(), _room.RoomID > 0 ? _room.RoomID : (int?)null);
            if (nameExists)
            {
                MessageBox.Show("Tên phòng đã tồn tại! Vui lòng chọn tên khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Số ghế (mặc định 250 nếu không nhập)
            int seatCount = 250;
            if (!string.IsNullOrWhiteSpace(txtSeatCount.Text))
            {
                if (!int.TryParse(txtSeatCount.Text.Trim(), out seatCount) || seatCount <= 0)
                {
                    MessageBox.Show("Số ghế phải là số dương!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Gán dữ liệu vào table room
            _room.RoomName = txtRoomName.Text.Trim();
            _room.RoomType = cboRoomType.Text.Trim();
            _room.SeatCount = seatCount;
            _room.Description = txtDescription.Text.Trim();
            _room.ImageUrl = _currentImagePath;

            string result;
            bool isNewRoom = _room.RoomID == 0;

            if (isNewRoom)
                result = _roomBLL.AddRoom(_room);
            else
                result = _roomBLL.UpdateRoom(_room);

            if (!result.Contains("thành công"))
            {
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (result.Contains("thành công") && isNewRoom && _room.RoomID > 0)
            {
                // Tạo ghế bất đồng bộ – KHÔNG block UI
                var seatBLL = new SeatBLL();
                try
                {
                    await Task.Run(() => seatBLL.CreateDefaultSeats(_room.RoomID, seatCount));
                    MessageBox.Show("Đã tạo ghế cho phòng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tạo ghế thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (result.Contains("thành công"))
            {
                _home.LoadControl(new Room_homeUC(_home, _room));
            }
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            var types = _roomBLL.GetAllRoomType();
            cboRoomType.Items.Clear();
            cboRoomType.Items.AddRange(types.ToArray());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new Room_homeUC(_home, _room));
        }

    }
}
