using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_BankProject.Entities
{
    public class Transaction(decimal amount, DateTime date, string not)
    {
        public decimal Amount { get; set; } = amount;
        public DateTime Date { get; set; } = date;
        public string? Note { get; set; } = not;
    }
}
