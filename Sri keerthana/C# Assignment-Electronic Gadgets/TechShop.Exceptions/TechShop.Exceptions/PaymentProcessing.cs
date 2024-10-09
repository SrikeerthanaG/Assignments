using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;
using TechShop.Businesslayer;

namespace TechShop.exceptions
{
    public class PaymentFailedException : System.Exception
    {
        public PaymentFailedException(string message) : base(message)
        {
        }
    }


    public class PaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            bool paymentSuccessful = false; // Simulating a failed payment

            if (!paymentSuccessful)
            {
                throw new PaymentFailedException("Payment was declined. Please check your payment method.");
            }

        }
    }

}