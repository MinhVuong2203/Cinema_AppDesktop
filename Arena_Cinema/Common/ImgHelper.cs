using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Common
{
    public static class ImgHelper
    {
        private static readonly string BaseImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Image");

        // Chức năng: Upload ảnh từ file hệ thống vào PictureBox và lưu vào thư mục con tương ứng
        // Cách dùng:
        // string pathImg = ImgHelper.UploadImage("Employee", this.picImage);
        // Ghi chú: Employee là tên thư mục con trong Image, this.picImage là PictureBox hiển thị ảnh hiện thời, hàm này sẽ trả về đường dẫn tương đối (vd: Image\Employee\abc.png)
        // Ta hứng chuỗi lại string pathImg để lưu cái đó xuống DB
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


        // Chức năng: Hiển thị ảnh từ đường dẫn tương đối (ví dụ hiển thị ảnh từ DB với giá trị là Image\Employee\xyz.png) vào PictureBox
        // Cách dùng:
        // ImgHelper.DisplayImageFromRelative(employee.ImageUrl, this.picImage);
        // Ghi chú: employee.ImageUrl là đường dẫn tương đối lấy từ DB, this.picImage là PictureBox hiển thị ảnh
        public static void DisplayImageFromRelative(string relativePath, PictureBox pictureBox)
        {
            if (string.IsNullOrEmpty(relativePath)) return;
            string fullPath = Path.GetFullPath( // Nằm trong UI rồi
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", relativePath));
            DisplayImage(fullPath, pictureBox);
        }
       
        // Hàm này để 2 hàm trên gọi ra thôi
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
    }
}
