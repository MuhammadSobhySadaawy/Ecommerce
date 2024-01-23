using Ecommerce.Api.DTO;
using Ecommerce.Api.Model;

namespace Ecommerce.Api.Reporsitories
{
    public interface IFavoriteProductService
    {
        List<FavoriteProductsDTO> GetAllByID(string UserId);
        void AddNew(User_ProductDTO  UserP);
        CheckFavoProd_ProdIdDTO checkProduct(User_ProductDTO UserP);
        int count(string Userid);

        void delete(int favoID);


    }
}
