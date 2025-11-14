using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        private readonly CinemaDBContext _context;
        public ProductDAL()
        {
            _context = new CinemaDBContext();
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách sản phẩm: {ex.Message}");
            }
        }

        // Lấy sản phẩm theo ID
        public Product GetProductById(int id)
        {
            try
            {
                return _context.Products.FirstOrDefault(p => p.ProductID == id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy sản phẩm: {ex.Message}");
            }
        }

        // Thêm sản phẩm mới
        public void AddProduct(Product product)
        {
            try
            {
                // Kiểm tra tên sản phẩm đã tồn tại chưa
                var existingProduct = _context.Products.FirstOrDefault(p =>
                    p.ProductName.ToLower() == product.ProductName.ToLower() && !p.IsDeleted);

                if (existingProduct != null)
                {
                    throw new Exception("Tên sản phẩm đã tồn tại!");
                }

                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }


        // Cập nhật sản phẩm
        public void UpdateProduct(Product product)
        {
            try
            {
                var existingProduct = _context.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
                if (existingProduct == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm!");
                }

                // Kiểm tra tên sản phẩm trùng (ngoại trừ chính nó)
                var duplicateProduct = _context.Products.FirstOrDefault(p =>
                    p.ProductName.ToLower() == product.ProductName.ToLower() &&
                    p.ProductID != product.ProductID &&
                    !p.IsDeleted);

                if (duplicateProduct != null)
                {
                    throw new Exception("Tên sản phẩm đã tồn tại!");
                }

                existingProduct.ProductName = product.ProductName;
                existingProduct.ProductType = product.ProductType;
                existingProduct.Price = product.Price;
                existingProduct.ImageUrl = product.ImageUrl;
                existingProduct.IsDeleted = product.IsDeleted;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
            }
        }

        // Xóa mềm sản phẩm (đánh dấu IsDeleted = true)
        public void DeleteProduct(int productId)
        {
            try
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductID == productId);
                if (product == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm!");
                }
                product.IsDeleted = true;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sản phẩm: {ex.Message}");
            }
        }

        // Tìm kiếm sản phẩm theo tên hoặc loại
        public List<Product> SearchProducts(string keyword)
        {
            try
            {
                keyword = keyword.ToLower();
                return _context.Products
                    .Where(p => !p.IsDeleted &&
                        (p.ProductName.ToLower().Contains(keyword) ||
                         p.ProductType.ToLower().Contains(keyword)))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm sản phẩm: {ex.Message}");
            }
        }

        // Lấy sản phẩm theo loại
        public List<Product> GetProductsByType(string type)
        {
            try
            {
                return _context.Products
                    .Where(p => !p.IsDeleted && p.ProductType == type)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy sản phẩm theo loại: {ex.Message}");
            }
        }


    }
}
