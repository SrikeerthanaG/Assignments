using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.entity
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string address;

        // Constructor
        public Customer(int id, string fName, string lName, string email, string phone, string address)
        {
            CustomerID = id;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Phone = phone;
            Address = address;
        }

        // Properties with validation
        public int CustomerID
        {
            get { return customerId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("CustomerID must be a positive integer.");
                customerId = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name cannot be empty.");
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name cannot be empty.");
                lastName = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains("@"))
                    throw new ArgumentException("Invalid email format.");
                email = value;
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("Phone number must be 10 digits.");
                phone = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Address cannot be empty.");
                address = value;
            }
        }
    }
}