using Microsoft.AspNetCore.Components;
using Scycare.Models;
using Scycare.Web.Services;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Scycare.Web.Pages
{
    public class AddAllBase : ComponentBase
    {

        public Guid StoredId { get; set; }    
        [Inject]
        public IItemService ItemService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Boolean _showModal = false;

        protected Scycare.Web.Pages.ConfirmBase DeleteConfirmation { get; set; }    

        public IEnumerable<ItemModel> ItemModels = new List<ItemModel>();  
        protected override async Task OnInitializedAsync()
        {
            ItemModels = (await ItemService.GetAllItemsAsync()).ToList();    
        }

       

        protected async Task DeleteItem(Guid Id)
        {
            await ItemService.DeleteAync(Id);
            StateHasChanged();
        }

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await ItemService.DeleteAync(StoredId);
                ItemModels = (await ItemService.GetAllItemsAsync()).ToList();


            }
        }

        public void Stored( Guid Id)
        {
            StoredId = Id;
        }

        public void AddItemPage()
        {
            NavigationManager.NavigateTo("/item");
        }
    }
}
