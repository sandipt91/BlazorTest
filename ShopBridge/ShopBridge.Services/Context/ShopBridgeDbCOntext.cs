using Microsoft.EntityFrameworkCore;
using ShopBridge.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services.Context
{
    public class ShopBridgeDbCOntext : DbContext
    {
        public ShopBridgeDbCOntext(DbContextOptions<ShopBridgeDbCOntext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
