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
    public partial class _4_Diziler : Form
    {
        public _4_Diziler()
        {
            InitializeComponent();
        }

        private void _4_Diziler_Load(object sender, EventArgs e)
        {
            /*
             DİZİLER (ARRAYS)
            Diziler içerisinde aynı türden biden çok değeri tutabilen, 
            indis (index) numaraları üzerinden bu değerlere ulaşabildiğimiz veri yapılarıdır. Dizinin içerisinde bulunan değerlere o dizinin elemanları denir. 

            İndis değerleri her zaman 0 dan başlar. 

             */

            string urunAdi = "Iphone 15 Pro Max";
            double urunFiyati = 98000;

            string urunAdi1 = "HD Ekran TV";
            double urunFiyati1 = 56000;


            //1-string bir dizi tanımlayalım:
            //4 elemanlı bir dizi
            //index değerleri : 0,1,2,3
            string[] ogrenciListesi = new string[4];

            //2-diziye değer atama:
            ogrenciListesi[0] = "Ahmet";
            ogrenciListesi[1] = "Can";
            ogrenciListesi[2] = "Metin";
            ogrenciListesi[3] = "Hasan";

            //3-diziden değer okuma:
            string ogrenciAdi = ogrenciListesi[3];

            //Dizi Metodları:
            //Array.Clear(ogrenciListesi);
            //Array.Copy();
            //Array.Sort(ogrenciListesi);
            //Array.Reverse(ogrenciListesi);

            int bulunanYer = Array.IndexOf(ogrenciListesi, "Metin");
            ogrenciListesi[bulunanYer] = "Süleyman";
            Array.LastIndexOf(ogrenciListesi, "Metin");
            Array.Resize(ref ogrenciListesi, 8);
        }

        //dizi oluşturalım:

        string[] studentList = new string[1];
        int sayac = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            //textboxlardan değerleri alalım:
            string name = txtName.Text;
            string surname = txtSurname.Text;

            string nameSurname = $"{name} {surname}";
            //string adSoyad = $"{txtName.Text} {txtSurname.Text}";

            studentList[sayac] = nameSurname;
            sayac++;
            //sayac = sayac + 1;

            //Dizinin eleman sayısı:
            int elemanSayisi = studentList.Length;

            Array.Resize(ref studentList, elemanSayisi + 1);
            //'Index was outside the bounds of the array.'
        }
        string deger = "Ahmet";
        private void button1_Click(object sender, EventArgs e)
        {
            deger = "Mehmet";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = deger;
        }
    }
}
