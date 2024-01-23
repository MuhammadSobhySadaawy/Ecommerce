using Ecommerce.Api.DTO;
using Ecommerce.Api.Dtos;

namespace Ecommerce.Api.Services
{
    public interface IHomeService
    {

        public IEnumerable<ProductsGetALLDTO> GetAllProductsNew();

        public IEnumerable<ProductsGetALLDTO> GetAllPhones(string UserID);
        public IEnumerable<ProductsGetALLDTO> GetAllLabtops(string UserID);

        public IEnumerable<ProductsGetALLDTO> GetAllAccessories(string UserID);



        public IEnumerable<ProductsGetALLDTO> ByIdCateoryAllPoduct(int id, string UserID);

        public IEnumerable<SubCatgoryDto> GetAllSubCategoryByIdCaty(int id);
        public IEnumerable<ProductsGetALLDTO> GetAllProductByIdSubCategory(int id, string UserID);
    }
}
