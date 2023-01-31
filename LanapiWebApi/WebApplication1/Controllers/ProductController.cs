using APIService.IServices;
using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        [HttpPost(Name = "InsertProduct")]

        public int Post([FromBody]ProductItem productItem)
        {
            return _productService.InsertProduct(productItem);
        }

        [HttpGet(Name = "GetProductItem")]
        public List<ProductItem> Get()
        {
            return _productService.GetProductItem();
        }
    }
}
