using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class _8_OgrenciTakip : Form
    {
        public _8_OgrenciTakip()
        {
            InitializeComponent();
        }

        Dictionary<string, double> studentList = new Dictionary<string, double>();

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            #region Dictionary Tanımlama
            //Dictionary Nedir:
            //Dictionary, anahtar-değer (key - value) mantığı ile çalışan oldukça kullanışlı bir koleksiyon yapısıdır. Bir anahtara karşılık gelen değeri saklar ve bu anahtar benzersizdir. Anathar ve değerler farklı tiplerde olabilir.

            //Dictionary Oluşturma:
            Dictionary<string, double> ogrenciListesi = new Dictionary<string, double>();

            //Ekleme Yapma:
            ogrenciListesi.Add("Ahmet Aksakal", 56.68);
            ogrenciListesi.Add("Kuzey Mollaoğlu", 90.45);
            ogrenciListesi.Add("Cansu Mollaoğlu", 87.50);

            bool cvp = ogrenciListesi.Remove("Ahmet Aksakal");
            #endregion
            #region Hata Kontrol Mekanizması     
            /*
             try    : tüm işlemler bu blokta yapılacak.
             catch  : try bloğunda bir hata oluşursa bu blok çalışacak.
             finally: try ve catch bloklarından sonra mutlaka çalışacak bloktur. Hata olsa da olmasa da çalışmasını istediğimiz kodlar buraya yazılır.
             */
            #endregion

            try
            {
                string adSoyad = txtAdSoyad.Text;
                double vizeNotu = Convert.ToDouble(txtVize.Text);
                double finalNotu = Convert.ToDouble(txtFinal.Text);

                double ortalama = OrtalamaHesapla(vizeNotu, finalNotu);

                studentList.Add(adSoyad, ortalama);
                ListeyiGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListeyiGuncelle()
        {
            lstListe.Items.Clear();
            foreach (var item in studentList)
            {
                lstListe.Items.Add($"{item.Key}-{item.Value}");
            }
        }

        private double OrtalamaHesapla(double vizeNotu, double finalNotu)
        {
            return (vizeNotu * 0.4) + (finalNotu * 0.6);
        }
    }
}
