using System;
using System.Collections.Generic;
using Rest_api_dotnet.Entities;

namespace Rest_api_dotnet.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}