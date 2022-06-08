using Scycare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scycare.Web.Services
{
    public interface IItemService
    {
        Task<IEnumerable<ItemModel>> GetAllItemsAsync();
        Task<ItemModel> InsertItemAsync(ItemModel new_item);
        Task DeleteAync(Guid Id);
    }
}
