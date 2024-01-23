using Ecommerce.Api.DTO;
using Ecommerce.Api.Dtos;
using Ecommerce.Api.Model;

namespace Ecommerce.Api.Services
{
    public interface IProductService
    {
        ProductDetailsDTO GetProductByID(int Id);
        IEnumerable<ProductsGetALLDTO> GetAllProducts(string UserId);
        IEnumerable<ProductsGetALLDTO> GetAllProducts();
        void AddNewProduct(ProductDTO productDTO);
        bool RemoveProduct(int Id);
        void UpdateProduct(ProductDTO productDTO);
        IEnumerable<ProductDTO> GetTopAddedProducts();
        IEnumerable<AllProductsSellerDTO> GetProductsByUserId(string Id);
        bool EditActiveProduct(User_ProductDTO Data, int status);
        bool UpdateProductApprove(int prod, bool fapprove);
    }
}
