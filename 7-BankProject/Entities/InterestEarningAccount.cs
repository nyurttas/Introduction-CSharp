using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_BankProject.Entities
{
    public class InterestEarningAccount : BankAccount,IMonthEndPerform
    {
        public InterestEarningAccount(string nameSurname, decimal firstBalance) : base(nameSurname, firstBalance)
        {

        }

        public void PerformMonthEndTransaction()
        {
            if (Balance>500)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "Aylık faiz getirisi yatırıldı.");
            }
        }
    }
}
