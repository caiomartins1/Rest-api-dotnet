using Rest_api_dotnet.Dtos;
using Rest_api_dotnet.Entities;

namespace Rest_api_dotnet
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedAt = item.CreatedAt
            };
        }
    }
}