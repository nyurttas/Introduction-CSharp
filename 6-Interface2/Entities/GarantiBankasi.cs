using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Interface2.Entities
{
    public class GarantiBankasi :Bank, IBankRepository
    {
        public string AddTransaction()
        {
            return "Garanti Bankası Ekle Metodu Çalıştı.";
        }

        public string DeleteTransaction(int id)
        {
            return "Garanti Bankası Delete Metodu Çalıştı.";
        }

        public string UpdateTransaction(int id)
        {
            return "Garanti Bankası Update Metodu Çalıştı.";
        }
    }
}
