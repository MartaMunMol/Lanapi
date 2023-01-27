using Data;
using Entities.Entities;
using Logic.Ilogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Add(orderItem);
            _serviceContext.SaveChanges();
        }
        public List<OrderItem> GetOrderItem()
        {
            return _serviceContext.Set<OrderItem>().ToList();

            //var resultList = new List<OrderItem>();
            //return resultList();
        }
    }
}
