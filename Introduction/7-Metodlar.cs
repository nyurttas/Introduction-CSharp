namespace Introduction
{
    public partial class _7_Metodlar : Form
    {
        public _7_Metodlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Metod Nedir Yaz:
            //Metodlar, programlama dillerinde tekrar tekrar kullanılacak kod bloklarını gruplamak için kullanılan yapılardır.

            /*
             METODLAR
            Program içerisinde aynı işi yapan satırları belirli bir düzende bir araya getirdiğimiz yapılardır. Gerektiğinde çağırılarak kullanılırlar. Metodlar sayesinde kod tekrarı yapmadan daha anlaşılır bir şekilde kodlama yapılabilir.

            Metodlar direkt olarak çalışmazlar. Program içerisinde metodları çağırmak gerekir. 

            Metod Türleri

            1- Geriye Değer Dönen Metodlar
                Parametre alanlar
                Parametre almayanlar
            2-Geriye Değer Dönmeyen Metodlar
                Parametre alanlar
                Parametre almayanlar
             */

            //MessageBox.Show("Yeni bir deneme");
            //MessageBox.Show("Yeni bir deneme","METODLAR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Geriye değer dönmeyen parametresiz metod
            MesajVer();
        }

        private void MesajVer()
        {
            MessageBox.Show("Deneme");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Geriye değer dönmeyen parametreli metod
            //SendMessage("Yeni bir metod deniyoruz.");
            //SendMessage("Kayıt Başarılı.", "Kayıt İşlemi");
            SendMessage("Deneme Kayıt", "MESAJBOX DENEME", false);
        }

        //Method Overload (Metodun Aşırı Yüklenmesi)
        private void SendMessage(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        private void SendMessage(string mesaj, string baslik)
        {
            MessageBox.Show(mesaj, baslik);
        }

        private void SendMessage(string mesaj, string baslik, bool durum)
        {
            if (durum)
            {
                MessageBox.Show(mesaj, baslik);
            }
            else
            {
                MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RenkDegistir();
        }

        private void RenkDegistir()
        {
            //if (this.BackColor==Color.Coral)
            //{
            //    this.BackColor = Color.Gray;
            //}
            //else
            //{
            //    this.BackColor = Color.Coral;
            //}

            //ternary if
            this.BackColor = this.BackColor == Color.Coral ? Color.Gray : Color.Coral;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Geriye değer dönen, parametresiz metod
            int randomSayi = RandomSayiOlustur();
        }

        private int RandomSayiOlustur()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, 50);
            return sayi;
        }

        private int RandomSayiOlustur(int min, int max)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(min, max);
            return sayi;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rnd = RandomSayiOlustur(50, 150);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] sayiDizim = new int[] { 12, 34334, 5656, 4545, 3434, 6767, 453 };

            //iki sayıyı toplayan bir metod yapalım:

            int toplamSonuc = SayilariTopla(56, 80);
            int sonuc = SayilariTopla(4, 56, 698);
            int diziToplami = SayilariTopla(sayiDizim);
            int gelenToplam = SayilariTopla(true, 5, 5666, 767, 43345, 2434, 7656765, 3423, 123);
        }

        private int SayilariTopla(int v1, int v2)
        {
            return v1 + v2;
        }

        private int SayilariTopla(int v1, int v2, int v3)
        {
            return v1 + v2 + v3;
        }
        private int SayilariTopla(int[] intDizi)
        {
            int toplam = 0;
            foreach (var item in intDizi)
            {
                toplam += item;
            }
            return toplam;
        }

        //Params nedir?
        //Params, metodun parametrelerine istediğimiz kadar değer gönderebilmemizi sağlar.
        private int SayilariTopla(bool c, params int[] dizi)
        {
            int toplam = 0;
            foreach (var item in dizi)
            {
                toplam += item;
            }
            return toplam;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Ref anahtar kelimesi
            //Ref anahtar kelimesi ile bir değişkenin referansını göndeririz. Bu sayede metod içerisinde yapılan değişiklikler, gönderilen değişkenin değerini değiştirir.

            //Ref kullandığımızda değişkene mutlaka bir ilk değer ataması yapılmış olmalıdır. int sayi=0 gibi.

            int sayi = 0;

            DegerDegistir(ref sayi);
            MessageBox.Show(sayi.ToString());
        }

        private void DegerDegistir(ref int number)
        {
            number = 100;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Out anahtar kelimesi
            //Out anahtar kelimesi ref anahtar kelimesi ile aynı işlevi görür. Fakat ref anahtar kelimesinden farkı, out anahtar kelimesi ile gönderilen değişkenin değeri metod içerisinde değiştirilmek zorundadır.

            int number;
            DegerDegistirOut(out number);
            MessageBox.Show(number.ToString());
        }

        private void DegerDegistirOut(out int number)
        {
            number = 100;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ad = "Ahmet", soyad = "Aksakal", adSoyad;
            CumleBirlestir(ad, ref soyad, out adSoyad);
            lblMesaj.Text = $"{ad}\n{soyad}\n{adSoyad}";
        }

        private void CumleBirlestir(string ad, ref string soyad, out string adSoyad)
        {
            ad = "Kuzey";
            soyad = "Genç";
            adSoyad = ad + " " + soyad;
        }
    }
}
