using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Products
{
    public partial class ProductMainUC : UserControl
    {
        private Home home;
        private DTO.Employee employee;

        private List<Product> allProducts;
        private ProductBLL productBLL = new ProductBLL();
        public ProductMainUC(Home home, DTO.Employee employee)
        {
            this.employee = employee;
            this.home = home;
            InitializeComponent();
           
        }

        private void ProductMainUCcs_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                // Lấy tất cả sản phẩm chưa bị xóa
                allProducts = productBLL.GetAllProducts().Where(p => !p.IsDeleted).ToList();
                DisplayProducts(allProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayProducts(List<Product> products)
        {
            flowLayoutProducts.Controls.Clear();

            if (products == null || products.Count == 0)
            {
                var lblEmpty = new Label
                {
                    Text = "Không có sản phẩm nào",
                    Font = new Font("Segoe UI", 14F),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowLayoutProducts.Controls.Add(lblEmpty);
                return;
            }

            foreach (var product in products)
            {
                var productCard = new ProductCardUC(product);
                productCard.OnEdit += ProductCard_OnEdit;
                productCard.OnDelete += ProductCard_OnDelete;
                productCard.Width = flowLayoutProducts.Width - 60;
                flowLayoutProducts.Controls.Add(productCard);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (allProducts == null) return;

            string searchText = txtSearch.Text.Trim().ToLower();

            var filteredProducts = allProducts.Where(p =>
                p.ProductName.ToLower().Contains(searchText) ||
                (p.ProductType != null && p.ProductType.ToLower().Contains(searchText))
            ).ToList();

            DisplayProducts(filteredProducts);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new ProductAddEditForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void ProductCard_OnEdit(object sender, Product product)
        {
            var editForm = new ProductAddEditForm(product);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void ProductCard_OnDelete(object sender, Product product)
        {
            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn ngưng bán sản phẩm '{product.ProductName}'?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    product.IsDeleted = true;
                    productBLL.UpdateProduct(product);
                    MessageBox.Show("Đã ngưng bán sản phẩm thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi ngưng bán sản phẩm: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
