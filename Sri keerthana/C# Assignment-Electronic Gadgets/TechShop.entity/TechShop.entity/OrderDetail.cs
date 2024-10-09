using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.entity
{
    public class OrderDetail
    {
        private int orderDetailId;
        private Order order;
        private Product product;
        private int quantity;

        // Constructor
        public OrderDetail(int id, Order order, Product product, int qty)
        {
            OrderDetailID = id;
            Order = order;
            Product = product;
            Quantity = qty;
        }

        // Properties with validation
        public int OrderDetailID
        {
            get { return orderDetailId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("OrderDetailID must be a positive integer.");
                orderDetailId = value;
            }
        }

        public Order Order
        {
            get { return order; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Order cannot be null.");
                order = value;
            }
        }

        public Product Product
        {
            get { return product; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Product cannot be null.");
                product = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantity must be greater than 0.");
                quantity = value;
            }
        }
    }
}
