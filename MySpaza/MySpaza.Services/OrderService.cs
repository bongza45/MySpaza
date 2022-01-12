using MySpaza.Core.Contracts;
using MySpaza.Core.Models;
using MySpaza.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpaza.Services
{
    public class OrderService:IOrderService
    {
        IRepository<Order> orderContext;
        public OrderService(IRepository<Order> OrderContext)
        {
            this.orderContext = OrderContext;
        }
        public void CreateOrder(Order baseOrder, List<BasketItemViewModel> basketItems)
        {
            foreach (var items in basketItems)
            {
                baseOrder.OrderItems.Add(new OrderItem()
                {
                    ProductId=items.Id,
                    Image=items.Image,
                    Price=items.Price,
                    ProductName=items.ProductName,
                    Quantity=items.Quantity

                });
            }
            orderContext.Insert(baseOrder);
            orderContext.Commit();

        }
    }
}
