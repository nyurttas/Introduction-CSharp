using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOPTemelPrensipler2.Entities
{
    //Inheritance
    //Gomlek sınıfı Urun sınıfından kalıtım almıştır.
    //Urun sınıfı: parent (base class)
    //Gomlek sınıfı: child (derived class)
    public class Gomlek:Urun
    {
        public string? Size { get; set; }
        public string? Material { get; set; }
    }
}
