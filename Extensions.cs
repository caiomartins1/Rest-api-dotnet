using Rest_api_dotnet.DTOs;
using Rest_api_dotnet.Entities;

namespace Rest_api_dotnet
{
    public static class Extensions
    {
        public static ItemDTO AsDTO(this Item item)
        {
            return new ItemDTO
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedAt = item.CreatedAt
            };
        }
    }
}