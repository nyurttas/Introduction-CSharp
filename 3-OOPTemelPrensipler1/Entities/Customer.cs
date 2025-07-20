using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOPTemelPrensipler1.Entities
{
    public class Customer
    {
        //Constructor 1
        public Customer(string sirketAdi, string ulkeAdi)
        {
            CompanyName = sirketAdi;
            Country = ulkeAdi;
            // IsActive = true;
            CustomerID = Guid.NewGuid().ToString();
        }

        //Constructor 2
        public Customer()
        {

        }

        //public string? CustomerID { get; } = Guid.NewGuid().ToString();
        public string? CustomerID { get; }
        public string? CompanyName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Country { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
