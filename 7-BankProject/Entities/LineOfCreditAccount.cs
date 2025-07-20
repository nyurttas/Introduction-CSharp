using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_BankProject.Entities
{
    public class LineOfCreditAccount : BankAccount, IMonthEndPerform
    {
        public LineOfCreditAccount(string nameSurname, decimal firstBalance) : base(nameSurname, firstBalance)
        {
        }

        public void PerformMonthEndTransaction()
        {
            if (Balance <0)
            {
                decimal interest = Balance * 0.07m;
                MakeWithDrawal(interest, DateTime.Now, "Aylık faiz gideri çekildi.");
            }        
        }

        public override void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new Exception("Çekilen tutar 0'dan büyük olmalıdır.");
            }        

            //Para Çekme:
            var withDrawal = new Transaction(-amount, date, note);
            AllTransactions?.Add(withDrawal);
        }
    }
}
