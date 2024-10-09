using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Businesslayer.Service;
using TechShop.entity;

namespace TechShop.Businesslayer.Repository
{
    public class OrderDetailRepository : IOrderDetailService
    {
        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            orderDetails.Add(orderDetail);
            Console.WriteLine("Order detail added successfully.");
        }

        public OrderDetail GetOrderDetail(int orderDetailId)
        {
            return orderDetails.FirstOrDefault(od => od.OrderDetailID == orderDetailId) ?? throw new Exception("Order detail not found.");
        }

        public void UpdateQuantity(int orderDetailId, int quantity)
        {
            var orderDetail = GetOrderDetail(orderDetailId);
            orderDetail.Quantity = quantity;
            Console.WriteLine("Order detail quantity updated successfully.");
        }

        public decimal CalculateSubtotal(int orderDetailId)
        {
            var orderDetail = GetOrderDetail(orderDetailId);
            return orderDetail.Quantity * orderDetail.Product.Price;
        }
    }

}
