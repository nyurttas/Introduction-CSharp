using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOPTemelPrensipler2.Entities
{
    public class CepTelefonu:Urun
    {
        public byte BatteryLife { get; set; }
        public byte RamCapacity { get; set; }

        public override double Tax()
        {
            return UnitPrice * 1.20;
        }
    }
}
