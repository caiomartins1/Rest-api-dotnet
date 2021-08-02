using System;
using System.Collections.Generic;
using System.Linq;
using Rest_api_dotnet.Entities;

namespace Rest_api_dotnet.Repositories
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "iPhone", Price = 895.99m, CreatedAt = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Galaxy s10", Price = 734.99m, CreatedAt = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Macbook Air 2019", Price = 999.99m, CreatedAt = DateTimeOffset.UtcNow },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
    }
}