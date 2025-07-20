using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Interface2.Entities
{
    public class ZiraatBankasi :Bank, IBankRepository
    {
        public string AddTransaction()
        {
            return "Ziraat Bankası Ekle Metodu Çalıştı.";
        }

        public string DeleteTransaction(int id)
        {
            return "Ziraat Bankası Delete Metodu Çalıştı.";
        }

        public string UpdateTransaction(int id)
        {
            return "Ziraat Bankası Update Metodu Çalıştı.";
        }
    }
}