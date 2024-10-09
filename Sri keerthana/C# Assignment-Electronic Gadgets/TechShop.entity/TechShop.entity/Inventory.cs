using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.entity
{
    public class Inventory
    {
        private int inventoryId;
        private Product product;
        private int quantityInStock;
        private DateTime lastStockUpdate;

        // Constructor
        public Inventory(int id, Product product, int qtyInStock, DateTime lastUpdate)
        {
            InventoryID = id;
            Product = product;
            QuantityInStock = qtyInStock;
            LastStockUpdate = lastUpdate;
        }

        // Properties with validation
        public int InventoryID
        {
            get { return inventoryId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("InventoryID must be a positive integer.");
                inventoryId = value;
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

        public int QuantityInStock
        {
            get { return quantityInStock; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity in stock cannot be negative.");
                quantityInStock = value;
            }
        }

        public DateTime LastStockUpdate
        {
            get { return lastStockUpdate; }
            set
            {
                lastStockUpdate = value;
            }
        }
    }
}
