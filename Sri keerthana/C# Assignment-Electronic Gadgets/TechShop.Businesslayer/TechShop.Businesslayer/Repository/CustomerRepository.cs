using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Businesslayer.Service;
using TechShop.entity;

namespace TechShop.Businesslayer.Repository
{
    public class CustomerRepository : ICustomerService
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Customer added successfully.");
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = GetCustomer(customer.CustomerID);
            existingCustomer.Email = customer.Email;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Address = customer.Address;
            Console.WriteLine("Customer updated successfully.");
        }

        public Customer GetCustomer(int id)
        {
            return customers.FirstOrDefault(c => c.CustomerID == id) ?? throw new Exception("Customer not found.");
        }

        public int CalculateTotalOrders(int customerId)
        {
            return new Random().Next(1, 10);
        }
    }

}
