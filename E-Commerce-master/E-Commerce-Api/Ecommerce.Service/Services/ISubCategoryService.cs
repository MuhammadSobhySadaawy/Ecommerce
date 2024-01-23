using Ecommerce.Api.DTO;
using Ecommerce.Api.Dtos;
using Ecommerce.Api.Model;
namespace Ecommerce.Api.Services
{
    public interface ISubCategoryService
    {
        SubCatgoryDto GetSubCategoryById(int Id);
        IEnumerable<SubCategoryDTO> GetAllSubCategories();
        void AddNewSubCategory(SubCatgoryDto SubDTO);
        void UpdateSubCategory(int Id, SubCatgoryDto SubDTO);
        Task<bool> DeletSubCategory(int id);
    }
}
