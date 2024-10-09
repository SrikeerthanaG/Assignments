using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;
using TechShop.Businesslayer;

namespace TechShop.Exceptions  
{
    public class InvalidDataException : System.Exception
    {
        public InvalidDataException(string message) : base(message)
        {
        }
    }

    public class CustomerService
    {
        public void RegisterCustomer(string email)
        {
            if (!IsValidEmail(email))
            {
                throw new InvalidDataException("The provided email address is invalid.");
            }

        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
