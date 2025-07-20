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
    public partial class _6_RandomSayiUretme : Form
    {
        public _6_RandomSayiUretme()
        {
            InitializeComponent();
        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            lstListe.Items.Clear();
            //instance (sınıfın bir örneğini almak)
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int randomSayi = rnd.Next(6, 50);
                lstListe.Items.Add(randomSayi);
            }


            int[] sayilar = new int[] { 1, 2, 3, 4, 5 };
            //contains dizinin içinde arama yaparak true false döner.
            bool cevap = sayilar.Contains(4);

        }

        private void btnSayiOlustur_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] secilenSayilar = new int[6];

            int sayi;

            for (int i = 0; i < secilenSayilar.Length; i++)
            {
                do
                {
                    sayi = rnd.Next(6, 50);
                } while (secilenSayilar.Contains(sayi));

                secilenSayilar[i] = sayi;
            }

            lstListe.Items.Clear();
            foreach (var item in secilenSayilar)
            {
                lstListe.Items.Add(item);
            }   
        }
    }
}
