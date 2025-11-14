using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI.Products
{
    public partial class ProductAddEditForm : Form
    {
            private Product _product;
            private ProductBLL productBLL;
            private string selectedImagePath;
            private bool isEditMode;

            public ProductAddEditForm()
            {
                InitializeComponent();
                productBLL = new ProductBLL();
                isEditMode = false;
                lblTitle.Text = "THÊM SẢN PHẨM MỚI";
            }

            public ProductAddEditForm(Product product) : this()
            {
                _product = product;
                isEditMode = true;
                lblTitle.Text = "CẬP NHẬT SẢN PHẨM";
                LoadProductData();
            }

            private void LoadProductData()
            {
                txtName.Text = _product.ProductName;

                if (!string.IsNullOrEmpty(_product.ProductType))
                {
                    int index = cboType.Items.IndexOf(_product.ProductType);
                    if (index >= 0)
                        cboType.SelectedIndex = index;
                }

                txtPrice.Text = _product.Price.HasValue ? _product.Price.Value.ToString() : "";
                selectedImagePath = _product.ImageUrl;

                // Load hình ảnh preview
                LoadImagePreview();
            }

            private void LoadImagePreview()
            {
                try
                {
                    if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        using (var stream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            picPreview.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        picPreview.Image = CreateDefaultPreviewImage();
                    }
                }
                catch
                {
                    picPreview.Image = CreateDefaultPreviewImage();
                }
            }

            private Image CreateDefaultPreviewImage()
            {
                Bitmap bmp = new Bitmap(200, 150);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.FromArgb(245, 245, 245));
                    using (Font font = new Font("Segoe UI", 12))
                    {
                        string text = "Chưa có hình ảnh";
                        SizeF textSize = g.MeasureString(text, font);
                        g.DrawString(text, font, Brushes.Gray,
                            (200 - textSize.Width) / 2,
                            (150 - textSize.Height) / 2);
                    }
                }
                return bmp;
            }

            private void btnChooseImage_Click(object sender, EventArgs e)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    LoadImagePreview();
                }
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                if (!ValidateInput())
                    return;

                try
                {
                    if (isEditMode)
                    {
                        UpdateProduct();
                    }
                    else
                    {
                        CreateProduct();
                    }

                    MessageBox.Show(
                        isEditMode ? "Cập nhật sản phẩm thành công!" : "Thêm sản phẩm thành công!",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private bool ValidateInput()
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return false;
                }

                if (cboType.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboType.Focus();
                    return false;
                }

                if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                    {
                        MessageBox.Show("Giá sản phẩm không hợp lệ!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrice.Focus();
                        return false;
                    }
                }

                return true;
            }

            private void CreateProduct()
            {
                var product = new Product
                {
                    ProductName = txtName.Text.Trim(),
                    ProductType = cboType.SelectedItem.ToString(),
                    Price = string.IsNullOrWhiteSpace(txtPrice.Text) ? (decimal?)null : decimal.Parse(txtPrice.Text),
                    ImageUrl = CopyImageToProductFolder(),
                    IsDeleted = false
                };

                productBLL.AddProduct(product);
            }

            private void UpdateProduct()
            {
                _product.ProductName = txtName.Text.Trim();
                _product.ProductType = cboType.SelectedItem.ToString();
                _product.Price = string.IsNullOrWhiteSpace(txtPrice.Text) ? (decimal?)null : decimal.Parse(txtPrice.Text);

                // Chỉ cập nhật hình ảnh nếu có chọn hình mới
                if (!string.IsNullOrEmpty(selectedImagePath) && selectedImagePath != _product.ImageUrl)
                {
                    _product.ImageUrl = CopyImageToProductFolder();
                }

                productBLL.UpdateProduct(_product);
            }

            private string CopyImageToProductFolder()
            {
                if (string.IsNullOrEmpty(selectedImagePath))
                    return null;

                try
                {
                    // Tạo thư mục Images/Products nếu chưa có
                    string productImagesFolder = Path.Combine(Application.StartupPath, "Images", "Products");
                    if (!Directory.Exists(productImagesFolder))
                    {
                        Directory.CreateDirectory(productImagesFolder);
                    }

                    // Tạo tên file duy nhất
                    string fileName = $"{Guid.NewGuid()}{Path.GetExtension(selectedImagePath)}";
                    string destinationPath = Path.Combine(productImagesFolder, fileName);

                    // Copy file
                    File.Copy(selectedImagePath, destinationPath, true);

                    return destinationPath;
                }
                catch
                {
                    return selectedImagePath; // Nếu lỗi thì giữ nguyên đường dẫn gốc
                }
            }
        
    }
}
