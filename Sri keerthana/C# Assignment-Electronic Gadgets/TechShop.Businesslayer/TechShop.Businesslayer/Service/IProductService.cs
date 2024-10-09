using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;

namespace TechShop.Businesslayer.Service
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProduct(int id);
        bool IsProductInStock(int productId);
    }

}
