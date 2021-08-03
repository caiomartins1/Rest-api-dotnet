using System;

namespace Rest_api_dotnet.DTOs
{
    public record ItemDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}