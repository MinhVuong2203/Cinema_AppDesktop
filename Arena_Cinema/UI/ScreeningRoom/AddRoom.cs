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
            
            LoadDataToForm();
        }

        private void LoadDataToForm()
        {
            // Tiêu đề
            lblTitle.Text = _room.RoomID == 0 ? "Thêm phòng chiếu mới" : $"Sửa phòng - ID: {_room.RoomID}";

            // Dữ liệu hiện tại (nếu là sửa)
            txtRoomName.Text = _room.RoomName ?? "";
            txtSeatCount.Text = _room.SeatCount > 0 ? _room.SeatCount.ToString() : "";
            if (cboRoomType.Items.Count == 0)
            {
                cboRoomType.Items.AddRange(new string[] { "2D", "3D", "IMAX", "VIP" });
            }

            // Nếu đang sửa → chọn loại hiện tại
            if (!string.IsNullOrEmpty(_room.RoomType) && cboRoomType.Items.Contains(_room.RoomType))
            {
                cboRoomType.SelectedItem = _room.RoomType;
            }
            else
            {
                cboRoomType.SelectedIndex = 0; // mặc định là 2D
            }

            // Ảnh phòng
            //if (!string.IsNullOrEmpty(_room.ImageUrl))
            //{
            //    try
            //    {
            //        ImgHelper.DisplayImageFromRelative(_room.ImageUrl, ptbRoomImage);
            //        _currentImagePath = _room.ImageUrl;
            //    }
            //    catch { ptbRoomImage.Image = Properties.Resources.roomDefault; }
            //}
            //else
            //{
            //    ptbRoomImage.Image = Properties.Resources.roomDefault;
            //}
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



        private void btnSave_Click(object sender, EventArgs e)
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

            // Kiểm tra trùng tên phòng (trừ chính nó khi sửa)
            bool nameExists = _roomBLL.IsRoomNameExists(txtRoomName.Text.Trim(), _room.RoomID > 0 ? _room.RoomID : (int?)null);
            if (nameExists)
            {
                MessageBox.Show("Tên phòng đã tồn tại! Vui lòng chọn tên khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Số ghế: nếu không nhập → mặc định 250
            int seatCount = 250;
            if (!string.IsNullOrWhiteSpace(txtSeatCount.Text))
            {
                if (!int.TryParse(txtSeatCount.Text.Trim(), out seatCount) || seatCount <= 0)
                {
                    MessageBox.Show("Số ghế phải là số dương!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Gán dữ liệu vào đối tượng Room
            _room.RoomName = txtRoomName.Text.Trim();
            _room.RoomType = cboRoomType.Text.Trim();
            _room.SeatCount = seatCount;
            _room.ImageUrl = _currentImagePath;

            string result;
            if (_room.RoomID == 0)
            {
                // Thêm mới
                result = _roomBLL.AddRoom(_room);
            }
            else
            {
                // Cập nhật
                result = _roomBLL.UpdateRoom(_room);
            }

            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK,
                result.Contains("thành công") ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.Contains("thành công"))
            {
                // Quay lại trang danh sách phòng và refresh
                _home.LoadControl(new Room_homeUC(_home, null)); // null hoặc employee nếu cần
            }
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            var types = _roomBLL.GetAllRoomType();
            cboRoomType.Items.Clear();
            cboRoomType.Items.AddRange(types.ToArray());
        }
    }
}
