using Microsoft.AspNetCore.Components;
using ShopBridge.DataModels.Models;
using ShopBridge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Pages
{
    public partial class ProductBase : ComponentBase
    {
        public IEnumerable<Product> productList { get; set; }
        [Inject]
        public IProductService productService { get; set; }

        [Inject] public NavigationManager navigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            productList = await productService.GetAllProduct();
        }
        public async void DeleteProduct(Product product)
        {
            var result = await productService.DeleteProduct(product);
            navigationManager.NavigateTo("/", true);
        }



    }
}
