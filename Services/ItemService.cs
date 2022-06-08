using Scycare.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace Scycare.Web.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpClient httpClient;    
        public ItemService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task DeleteAync(Guid Id)
        {
           await httpClient.DeleteAsync($"api/items/{Id}");           
        }

        public async Task<IEnumerable<ItemModel>> GetAllItemsAsync()
        {
            return await httpClient.GetJsonAsync<ItemModel[]>("api/Items");
        }

        public async Task<ItemModel> InsertItemAsync(ItemModel new_item)
        {
            return await httpClient.PostJsonAsync<ItemModel>("api/Items", new_item);
        }
    }
}
