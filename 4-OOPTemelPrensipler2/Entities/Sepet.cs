using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOPTemelPrensipler2.Entities
{
    public class Sepet
    {
        private List<Urun>? UrunListesi { get; set; } = new();

        public void SepeteUrunEkle(Urun prd)
        {
            //Ürün listesinde Lacoste Slim Fix isimli bir gömlek var mı yok mu nasıl kontrol ederiz?
            #region Cozum1
            //bool buldunmu = false;
            //            foreach (var item in UrunListesi)
            //            {
            //                if (item.ProductName==prd.ProductName)
            //                {
            //                    item.Quantity += prd.Quantity;
            //                    buldunmu = true;
            //                    break;
            //                }
            //            }

            //            if (buldunmu==false)
            //            {
            //                UrunListesi.Add(prd);
            //            }
            #endregion

            #region Cozum2
            var bulunan = UrunListesi?.FirstOrDefault(p => p.ProductName == prd.ProductName);

            if (bulunan!=null)
            {
                bulunan.Quantity += prd.Quantity;
            }
            else
            {
                UrunListesi?.Add(prd);
            }
            #endregion

        }

        public void SepettenUrunCikar(Urun prd)
        {
            //sepetteki secilen urun adedi 1 den fazla ise quantity-=1 yapalım, 
            //1'e eşit ise ürünü tamamen listeden kaldıralım.

            if (prd.Quantity==1)
            {
                UrunListesi?.Remove(prd);
            }
            else
            {
                prd.Quantity -= 1;
            }

        }

        public List<Urun>? TumUrunleriListele()
        {
            return UrunListesi;
        }
    }
}
