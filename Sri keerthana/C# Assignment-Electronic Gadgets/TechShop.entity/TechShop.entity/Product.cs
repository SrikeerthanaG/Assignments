using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.entity
{
    public class Product
    {
        private int productId;
        private string productName;
        private string description;
        private decimal price;

        // Constructor
        public Product(int id, string name, string desc, decimal price)
        {
            ProductID = id;
            ProductName = name;
            Description = desc;
            Price = price;
        }

        // Properties with validation
        public int ProductID
        {
            get { return productId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ProductID must be a positive integer.");
                productId = value;
            }
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Product name cannot be empty.");
                productName = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }
    }
}

