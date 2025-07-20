using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Interface2.Entities
{
    public class BankRepository
    {
        private readonly IBankRepository _bankRepository;
        public BankRepository(IBankRepository b)
        {
            _bankRepository = b;
        }
        public string Ekle()
        {
           return _bankRepository.AddTransaction();
        }

        public string Sil(int id)
        {
            return _bankRepository.DeleteTransaction(id);
        }

        public string Guncelle(int id)
        {
            return _bankRepository.UpdateTransaction(id);
        }
    }
}
