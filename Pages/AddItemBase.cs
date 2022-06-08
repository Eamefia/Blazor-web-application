using Microsoft.AspNetCore.Components;
using Scycare.Models;
using Scycare.Web.Services;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Scycare.Web.Pages
{
    public class AddItemBase : ComponentBase
    {
        [Inject]
        public IItemService ItemService { get; set; }
        public ItemModel Items { get; set; } = new ItemModel();

        [Inject]
        public NavigationManager NavigationManager { get; set; }
       

        public async void FormSubmitted()
        {
            Items.GrossAmount = GrossAmount;
            try
            {
                ItemModel new_item = new ItemModel
                {
                    Id = System.Guid.NewGuid(),
                    ItemName = Items.ItemName,
                    ItemCategory = Items.ItemCategory,
                    ItemQuantity = Items.ItemQuantity,
                    Unit = Items.Unit,
                    NetAmount = Items.NetAmount,
                    Tax = Items.Tax,
                    GrossAmount = Items.GrossAmount,
                    Discount = Items.Discount
                };
                await ItemService.InsertItemAsync(new_item);
                NavigationManager.NavigateTo("/add_all");



            }
            catch (Exception ex)
            {
                throw;
            }
        }

            public double GrossAmount
        {

            get
            {
                double gross_amount = 0;
                string tax = Items.Tax;
                string discount = Items.Discount;
                double tax_vat = 0.17;
                double tax_direct = 0.15;
                double discount_chris = 0.25;
                double discount_east = 0.18;
                double net_amount = 0;
                double calc_amount = 0;
                try
                {
                    if (tax == "VAT" && discount == "Chrismass")
                    {
                        net_amount = Convert.ToDouble(Items.NetAmount);
                        calc_amount = (net_amount) + (net_amount * Convert.ToDouble(tax_vat));
                        gross_amount = (calc_amount) - (calc_amount * Convert.ToDouble(discount_chris));
                    }
                    else if (tax == "VAT" && discount == "Fast sales")
                    {
                        net_amount = Convert.ToDouble(Items.NetAmount);
                        calc_amount = (net_amount) + (net_amount * Convert.ToDouble(tax_vat));
                        gross_amount = (calc_amount) - (calc_amount * Convert.ToDouble(discount_east));
                    }
                    else if (tax == "Direct Payment" && discount == "Fast sales")
                    {
                        net_amount = Convert.ToDouble(Items.NetAmount);
                        calc_amount = (net_amount) + (net_amount * Convert.ToDouble(tax_direct));
                        gross_amount = (calc_amount) - (calc_amount * Convert.ToDouble(discount_east));
                    }
                    else if (tax == "Direct Payment" && discount == "Chismass")
                    {
                        net_amount = Convert.ToDouble(Items.NetAmount);
                        calc_amount = (net_amount) + (net_amount * Convert.ToDouble(tax_direct));
                        gross_amount = (calc_amount) - (calc_amount * Convert.ToDouble(discount_chris));
                    }
                }
                catch (Exception)
                {
                    gross_amount = 0;
                }
                return gross_amount;

           
            }

        }

    }
}

