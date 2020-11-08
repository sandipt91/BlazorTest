using Microsoft.AspNetCore.Components;
using ShopBridge.DataModels.Models;
using ShopBridge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        public Product product { get; set; } = new Product();

        [Inject]
        public IProductService productService { get; set; }
        [Parameter]
        public string id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            product = await productService.GetProduct(System.Guid.Parse(id));

        }

    }
}
