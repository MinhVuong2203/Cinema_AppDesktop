using Common;
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

            ImgHelper.DisplayImageFromRelative(_product.ImageUrl, picProduct);
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEdit?.Invoke(this, _product);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this, _product);
        }

        private void panelCard_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Width += 14;
        }

        private void panelCard_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.Width -= 14;
           
        }
    }
}
