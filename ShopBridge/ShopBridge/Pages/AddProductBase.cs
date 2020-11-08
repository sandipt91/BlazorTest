using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.DataModels.Models;
using ShopBridge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Pages
{
    public partial class AddProductBase : ComponentBase
    {
        public Product product { get; set; } = new Product();

        [Inject]
        public IProductService productService { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        public async void AddProcuct()
        {
            if (product != null)
            {
                var result = await productService.CreateProduct(product);
            }
            navigationManager.NavigateTo("/");
        }
    }
}
