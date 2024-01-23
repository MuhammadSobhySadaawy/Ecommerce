using Microsoft.AspNetCore.Http;

namespace Ecommerce.Api.Dtos

{
    public class ProductImagesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile? image { get; set; }
        public int ProductID { get; set; }
    }
}
