using DTO;
using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;
using Common;

namespace UI.Movie
{
    public partial class EditMovieUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL movieBLL;
        private string selectedImagePath = "";
        private DTO.Movie _editingMovie;
        private bool isDataChanged = false;

        public EditMovieUC(Home home, DTO.Employee employee, DTO.Movie movieToEdit)
        {
            _home = home;
            _employee = employee;
            _editingMovie = movieToEdit;

            InitializeComponent();

            movieBLL = new MovieBLL();

            // Center group box
            grb_Movie.Left = (panelMain.Width - grb_Movie.Width) / 2;
            this.Resize += (s, e) => grb_Movie.Left = (panelMain.Width - grb_Movie.Width) / 2;

            // Setup events
            //btnSave.Click += BtnSave_Click;
            //btnCancel.Click += BtnCancel_Click;
            //btnUploadImage.Click += BtnUploadImage_Click;

            // Track changes
            SetupChangeTracking();

            // Load dữ liệu phim vào form
            LoadMovieData();
        }

        private void SetupChangeTracking()
        {
            // Track text changes
            txtMovieName.TextChanged += (s, e) => isDataChanged = true;
            txtDuration.TextChanged += (s, e) => isDataChanged = true;
            txtCategory.TextChanged += (s, e) => isDataChanged = true;
            txtDescription.TextChanged += (s, e) => isDataChanged = true;
            txtPreview.TextChanged += (s, e) => isDataChanged = true;
            txtTrailer.TextChanged += (s, e) => isDataChanged = true;

            // Track combobox changes
            cboLanguage.SelectedIndexChanged += (s, e) => isDataChanged = true;
            cboGenre.SelectedIndexChanged += (s, e) => isDataChanged = true;
            cbotype.SelectedIndexChanged += (s, e) => isDataChanged = true;

            // Track checkbox changes
            chkSubtitle.CheckedChanged += (s, e) => isDataChanged = true;

            // Track date changes
            dtpStartDate.ValueChanged += (s, e) => isDataChanged = true;
            dtpEndDate.ValueChanged += (s, e) => isDataChanged = true;
        }

        private void LoadMovieData()
        {
            try
            {
                if (_editingMovie == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin phim!", "✗ Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BackToMovieList();
                    return;
                }

                // Tạm dừng tracking changes
                isDataChanged = false;

                // Fill data vào các control
                txtMovieName.Text = _editingMovie.Title ?? "";
                txtDuration.Text = _editingMovie.DurationMinutes.ToString();
                txtCategory.Text = _editingMovie.Genre ?? ""; // Sử dụng Genre thay vì Sub
                txtDescription.Text = _editingMovie.Description ?? "";
                txtPreview.Text = _editingMovie.Preview ?? "";
                txtTrailer.Text = _editingMovie.LinkTrailer ?? "";
                chkSubtitle.Checked = _editingMovie.Dub ?? false;

                // Set date
                if (_editingMovie.StartTime.HasValue)
                    dtpStartDate.Value = _editingMovie.StartTime.Value;
                else
                    dtpStartDate.Value = DateTime.Today;

                if (_editingMovie.EndTime.HasValue)
                    dtpEndDate.Value = _editingMovie.EndTime.Value;
                else
                    dtpEndDate.Value = DateTime.Today.AddMonths(1);

                // Set combobox Language
                if (!string.IsNullOrEmpty(_editingMovie.Language))
                {
                    int langIndex = cboLanguage.FindStringExact(_editingMovie.Language);
                    if (langIndex >= 0)
                        cboLanguage.SelectedIndex = langIndex;
                    else if (cboLanguage.Items.Count > 0)
                        cboLanguage.SelectedIndex = 0;
                }
                else if (cboLanguage.Items.Count > 0)
                {
                    cboLanguage.SelectedIndex = 0;
                }

                // Set combobox Age Limit
                if (!string.IsNullOrEmpty(_editingMovie.AgeLimit))
                {
                    bool found = false;
                    for (int i = 0; i < cboGenre.Items.Count; i++)
                    {
                        string item = cboGenre.Items[i].ToString();
                        if (item.StartsWith(_editingMovie.AgeLimit))
                        {
                            cboGenre.SelectedIndex = i;
                            found = true;
                            break;
                        }
                    }

                    if (!found && cboGenre.Items.Count > 0)
                        cboGenre.SelectedIndex = 0;
                }
                else if (cboGenre.Items.Count > 0)
                {
                    cboGenre.SelectedIndex = 0;
                }

                // Set combobox Movie Type
                if (!string.IsNullOrEmpty(_editingMovie.MovieType))
                {
                    int typeIndex = cbotype.FindStringExact(_editingMovie.MovieType);
                    if (typeIndex >= 0)
                        cbotype.SelectedIndex = typeIndex;
                    else if (cbotype.Items.Count > 0)
                        cbotype.SelectedIndex = 0;
                }
                else if (cbotype.Items.Count > 0)
                {
                    cbotype.SelectedIndex = 0;
                }

                // Load image
                selectedImagePath = _editingMovie.ImageUrl ?? "";
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    ImgHelper.DisplayImageFromRelative(selectedImagePath, picImage);
                }
                else
                {
                    picImage.BackColor = Color.FromArgb(200, 200, 200);
                    picImage.Image = null;
                }

                // Reset tracking sau khi load xong
                isDataChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu phim: {ex.Message}", "✗ Lỗi",
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
                    isDataChanged = true;
                    MessageBox.Show("Tải ảnh thành công!", "✓ Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "✗ Lỗi",
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
                    $"Bạn có chắc muốn cập nhật thông tin phim '{txtMovieName.Text.Trim()}'?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                // Tạo object Movie với dữ liệu mới
                DTO.Movie movie = new DTO.Movie
                {
                    MovieID = _editingMovie.MovieID, // Giữ nguyên ID
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
                    IsDeleted = _editingMovie.IsDeleted // Giữ nguyên trạng thái xóa
                };

                // Gọi BLL để update phim
                var result = movieBLL.UpdateMovie(movie);

                if (result.Item1)
                {
                    isDataChanged = false; // Reset flag
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
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "✗ Lỗi",
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
            if (isDataChanged)
            {
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc muốn hủy? Các thay đổi sẽ không được lưu!",
                    "⚠ Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    BackToMovieList();
                }
            }
            else
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
                MessageBox.Show($"Lỗi khi quay lại danh sách: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isDataChanged)
            {
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc muốn quay lại? Các thay đổi sẽ không được lưu!",
                    "⚠ Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    BackToMovieList();
                }
            }
            else
            {
                BackToMovieList();
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}