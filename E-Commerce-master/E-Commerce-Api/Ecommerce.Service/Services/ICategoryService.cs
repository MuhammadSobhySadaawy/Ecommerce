using Ecommerce.Api.Dtos;
using Ecommerce.Api.Model;
namespace Ecommerce.Api.Services
{
    public interface ICategoryService
    {
        CategoryDTO GetCategoryById(int Id);
        IEnumerable<CategoryDTO> GetAllCategories();
        bool DeletCategory(int id);
        void AddNewCategory(CategoryDTO CatDTO);
        void UpdateCategory(int Id, CategoryDTO CatDTO);
    }
}
