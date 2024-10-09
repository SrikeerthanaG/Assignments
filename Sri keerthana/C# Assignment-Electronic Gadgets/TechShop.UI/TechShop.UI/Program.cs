using TechShop.entity;
using TechShop.Businesslayer;
using System.Collections.Generic;
using System.Linq;
using System;
using TechShop.Businesslayer.Repository;
using TechShop.Businesslayer.Service;

namespace TechShop.ConsoleApp
{
    class MainModule
    {
        static void Main(string[] args)
        {
            CustomerRepository customerRepo = new CustomerRepository();
            ProductRepository productRepo = new ProductRepository();
            OrderRepository orderRepo = new OrderRepository();
            OrderDetailRepository orderDetailRepo = new OrderDetailRepository();
            InventoryRepository inventoryRepo = new InventoryRepository();

            // Adding a customer
            Customer newCustomer = new Customer(1, "Sri", "Nithi", "srinithi@gmail.com", "1234567890", "123,tvs nagar");
            customerRepo.AddCustomer(newCustomer);

            // Adding a product
            Product newProduct = new Product(1, "Laptop", "High-end gaming laptop", 1500.99m);
            productRepo.AddProduct(newProduct);



            // Displaying customer details
            var customer = customerRepo.GetCustomer(1);
            Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName}, Email: {customer.Email}");

            // Displaying product details
            var product = productRepo.GetProduct(1);
            Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price}");


            Console.ReadLine();
        }
    }
}
