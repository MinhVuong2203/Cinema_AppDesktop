using DTO;
using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;
using Common;

namespace UI.Movie
{
    public partial class AddMovieUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL movieBLL;
        private string selectedImagePath = "";

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
            try
            {
                // Set ngày mặc định
                dtpStartDate.Value = DateTime.Today;
                dtpEndDate.Value = DateTime.Today.AddMonths(1);

                // Set default cho combobox Language
                if (cboLanguage.Items.Count > 0)
                    cboLanguage.SelectedIndex = 0;

                // Set default cho combobox Genre (Age Limit)
                if (cboGenre.Items.Count > 0)
                    cboGenre.SelectedIndex = 0;

                // Set default cho combobox Movie Type
                if (cbotype.Items.Count > 0)
                    cbotype.SelectedIndex = 0;

                // Đặt placeholder image
                picImage.BackColor = Color.FromArgb(200, 200, 200);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
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
                if (!ValidateInput())
                    return;

                // Hiển thị xác nhận
                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc muốn thêm phim '{txtMovieName.Text.Trim()}'?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                // Tạo object Movie với tất cả các trường từ model
                DTO.Movie movie = new DTO.Movie
                {
                    Title = txtMovieName.Text.Trim(),
                    DurationMinutes = int.Parse(txtDuration.Text.Trim()),
                    Genre = txtCategory.Text.Trim(), // Thể loại phim
                    Language = cboLanguage.SelectedItem?.ToString() ?? "Tiếng Việt",
                    Sub = txtCategory.Text.Trim(), // Cũng là thể loại
                    Dub = chkSubtitle.Checked,
                    AgeLimit = GetAgeLimit(cboGenre.SelectedItem?.ToString()),
                    MovieType = cbotype.SelectedItem?.ToString() ?? "2D",
                    StartTime = dtpStartDate.Value,
                    EndTime = dtpEndDate.Value,
                    LinkTrailer = txtTrailer.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Preview = txtPreview.Text.Trim(),
                    ImageUrl = selectedImagePath,
                    IsDeleted = false
                };

                // Gọi BLL để thêm phim
                var result = movieBLL.AddMovie(movie);

                if (result.Item1)
                {
                    MessageBox.Show(result.Item2, "✓ Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BackToMovieList();
                }
                else
                {
                    MessageBox.Show(result.Item2, "✗ Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Thời lượng phim phải là số nguyên!", "Lỗi định dạng",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();
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
                MessageBox.Show("Vui lòng nhập tên phim!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMovieName.Focus();
                return false;
            }

            if (txtMovieName.Text.Trim().Length > 200)
            {
                MessageBox.Show("Tên phim không được vượt quá 200 ký tự!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMovieName.Focus();
                return false;
            }

            // Validate thời lượng
            if (string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                MessageBox.Show("Vui lòng nhập thời lượng phim!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuration.Focus();
                return false;
            }

            if (!int.TryParse(txtDuration.Text.Trim(), out int duration) || duration <= 0)
            {
                MessageBox.Show("Thời lượng phim phải là số nguyên dương!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuration.Focus();
                return false;
            }

            if (duration > 500)
            {
                MessageBox.Show("Thời lượng phim không hợp lệ (tối đa 500 phút)!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuration.Focus();
                return false;
            }

            // Validate thể loại
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập thể loại phim!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return false;
            }

            // Validate ngôn ngữ
            if (cboLanguage.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ngôn ngữ!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLanguage.Focus();
                return false;
            }

            // Validate giới hạn tuổi
            if (cboGenre.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới hạn độ tuổi!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGenre.Focus();
                return false;
            }

            // Validate loại phim
            if (cbotype.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phim!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbotype.Focus();
                return false;
            }

            // Validate ngày
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày khởi chiếu!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            if (dtpEndDate.Value < DateTime.Today.AddDays(-1))
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày hôm nay!", "⚠ Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            // Validate ngày khởi chiếu
            if (dtpStartDate.Value < DateTime.Today.AddDays(-1))
            {
                var result = MessageBox.Show(
                    "Ngày khởi chiếu đã qua. Bạn có muốn tiếp tục không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    dtpStartDate.Focus();
                    return false;
                }
            }

            // Validate ảnh
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
            var confirmResult = MessageBox.Show(
                "Bạn có chắc muốn hủy? Dữ liệu chưa lưu sẽ bị mất!",
                "⚠ Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                BackToMovieList();
            }
        }

        private void BackToMovieList()
        {
            try
            {
                Movie_MainUC movieMain = new Movie_MainUC(_home, _employee);
                _home.LoadControl(movieMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi quay lại danh sách: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Bạn có chắc muốn quay lại? Dữ liệu chưa lưu sẽ bị mất!",
                "⚠ Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                BackToMovieList();
            }
        }
    }
}