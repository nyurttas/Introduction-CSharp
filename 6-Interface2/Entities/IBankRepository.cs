using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Interface2.Entities
{
    public interface IBankRepository
    {
        string AddTransaction();
        string UpdateTransaction(int id);
        string DeleteTransaction(int id);
    }
}
