using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;
using TechShop.Businesslayer;

namespace TechShop.Exceptions
{
    public class ConcurrencyException : System.Exception
    {
        public ConcurrencyException(string message) : base(message)
        {
        }
    }
    public class ConcurrencyService
    {
        private object lockObject = new object();

        public void UpdateOrder(Order order)
        {
            lock (lockObject)
            {
                bool updateSuccess = false; 

                if (!updateSuccess)
                {
                    throw new ConcurrencyException("The order was updated by another user. Please try again.");
                }

            }
        }
    }
}
