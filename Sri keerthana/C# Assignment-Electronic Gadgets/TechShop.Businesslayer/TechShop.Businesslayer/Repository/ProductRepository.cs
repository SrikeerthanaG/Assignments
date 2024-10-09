using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Businesslayer.Service;
using TechShop.entity;

namespace TechShop.Businesslayer.Repository
{
    public class ProductRepository : IProductService
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = GetProduct(product.ProductID);
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
            Console.WriteLine("Product updated successfully.");
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(p => p.ProductID == id) ?? throw new Exception("Product not found.");
        }

        public bool IsProductInStock(int productId)
        {
            
            return new Random().Next(0, 2) == 1; 
        }

    }

}
