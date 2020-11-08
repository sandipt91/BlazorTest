using Microsoft.EntityFrameworkCore;
using ShopBridge.DataModels.Models;
using ShopBridge.Services.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services.RepositoryPattern
{
    public class ProductRepository : IProduct
    {
        private readonly ShopBridgeDbCOntext dbContext;
        public ProductRepository(ShopBridgeDbCOntext context)
        {
            this.dbContext = context;
        }

        public async Task<Product> Create(Product product)
        {
            product.ProductId = Guid.NewGuid();
            var result = await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> DeleteProduct(Product product)
        {
            var result = await dbContext.Products.FindAsync(product.ProductId);
            if (result != null)
            {
                dbContext.Products.Remove(result);
                await dbContext.SaveChangesAsync();
            }
            return result;
        }

        public async Task<Product> Product(Guid productId)
        {
            var result = await dbContext.Products.FindAsync(productId);
            return result;
        }

        public async Task<IEnumerable<Product>> ProductList()
        {
            return await dbContext.Products.ToListAsync();
        }

        public async Task<Product> Update(Product product)
        {
            var productData = await dbContext.Products.FindAsync(product.ProductId);
            productData.Name = product.Name;
            await dbContext.SaveChangesAsync();
            return productData;
        }
    }
}
