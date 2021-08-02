using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Rest_api_dotnet.Entities;
using Rest_api_dotnet.Repositories;

namespace Rest_api_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController()
        {
            repository = new InMemItemsRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if (item is null)
            {
                NotFound();
            }

            return item;
        }
    }
}