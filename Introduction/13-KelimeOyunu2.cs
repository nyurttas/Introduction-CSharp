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
    public partial class _13_KelimeOyunu2 : Form
    {
        public _13_KelimeOyunu2()
        {
            InitializeComponent();
        }

        char[] harflerim = new char[]
        {
                'A', 'B', 'C','Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I','İ', 'J', 'K', 'L', 'M', 'N', 'O','Ö', 'P', 'R', 'S', 'Ş', 'T', 'U','Ü', 'V', 'Y', 'Z'
        };

        string[] iller = { "İstanbul", "Ankara" };
        string[] secilenIller = new string[1];
        string secilenKelime;
        int sayac = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            OyunuSifirla();

            #region Soru
            //içeriside sehirler olan string bir dizi yapalım
            //butona bastığımızda bu dizi içerisinden benzersiz şehirler secerek secilen kelimenin harf sayısı kadar butonu flwKelime içerisine ekleyelim.
            //flwAlfabe içerisine alfabemizdeki tüm harfleri buton olarak ekleyelim.
            //oyun için bir hak belirleyelim
            //alfabeden harfleri seçtikçe kelime içerisinde yer alıyorsa ilgili tüm yerleri doğru harf ile değiştirelim.
            //hakkım biterse ve kelime tamamlanmadıysa game over
            //hakkım bitmeden tüm kelimeyi açabilirsem kazandınız yeniden oynamak ister misiniz? (Yes) Tekrar (No) Formu Kapatır.
            //Not seçilen bir sehrin tekrar seçilerek gelmesini mutlaka engelleyelim.
            #endregion
            //tum butonları aktif edelim:
            foreach (var item in flwAlfabe.Controls)
            {
                Button btn = item as Button;
                btn.Enabled = true;
            }

            //dizi icerisinden radom il seçelim
            RandomSehirSec();

            //Secilen Kelimeyi Yerleştirelim:
            ButonlariAyarla();

            //Hak Tanımla:
            //hak = Convert.ToByte(secilenKelime.Length);
            hak = (byte)secilenKelime.Length;
            lblHak.Text = hak.ToString();
        }

        private void OyunuSifirla()
        {
            dogruSayisi = 0;
            lblDogru.Text = dogruSayisi.ToString();
        }

        private void ButonlariAyarla()
        {
            flwKelime.Controls.Clear();

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(80, 80);
                btn.Text = "--";
                btn.Tag = i;
                btn.Name = "btn" + i;
                flwKelime.Controls.Add(btn);
            }
        }

        private void RandomSehirSec()
        {
            //tüm iller seçildikten sonra secileniller dizisi yeniden oynayabilmek için sayac ile birlikte sıfırlanıyor.
            if (secilenIller.Length == iller.Length + 1)
            {
                secilenIller = new string[1];
                sayac = 0;
            }

            do
            {
                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(0, iller.Length);
                secilenKelime = iller[rastgeleSayi];

            } while (secilenIller.Contains(secilenKelime));

            secilenIller[sayac] = secilenKelime;
            sayac++;
            Array.Resize(ref secilenIller, secilenIller.Length + 1);
        }

        private void AlfabeOlustur()
        {
            for (int i = 0; i < harflerim.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(80, 80);
                btn.Text = harflerim[i].ToString();
                btn.Tag = i;
                btn.Enabled = false;
                btn.Click += Btn_Click;
                flwAlfabe.Controls.Add(btn);
            }
        }

        int dogruSayisi = 0;
        byte hak;

        private void Btn_Click(object? sender, EventArgs e)
        {
            bool buldunMu = false;
            //alfabenin harfleri için click eventi.

            //Hangi harfi sectim.
            Button? btn = sender as Button;

            if (btn != null)
            {
                string secilenHarf = btn.Text;

                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i].ToString().ToLower() == secilenHarf.ToLower())
                    {
                        flwKelime.Controls[i].Text = secilenHarf;
                        dogruSayisi++;
                        lblDogru.Text = dogruSayisi.ToString();
                        buldunMu = true;
                    }
                }

                if (!buldunMu)
                {
                    hak--;
                    lblHak.Text = hak.ToString();
                }

                if (hak == 0)
                {
                    OyunSonuKotrol("Kaybettiniz");
                }

                if (dogruSayisi == secilenKelime.Length)
                {
                    OyunSonuKotrol("Kazandınız");
                }
            }
        }

        private void OyunSonuKotrol(string mesaj)
        {
           DialogResult cvp= MessageBox.Show($"Oyun Bitti. {mesaj}. Yeniden oynamak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cvp==DialogResult.Yes)
            {
                btnBasla.PerformClick();
            }
            else
            {
                Application.Exit();
            }
        }

        private void _13_KelimeOyunu2_Load(object sender, EventArgs e)
        {
            AlfabeOlustur();
        }
    }
}
