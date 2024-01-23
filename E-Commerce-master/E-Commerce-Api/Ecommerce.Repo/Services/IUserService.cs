using Ecommerce.Api.DTO;
using Ecommerce.Api.Model;

namespace Ecommerce.Api.Services
{
    public interface IUserService
    {
        string GetUserNameByID(string Id);
        string GetUserPhotoByID(string Id);
        List<SellerDTO> GetAllSeller();
        IEnumerable<ApplicationUser> GetAllUser();
        Task<ApplicationUser> GetUser(string userId);
    }
}
