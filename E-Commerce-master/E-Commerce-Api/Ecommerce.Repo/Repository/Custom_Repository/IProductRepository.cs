using Ecommerce.Api.Model;

namespace Ecommerce.Api.Repository.Custom_Repository
{
    public interface IProductRepository:IBaseRepository<Product>
    {
        IEnumerable<Product> GetTopAdded();
        IEnumerable<Product> GetProductsByUserId(string UserId);
    }
}
