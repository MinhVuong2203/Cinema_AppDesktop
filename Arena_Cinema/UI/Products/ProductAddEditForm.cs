using BLL;
using Common;
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
                selectedImagePath = "Image\\Product\\productDefault.png";
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
                this.selectedImagePath = _product.ImageUrl;
                ImgHelper.DisplayImageFromRelative(_product.ImageUrl, picPreview);
            }

            private void btnChooseImage_Click(object sender, EventArgs e)
            {
                string selectedImagePath = ImgHelper.UploadImage("Product", picPreview);
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    this.selectedImagePath = selectedImagePath;
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
