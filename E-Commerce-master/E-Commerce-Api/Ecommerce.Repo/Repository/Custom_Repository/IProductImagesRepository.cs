using Ecommerce.Api.Model;

namespace Ecommerce.Api.Repository.Custom_Repository
{
    public interface IProductImagesRepository:IBaseRepository<ProductImages>
    {
        IEnumerable<ProductImages> GetImagesByProductId(int ProductId);
    }
}
