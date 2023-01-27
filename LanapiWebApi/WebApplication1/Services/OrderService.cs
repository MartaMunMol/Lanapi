using APIService.IServices;
using Entities.Entities;
using Logic.Ilogic;

namespace APIService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic;
        public OrderService (IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public int InsertOrder(OrderItem orderitem)
        {
            _orderLogic.InsertOrderItem(orderitem);
            return orderitem.Id;
        }
        public List<OrderItem> GetOrderItem()
        {
            return _orderLogic.GetOrderItem();     
        }

    }
}

