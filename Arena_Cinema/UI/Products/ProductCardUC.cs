using DTO;
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

namespace UI.Products
{
    public partial class ProductCardUC : UserControl
    {
        private Product _product;
        public event EventHandler<Product> OnEdit;
        public event EventHandler<Product> OnDelete;

        public ProductCardUC(Product product)
        {
            InitializeComponent();
            _product = product;
            LoadProductData();
        }

        private void LoadProductData()
        {
            lblId.Text = $"#{_product.ProductID}";
            lblName.Text = _product.ProductName;
            lblType.Text = _product.ProductType ?? "Chưa phân loại";
            lblPrice.Text = _product.Price.HasValue
                ? $"{_product.Price.Value:N0} VNĐ"
                : "Chưa có giá";

            // Load hình ảnh
            LoadProductImage();
        }

        private void LoadProductImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(_product.ImageUrl) && File.Exists(_product.ImageUrl))
                {
                    using (var stream = new FileStream(_product.ImageUrl, FileMode.Open, FileAccess.Read))
                    {
                        picProduct.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    // Hình ảnh mặc định nếu không có
                    picProduct.Image = CreateDefaultImage();
                }
            }
            catch
            {
                picProduct.Image = CreateDefaultImage();
            }
        }

        private Image CreateDefaultImage()
        {
            // Tạo hình ảnh mặc định
            Bitmap bmp = new Bitmap(80, 70);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(240, 240, 240));
                using (Font font = new Font("Segoe UI", 10))
                {
                    g.DrawString("No Image", font, Brushes.Gray, new PointF(10, 25));
                }
            }
            return bmp;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEdit?.Invoke(this, _product);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this, _product);
        }
    }
}
