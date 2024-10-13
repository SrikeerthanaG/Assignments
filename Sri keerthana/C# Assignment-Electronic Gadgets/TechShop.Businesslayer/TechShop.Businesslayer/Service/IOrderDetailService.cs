using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.Businesslayer.Service
{
    public interface IOrderDetailService
    {
        void AddOrderDetail(OrderDetail orderDetail);
        OrderDetail GetOrderDetail(int orderDetailId);
        void UpdateQuantity(int orderDetailId, int quantity);
        decimal CalculateSubtotal(int orderDetailId);
    }

}
