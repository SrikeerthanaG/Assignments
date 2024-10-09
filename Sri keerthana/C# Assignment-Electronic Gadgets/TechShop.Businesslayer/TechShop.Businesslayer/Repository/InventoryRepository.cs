using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Businesslayer.Service;
using TechShop.entity;

namespace TechShop.Businesslayer.Repository
{
    public class InventoryRepository : IInventoryService
    {
        private List<Inventory> inventories = new List<Inventory>();

        public void AddToInventory(Inventory inventory)
        {
            inventories.Add(inventory);
            Console.WriteLine("Product added to inventory.");
        }

        public void UpdateStockQuantity(int productId, int newQuantity)
        {
            var inventory = GetInventoryByProduct(productId);
            inventory.QuantityInStock = newQuantity;
            Console.WriteLine("Inventory stock quantity updated.");
        }

        public Inventory GetInventoryByProduct(int productId)
        {
            return inventories.FirstOrDefault(i => i.Product.ProductID == productId) ?? throw new Exception("Inventory not found.");
        }

        public bool IsProductAvailable(int productId, int quantity)
        {
            var inventory = GetInventoryByProduct(productId);
            return inventory.QuantityInStock >= quantity;
        }
    }

}
