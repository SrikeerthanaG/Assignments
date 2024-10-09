using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.Businesslayer.Service
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
        Order GetOrder(int orderId);
        void UpdateOrder(Order order);
        void CancelOrder(int orderId);
        List<Order> GetAllOrders();
    }

}

