using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        private DAL.ProductDAL _productDAL;

        public ProductBLL()
        {
            _productDAL = new DAL.ProductDAL();
        }

        public List<DTO.Product> GetAllProducts()
        {
            return _productDAL.GetAllProducts();
        }

        public DTO.Product GetProductById(int id)
        {
            try
            {
                return _productDAL.GetProductById(id);
            } 
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy sản phẩm: {ex.Message}");
            }
        }

        public void AddProduct(DTO.Product product)
        {
            try
            {
                _productDAL.AddProduct(product);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                _productDAL.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                _productDAL.DeleteProduct(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sản phẩm: {ex.Message}");

            }
        }

        public List<DTO.Product> SearchProducts(string keyword)
        {
            try
            {
                return _productDAL.SearchProducts(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm sản phẩm: {ex.Message}");
            }
        }

        public List<DTO.Product> GetProductsByType(string type)
        {
            try
            {
                return _productDAL.GetProductsByType(type);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lọc sản phẩm theo danh mục: {ex.Message}");
            }
        }

    }
}
