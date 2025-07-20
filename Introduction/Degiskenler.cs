namespace Introduction
{
    public partial class Degiskenler : Form
    {
        public Degiskenler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //yorum satýrý

            /*
             çoklu
            yorum
            satýrý

             */

            /*
            Deðiþkenler (Variables)
            Bilgisayar belleðinde bazý deðerleri tutmaya yarayan yapýlardýr.
             */

            byte stok = 255;
            //byte.MaxValue;
            //byte.MinValue;

            int number = 456;
            short quantity = 32454;
            double ondalikSayi = 232.323;

            //Deðiþken isimlendirme yöntemleri
            //camelCase,PascalCase, snake_case

            string adSoyad = "Caner Mollaoðlu";
            string nameSurname = "Caner Mollaoðlu";

            char karakter = 'a';

            double unitPrice = 65500.45;
            double birimFiyat = 45000;

            bool cevap = true;
            bool islemIptalmi = false;
            bool durum = true;

            bool answer = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            btnGetir.Text = "Deneme";
            btnGetir.Visible = false;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
