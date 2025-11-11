using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Common
{
    public static class ImgHelper
    {
        // Gốc thư mục ảnh (bạn có thể chỉnh lại theo project của mình)
        private static readonly string BaseImagePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image");

        /// <summary>
        /// Mở hộp thoại chọn ảnh và lưu ảnh vào thư mục con tương ứng
        /// </summary>
        /// <param name="subFolder">Tên thư mục con (Employees, Products, Movies)</param>
        /// <param name="pictureBox">PictureBox để hiển thị ảnh sau khi chọn</param>
        /// <returns>Đường dẫn tương đối của ảnh được lưu (ví dụ: Image\Employees\abc.jpg)</returns>
        public static string UploadImage(string subFolder, PictureBox pictureBox)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn ảnh";
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = ofd.FileName;
                        string fileName = Path.GetFileName(selectedPath);

                        // Đường dẫn lưu vào thư mục tương ứng
                        string targetFolder = Path.Combine(BaseImagePath, subFolder);
                        if (!Directory.Exists(targetFolder))
                            Directory.CreateDirectory(targetFolder);

                        // Tạo tên file duy nhất tránh trùng
                        string uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
                        string destPath = Path.Combine(targetFolder, uniqueFileName);

                        // Copy file vào thư mục
                        File.Copy(selectedPath, destPath, true);

                        // Hiển thị ảnh lên PictureBox
                        DisplayImage(destPath, pictureBox);

                        // Trả về đường dẫn tương đối (để lưu DB)
                        string relativePath = Path.Combine("Image", subFolder, uniqueFileName);
                        return relativePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi upload ảnh: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// <summary>
        /// Hiển thị ảnh vào PictureBox từ đường dẫn
        /// </summary>
        public static void DisplayImage(string imagePath, PictureBox pictureBox)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    // Giải phóng ảnh cũ trước khi gán ảnh mới (tránh lỗi “file in use”)
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                        pictureBox.Image = null;
                    }

                    pictureBox.Image = System.Drawing.Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh: " + ex.Message);
            }
        }

        /// <summary>
        /// Hiển thị ảnh khi có đường dẫn tương đối (ví dụ lấy từ database)
        /// </summary>
        public static void DisplayImageFromRelative(string relativePath, PictureBox pictureBox)
        {
            if (string.IsNullOrEmpty(relativePath)) return;

            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            DisplayImage(fullPath, pictureBox);
        }
    }
}
