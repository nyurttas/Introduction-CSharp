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
    public partial class _5_Donguler : Form
    {
        public _5_Donguler()
        {
            InitializeComponent();
        }

        private void _5_Donguler_Load(object sender, EventArgs e)
        {
            //Döngüler
            /*
             Program yazarken bazı kodları tekrar tekrar yazıyorsanız orada bir hata var demektir. Kod bloklarını tekrarlı olarak çalıştırmak için döngü yapıları kullanılır. 

            Döngülerin temel amacı bir koşul sağlandığı sürece belirli bir kod bloğunu tekrar tekrar çalıştırmaktır.

            for, while, do while, foreach
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////listeye veri ekleme
            //lstListe.Items.Add(1);
            //lstListe.Items.Add(true);
            //lstListe.Items.Add(19.544);
            //lstListe.Items.Add("Ahmet");

            //butona bastığımda 1den 10 a kadar olan sayıları listeye ekleyiniz.

            //lstListe.Items.Add(1);

            //FOR DÖNGÜSÜ

            /*
             i              :sayac(counter) baslangıc değeri
            i<lengh         :döngü koşulu (kosul sağlandıkca dönmeye devam edecek)
            i++             : sayacın artık değil
             */

            for (int i = 0; i <= 5; i++)
            {
                lstListe.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                lstListe.Items.Add($"{i}. eleman:");
            }
        }

        string[] eticaretKategorileri = { "Elektronik", "Moda ve Giyim", "Ev ve Dekorasyon", "Kozmetik ve Kişisel Bakım", "Kitap ve Kırtasiye", "Spor ve Outdoor", "Oyuncak ve Bebek Ürünleri", "Otomobil ve Aksesuar", "Gıda ve Market", "Müzik ve Hobi" };

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < eticaretKategorileri.Length; i++)
            {
                lstListe.Items.Add(eticaretKategorileri[i]);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            //sayac oluştur:
            while (sayac < 20)
            {
                lstListe.Items.Add(sayac);
                sayac++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //1 den 100 e kadar olan sayılardan 5 e bölünenlerin toplamını bulalım.

            int counter = 0;
            int toplam = 0;

            while (counter <= 100)
            {
                if (counter % 5 == 0)
                {
                    toplam += counter;
                    //toplam = toplam + counter;
                }
                counter++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //DO WHILE
            char cevap = 'E';
            do
            {
                string soru = "Oyun Tekrar Oynansın Mı?";
                cevap = 'H';

            } while (cevap == 'E');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Foreach Döngüsü

            int sayac = 1;
            foreach (var item in eticaretKategorileri)
            {
                lstListe.Items.Add(sayac + "." + item);
                sayac++;
            }

            //for (int i = 0; i < eticaretKategorileri.Length; i++)
            //{
            //    //lstListe.Items.Add(eticaretKategorileri[i]);
            //    eticaretKategorileri[i] = "Deger: " + i;
            //}

            //var deger = 5;
            //var deger1 = "test";
            //var deger2 = true;
            //var deger3 = 4545.545;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < eticaretKategorileri.Length; i++)
            {
                if (eticaretKategorileri[i] == "Kitap ve Kırtasiye")
                {
                    //ilgili adımı atlar:
                    continue;
                }

                lstListe.Items.Add(eticaretKategorileri[i]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < eticaretKategorileri.Length; i++)
            {
                if (eticaretKategorileri[i] == "Kitap ve Kırtasiye")
                {
                    //ilgili adımdan sonra döngüyü sonlandır.
                    break;
                }

                lstListe.Items.Add(eticaretKategorileri[i]);
            }
        }
    }
}
