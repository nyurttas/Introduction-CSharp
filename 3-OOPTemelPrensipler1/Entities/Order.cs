using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOPTemelPrensipler1.Entities
{
    //Primary Constructor
    public class Order(int empID,int cID)
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
        public int EmployeeID { get; set; } = empID;
        public int CustomerID { get; set; } = cID;
    }
}
