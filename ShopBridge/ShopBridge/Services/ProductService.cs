using Microsoft.AspNetCore.Components;
using ShopBridge.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public class ProductService : IProductService
    {

        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            return await httpClient.PostJsonAsync<Product>("api/product/AddProduct", product);
        }

        public async Task<Product> DeleteProduct(Product product)
        {
            return await httpClient.PostJsonAsync<Product>("api/product/DeleteProduct", product);
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await httpClient.GetJsonAsync<IEnumerable<Product>>("api/product/GetAllProduct");
        }

        public async Task<Product> GetProduct(Guid id)
        {
            return await httpClient.GetJsonAsync<Product>($"api/product/GetProduct/{id}");
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            return await httpClient.PostJsonAsync<Product>("api/product/UpdateProduct", product);
        }
    }
}
