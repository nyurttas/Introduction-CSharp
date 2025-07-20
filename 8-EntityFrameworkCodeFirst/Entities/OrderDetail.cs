﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EntityFrameworkCodeFirst.Entities
{
    public class OrderDetail
    {
        //public int ID { get; set; }
        public int ProductID { get; set; }
        public Product? Product { get; set; }
        public Order? Order { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
