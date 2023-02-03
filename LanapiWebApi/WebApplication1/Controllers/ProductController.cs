using APIService.IServices;
using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[Controller]/[action]")]
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


        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromQuery] int id)
        {
            _productService.DeleteProduct(id);
            
        }

        [HttpPatch(Name = "Edit Product")]
        public void Patch(/*[FromHeader] string name,*/ /*[FromHeader] string usuarioPassword,*/ [FromBody] ProductItem productItem)
        {
                _productService.UpdateProduct(productItem);
        }

        [HttpGet(Name = "GetProductsByCriteria")]
        public List<ProductItem> GetProductByCriteria([FromQuery] string Brand)
        {

            return _productService.GetProductByCriteria(Brand);
        }
    }
}
