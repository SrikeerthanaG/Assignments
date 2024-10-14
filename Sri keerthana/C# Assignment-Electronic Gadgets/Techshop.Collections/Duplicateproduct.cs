using System;
using System.Collections.Generic;
using System.Linq;
using TechShop.entity;
using TechShop.entity;
using TechShop.Exceptions;

namespace TechShop.Collections
{
    public class ProductCollection
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            if (Products.Any(p => p.ProductName == product.ProductName))
                throw new InvalidDataException("Duplicate product.");
            Products.Add(product);
        }

        public void UpdateProduct(int productId, string description, decimal price)
        {
            var product = GetProductById(productId);
            if (product != null) { product.Description = description; product.Price = price; }
            else throw new InvalidDataException("Product not found.");
        }

        public void RemoveProduct(int productId)
        {
            var product = GetProductById(productId);
            if (product != null) Products.Remove(product);
            else throw new InvalidDataException("Product not found.");
        }

        public Product GetProductById(int productId) => Products.FirstOrDefault(p => p.ProductID == productId);

        public List<Product> SearchProductsByName(string name) => Products.Where(p => p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
