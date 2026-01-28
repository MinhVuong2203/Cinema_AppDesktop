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
        public event EventHandler<Product> OnRestore;

        public ProductCardUC(Product product, bool isDelete)
        {
            InitializeComponent();
            if (isDelete)
            {
                btnEdit.Visible = false;
                btnNgungBan.Visible = false;
                btnKhoiPhuc.Visible = true;
            }
            else
            {
                btnEdit.Visible = true;
                btnNgungBan.Visible = true;
                btnKhoiPhuc.Visible = false;
            }
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
            lbSL.ForeColor =_product.QuaLimited <= 10 ? Color.Red :  Color.Black;
            lbSL.Text = _product.QuaLimited.ToString();

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

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            OnRestore?.Invoke(this, _product);
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

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
