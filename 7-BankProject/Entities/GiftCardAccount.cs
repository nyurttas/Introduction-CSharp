using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_BankProject.Entities
{
    public class GiftCardAccount : BankAccount,IMonthEndPerform
    {
        private decimal _monthlyPay;
        public GiftCardAccount(string nameSurname, decimal firstBalance, decimal monthlyPay = 0) : base(nameSurname, firstBalance)
        {
            _monthlyPay = monthlyPay;
        }

        public void PerformMonthEndTransaction()
        {
            MakeDeposit(_monthlyPay, DateTime.Now, "Aylık exstra para yatırma işlemi yapıldı.");
        }
    }
}
