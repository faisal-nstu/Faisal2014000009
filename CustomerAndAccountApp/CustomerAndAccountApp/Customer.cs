using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountApp
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }

        public Account AnAccount { get; set; }


        public Customer(string customerName, string email)
        {
            CustomerName = customerName;
            Email = email;
        }

        public Customer()
        {

        }
    }
}
