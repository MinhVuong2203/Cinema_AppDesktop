using DTO;
using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;
using Common; // Thêm namespace Common

namespace UI.Movie
{
    public partial class AddMovieUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL movieBLL;
        private string selectedImagePath = ""; // Đường dẫn tương đối để lưu DB

        public AddMovieUC(Home home, DTO.Employee employee)
        {
            _home = home;
            _employee = employee;
            InitializeComponent();

            movieBLL = new MovieBLL();

            // Center group box
            grb_Movie.Left = (panelMain.Width - grb_Movie.Width) / 2;
            this.Resize += (s, e) => grb_Movie.Left = (panelMain.Width - grb_Movie.Width) / 2;

            // Setup events
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnUploadImage.Click += BtnUploadImage_Click;

            // Set default values
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // Set ngày mặc định
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddMonths(1);

            // Set default cho combobox
            if (cboLanguage.Items.Count > 0)
                cboLanguage.SelectedIndex = 0;

            if (cboGenre.Items.Count > 0)
                cboGenre.SelectedIndex = 0;
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng ImgHelper để upload và hiển thị ảnh
                // Trả về đường dẫn tương đối (VD: Image\Movie\abc.png)
                string relativePath = ImgHelper.UploadImage("Movie", picImage);

                if (!string.IsNullOrEmpty(relativePath))
                {
                    selectedImagePath = relativePath;
                    MessageBox.Show("Tải ảnh thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!ValidateInput())
                    return;

                // Tạo object Movie
                DTO.Movie movie = new DTO.Movie
                {
                    Title = txtMovieName.Text.Trim(),
                    DurationMinutes = int.Parse(txtDuration.Text.Trim()),
                    Genre = cboGenre.SelectedItem?.ToString(),
                    Language = cboLanguage.SelectedItem?.ToString(),
                    Sub = txtCategory.Text.Trim(),
                    Dub = chkSubtitle.Checked,
                    AgeLimit = GetAgeLimit(cboGenre.SelectedItem?.ToString()),
                    StartTime = dtpStartDate.Value,
                    EndTime = dtpEndDate.Value,
                    LinkTrailer = txtTrailer.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Preview = txtPreview.Text.Trim(),
                    ImageUrl = selectedImagePath, // Đường dẫn tương đối
                    IsDeleted = false
                };

                // Gọi BLL để thêm phim
                var result = movieBLL.AddMovie(movie);

                if (result.Item1) // Success
                {
                    MessageBox.Show(result.Item2, "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Quay về trang danh sách
                    BackToMovieList();
                }
                else // Failed
                {
                    MessageBox.Show(result.Item2, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Validate tên phim
            if (string.IsNullOrWhiteSpace(txtMovieName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phim!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMovieName.Focus();
                return false;
            }

            // Validate thời lượng
            if (string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                MessageBox.Show("Vui lòng nhập thời lượng phim!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuration.Focus();
                return false;
            }

            if (!int.TryParse(txtDuration.Text.Trim(), out int duration) || duration <= 0)
            {
                MessageBox.Show("Thời lượng phim phải là số nguyên dương!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuration.Focus();
                return false;
            }

            // Validate thể loại
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập thể loại phim!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return false;
            }

            // Validate ngôn ngữ
            if (cboLanguage.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ngôn ngữ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLanguage.Focus();
                return false;
            }

            // Validate giới hạn tuổi
            if (cboGenre.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới hạn độ tuổi!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGenre.Focus();
                return false;
            }

            // Validate ngày
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày khởi chiếu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            // Validate ảnh (không bắt buộc nhưng nên có cảnh báo)
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                var result = MessageBox.Show(
                    "Bạn chưa chọn ảnh poster. Bạn có muốn tiếp tục không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return false;
            }

            return true;
        }

        private string GetAgeLimit(string genreText)
        {
            if (string.IsNullOrEmpty(genreText))
                return "P";

            // Extract age limit từ text
            // VD: "P - Mọi lứa tuổi" -> "P"
            if (genreText.Contains("-"))
            {
                return genreText.Split('-')[0].Trim();
            }
            return genreText.Trim();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi hủy
            var confirmResult = MessageBox.Show(
                "Bạn có chắc muốn hủy? Dữ liệu chưa lưu sẽ bị mất!",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                BackToMovieList();
            }
        }

        private void BackToMovieList()
        {
            Movie_MainUC movieMain = new Movie_MainUC(_home, _employee);
            _home.LoadControl(movieMain);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToMovieList();
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
        }
    }
}