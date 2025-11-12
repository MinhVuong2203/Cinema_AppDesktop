using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Common
{
    public static class ImgHelper
    {
        // Gốc thư mục ảnh (Image trong project)
        private static readonly string BaseImagePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\UI\Image");

        /// <summary>
        /// Mở hộp thoại chọn ảnh và lưu ảnh vào thư mục con tương ứng
        /// </summary>
        /// <param name="subFolder">Tên thư mục con (Employee, Product, Movie...)</param>
        /// <param name="pictureBox">PictureBox để hiển thị ảnh sau khi chọn</param>
        /// <returns>Đường dẫn tương đối (ví dụ: Image\Employee\abc.png)</returns>
        public static string UploadImage(string subFolder, PictureBox pictureBox)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn ảnh";
                    ofd.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = ofd.FileName;
                        string fileName = Path.GetFileName(selectedPath);

                        // Đường dẫn đích (VD: ...\UI\Image\Employee)
                        string targetFolder = Path.Combine(BaseImagePath, subFolder);
                        if (!Directory.Exists(targetFolder))
                            Directory.CreateDirectory(targetFolder);

                        // Tạo tên file duy nhất
                        string uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
                        string destPath = Path.Combine(targetFolder, uniqueFileName);

                        // Copy file ảnh vào thư mục
                        File.Copy(selectedPath, destPath, true);

                        // Hiển thị ảnh
                        DisplayImage(destPath, pictureBox);

                        // Trả về đường dẫn tương đối để lưu DB
                        string relativePath = Path.Combine("Image", subFolder, uniqueFileName);
                        return relativePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi upload ảnh: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// <summary>
        /// Hiển thị ảnh từ đường dẫn tuyệt đối
        /// </summary>
        public static void DisplayImage(string imagePath, PictureBox pictureBox)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    // Giải phóng ảnh cũ để tránh lỗi file đang được dùng
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                        pictureBox.Image = null;
                    }

                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox.Image = Image.FromStream(fs);
                    }

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
        /// Hiển thị ảnh từ đường dẫn tương đối (lấy từ DB)
        /// </summary>

        // Ví dụ đường dẫn tương đối: Image\Employee\abc.png
        public static void DisplayImageFromRelative(string relativePath, PictureBox pictureBox)
        {
            if (string.IsNullOrEmpty(relativePath)) return;

            string fullPath = Path.GetFullPath( // Nằm trong UI rồi
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", relativePath));
            DisplayImage(fullPath, pictureBox);
        }
    }
}
