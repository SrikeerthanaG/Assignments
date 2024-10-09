using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.entity
{
    public class Order
    {
        private int orderId;
        private Customer customer;
        private DateTime orderDate;
        private decimal totalAmount;

        // Constructor
        public Order(int id, Customer customer, DateTime date, decimal amount)
        {
            OrderID = id;
            Customer = customer;
            OrderDate = date;
            TotalAmount = amount;
        }

        // Properties with validation
        public int OrderID
        {
            get { return orderId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("OrderID must be a positive integer.");
                orderId = value;
            }
        }

        public Customer Customer
        {
            get { return customer; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Customer cannot be null.");
                customer = value;
            }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set
            {
                orderDate = value;
            }
        }

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("TotalAmount cannot be negative.");
                totalAmount = value;
            }
        }
    }
}
