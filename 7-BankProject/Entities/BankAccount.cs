using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _7_BankProject.Entities
{
    public class BankAccount
    {
        public BankAccount(string nameSurname, decimal firstBalance)
        {
            Owner = nameSurname;
            MakeDeposit(firstBalance, DateTime.Now, "Hesap açılış bakiyesi yatırıldı.");
        }
        //Otomatik benzersiz hesap numarası
        public string? Number { get; } = Guid.NewGuid().ToString();
        public string? Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal b = 0;
                foreach (var item in AllTransactions)
                {
                    b += item.Amount;
                }
                return b;
            }
        }

        //Bütün para yatırma ve çekme işlemleri burada yeni bir transaction olarak tutulacak.
        //internal bir değişkene sadece türemiş sınıflardan ulaşılabilir.
        //new'lemeyi unutursanız: Object reference not set to an instance of an object
        internal List<Transaction>? AllTransactions { get; set; } = new();

        //Para Yatırma İşlemi (MakeDeposit)
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new Exception("Yatırılan tutar 0'dan büyük olmalıdır.");
            }

            //Para Yatırma:
            var deposit = new Transaction(amount, date, note);
            AllTransactions?.Add(deposit);
        }

        //Para Çekme İşlemi: (Make WithDrawal)
        public virtual void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new Exception("Çekilen tutar 0'dan büyük olmalıdır.");
            }

            //Bakiye yeterli olmalıdır.

            if (Balance < amount)
            {
                throw new Exception($"Hesap bakiyeniz yetersiz. Çekilebilecek tutar:{Balance}");
            }

            //Para Çekme:
            var withDrawal = new Transaction(-amount, date, note);
            AllTransactions?.Add(withDrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            int sayac = 1;

            foreach (var item in AllTransactions)
            {
                string islemTipi = item.Amount < 0 ? "Para Çekme" : "Para Yatırma";
                report.AppendLine($"{sayac}.işlem: {item.Amount.ToString("N2")} TL - {islemTipi}");
                sayac++;
            }

            return report.ToString();
        }

    }
}
