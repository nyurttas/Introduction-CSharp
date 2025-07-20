using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOPTemelPrensipler2.Entities
{
    //BASE CLASS
    public class Urun
    {
        public string? ProductID { get; } = Guid.NewGuid().ToString();
        public int Quantity { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public double UnitPrice { get; set; }

        //Polymorphism
        //
        public virtual double Tax()
        {
            return UnitPrice * 1.18;
        }

        public override string ToString()
        {
            return $"{ProductName}-{Quantity}";
        }
    }
}
