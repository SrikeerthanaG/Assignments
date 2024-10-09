using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;
using TechShop.Businesslayer;

namespace TechShop.exceptions
{

    public class IncompleteOrderException : System.Exception
    {
        public IncompleteOrderException(string message) : base(message)
        {
        }
    }


    public class OrderService
    {
        public void ProcessOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail.Product == null)
            {
                throw new IncompleteOrderException("OrderDetail is missing a product reference.");
            }

        }
    }

}
