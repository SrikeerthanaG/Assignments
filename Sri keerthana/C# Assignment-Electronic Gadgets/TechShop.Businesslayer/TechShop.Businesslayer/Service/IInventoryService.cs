using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;


namespace TechShop.Businesslayer.Service
{
    public interface IInventoryService
    {
        void AddToInventory(Inventory inventory);
        void UpdateStockQuantity(int productId, int newQuantity);
        Inventory GetInventoryByProduct(int productId);
        bool IsProductAvailable(int productId, int quantity);
    }

}
