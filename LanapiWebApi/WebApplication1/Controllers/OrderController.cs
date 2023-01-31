using APIService.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILogger<ProductController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }
        [HttpPost(Name = "InsertOrder")]
        public int Post([FromBody] OrderItem orderItem)
        {
            return _orderService.InsertOrder(orderItem);
        }

        [HttpGet(Name ="GetOrderItem")]
        public List<OrderItem> Get()
        {
            return _orderService.GetOrderItem();
        }

    }
}
