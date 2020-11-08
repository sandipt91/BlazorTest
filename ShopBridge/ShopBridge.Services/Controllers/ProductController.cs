using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ShopBridge.DataModels.Models;
using ShopBridge.Services.RepositoryPattern;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopBridge.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct productRepo;
        public ProductController(IProduct productRepo)
        {
            this.productRepo = productRepo;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult> GetAllProduct()
        {
            return Ok(await productRepo.ProductList());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> GetProduct(Guid id)
        {
            var result = await productRepo.Product(id);
            return result;
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            var result = await productRepo.Create(product);
            return result;
        }

        // PUT api/<ProductController>/5
        [HttpPost]
        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await productRepo.Update(product);
            return result;
        }

        // DELETE api/<ProductController>/5
        [HttpPost]
        public async Task<Product> DeleteProduct(Product product)
        {
            var result = await productRepo.DeleteProduct(product);

            return result;
        }
    }
}
