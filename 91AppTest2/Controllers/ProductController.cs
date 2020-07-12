using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _91AppTest2.Repository;
using _91AppTest2.ViewModels.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _91AppTest2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository<ProductListViewModels> _product;
        public ProductController(IProductRepository<ProductListViewModels> product)
        {
            _product = product;
        }
        [HttpGet("api/ProductGet")]
        public List<ProductViewModels> OrderGet(string ProductId)
        {
            var obj = _product.GetProducts(ProductId).Items;
            return obj;
        }
    }
}
