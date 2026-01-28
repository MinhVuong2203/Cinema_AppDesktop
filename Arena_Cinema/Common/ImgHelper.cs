using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Common
{
    public static class ImgHelper
    {
        // 1) Ảnh upload (luôn đúng mọi môi trường)
        private static readonly string UserImageRoot =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                         "Arena_Cinema", "Image");

        // 2) Ảnh đi kèm app khi deploy (bạn phải đóng gói folder Image cạnh exe)
        private static readonly string AppImageRoot =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image");

        // 3) Ảnh trong môi trường dev (UI\Image nằm cạnh source)
        // BaseDirectory: ...\UI\bin\Debug\
        // ..\..\  => ...\UI\
        private static readonly string DevProjectImageRoot =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Image"));

        public static string UploadImage(string subFolder, PictureBox pictureBox)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn ảnh";
                    ofd.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.webp";

                    if (ofd.ShowDialog() != DialogResult.OK) return null;

                    if (string.IsNullOrWhiteSpace(subFolder))
                        subFolder = "Misc";

                    string selectedPath = ofd.FileName;
                    string ext = Path.GetExtension(selectedPath);

                    if (!IsAllowedImageExt(ext))
                    {
                        MessageBox.Show("Định dạng ảnh không hợp lệ!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }

                    string targetFolder = Path.Combine(UserImageRoot, subFolder);
                    Directory.CreateDirectory(targetFolder);

                    string uniqueFileName = $"{Guid.NewGuid():N}{ext}";
                    string destPath = Path.Combine(targetFolder, uniqueFileName);

                    File.Copy(selectedPath, destPath, true);

                    DisplayImage(destPath, pictureBox);

                    // Lưu DB dạng relative
                    return Path.Combine("Image", subFolder, uniqueFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi upload ảnh: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void DisplayImageFromRelative(string relativePath, PictureBox pictureBox)
        {
            if (pictureBox == null) return;

            if (string.IsNullOrWhiteSpace(relativePath))
            {
                ClearImage(pictureBox);
                return;
            }

            relativePath = NormalizeRelativePath(relativePath);

            // (A) Ưu tiên ảnh upload ở AppData
            string userFull = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Arena_Cinema",
                relativePath);

            if (File.Exists(userFull))
            {
                DisplayImage(userFull, pictureBox);
                return;
            }

            // (B) Ảnh đi kèm app khi deploy: <BaseDir>\Image\...
            string appFull = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            if (File.Exists(appFull))
            {
                DisplayImage(appFull, pictureBox);
                return;
            }

            // (C) Fallback dev: UI\Image\...
            // Nếu DB lưu "Image\Employee\abc.png" => full = DevProjectImageRoot\Employee\abc.png
            // nên ta bỏ prefix "Image\" trước khi combine
            string relNoPrefix = RemoveLeadingImageFolder(relativePath);
            string devFull = Path.Combine(DevProjectImageRoot, relNoPrefix);

            if (File.Exists(devFull))
            {
                DisplayImage(devFull, pictureBox);
                return;
            }

            ClearImage(pictureBox);
        }

        public static void DisplayImage(string imagePath, PictureBox pictureBox)
        {
            try
            {
                if (pictureBox == null) return;

                if (!File.Exists(imagePath))
                {
                    ClearImage(pictureBox);
                    return;
                }

                ClearImage(pictureBox);

                using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var img = Image.FromStream(fs))
                {
                    pictureBox.Image = new Bitmap(img);
                }

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearImage(pictureBox);
            }
        }

        private static void ClearImage(PictureBox pictureBox)
        {
            if (pictureBox?.Image == null) return;
            try
            {
                var old = pictureBox.Image;
                pictureBox.Image = null;
                old.Dispose();
            }
            catch { }
        }

        private static bool IsAllowedImageExt(string ext)
        {
            if (string.IsNullOrWhiteSpace(ext)) return false;
            ext = ext.Trim().ToLowerInvariant();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" ||
                   ext == ".bmp" || ext == ".gif" || ext == ".webp";
        }

        private static string NormalizeRelativePath(string relativePath)
        {
            relativePath = relativePath.Trim();
            relativePath = relativePath.TrimStart('\\', '/');
            return relativePath.Replace('/', '\\');
        }

        private static string RemoveLeadingImageFolder(string relativePath)
        {
            // "Image\Employee\a.png" -> "Employee\a.png"
            if (relativePath.StartsWith("Image\\", StringComparison.OrdinalIgnoreCase))
                return relativePath.Substring("Image\\".Length);
            if (string.Equals(relativePath, "Image", StringComparison.OrdinalIgnoreCase))
                return string.Empty;
            return relativePath;
        }
    }
}
