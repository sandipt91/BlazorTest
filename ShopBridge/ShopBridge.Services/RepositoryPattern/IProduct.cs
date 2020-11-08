using ShopBridge.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services.RepositoryPattern
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> ProductList();
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
        Task<Product> Product(Guid productId);
        Task<Product> DeleteProduct(Product product);

    }
}
