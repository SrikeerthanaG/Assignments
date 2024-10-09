using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.entity;
using TechShop.Businesslayer;

namespace TechShop.exceptions
{
    public class AuthenticationException : System.Exception
    {
        public AuthenticationException(string message) : base(message)
        {
        }
    }
    public class AuthorizationException : System.Exception
    {
        public AuthorizationException(string message) : base(message)
        {
        }
    }


    public class SecurityService
    {
        public void AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false; // Simulating failed authentication

            if (!isAuthenticated)
            {
                throw new AuthenticationException("Invalid username or password.");
            }

        }

        public void CheckAuthorization(string userRole, string requiredRole)
        {
            if (userRole != requiredRole)
            {
                throw new AuthorizationException("You do not have the required permissions to access this resource.");
            }

        }
    }

}
