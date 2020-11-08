using ShopBridge.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllProduct();
        public Task<Product> GetProduct(Guid id);
        public Task<Product> UpdateProduct(Product product);
        public Task<Product> CreateProduct(Product product);
        public Task<Product> DeleteProduct(Product product);

    }
}
