using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EntityFrameworkCodeFirst.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        //public List<Product>? Products { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
