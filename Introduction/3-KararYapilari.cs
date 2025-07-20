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
    public partial class _3_KararYapilari : Form
    {
        public _3_KararYapilari()
        {
            InitializeComponent();
        }

        private void _3_KararYapilari_Load(object sender, EventArgs e)
        {
            /*
                Karar Yapıları (If else)

                OPERATÖRLER
                Karşılaştırma Oparatörleri
                <,>,<=,>=,==,!=

                Mantıksal Operatörler
                ve operatörü &, &&
                veya operatörü |, ||

                Aritmetik Operatörler 
                +,-,*,/,%

                int toplam = 5 + 6;
                int kalan = 567 % 4;

                Aktarma Operatörleri
                =,+=, -=, *=, /=
             */
            //int sayi = 54 + 434;
            //int kalan = 45 % 4;

            //if (true)
            //{
            //    MessageBox.Show("Doğru");
            //}
            //else
            //{
            //    MessageBox.Show("Yanlış");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ve operatörü  &, &&


            //Ahmet'in araç kullanabilmesi için yaşının 18'e eşit ya da büyük olması ve aynı zamanda ehliyetinin olması gerekmektedir.

            int age = 15;
            bool hasDrivingLicense = true;

            if (age >= 18 && hasDrivingLicense == true)
            {
                MessageBox.Show("Araba Kullanabilir.");
            }
            else
            {
                MessageBox.Show("Araba Kullanamaz.");
            }



            string userName = "admin";
            string password = "1234567";

            if (userName == "admin" && password == "123456")
            {
                MessageBox.Show("Login Başarılı.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da sifre yanlış.");
            }

            /*
             &,&& operatörü kullanılıyorsa:

            True, True      : True
            True, False     : False
            False, True     : False
            False, False    : False
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Müsteriye kupon kodu varsa ya da 2000 TL üzerinde alışveris yaptıysa hediye urun verilecektir. 

            decimal alisverisTutari = 2500;
            bool kuponKoduVarmi = false;

            if (alisverisTutari > 2000 || kuponKoduVarmi == true)
            {
                //Hediye ürün ver.
            }
            else
            {
                //Hediye ürün için kosullar uygun değil.
            }

            /*
             veya || Kullanıyorsak:

            true, true      : true
            true, false     : true
            false, true     : true
            false, false    : false
             */
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            /*
            500 ile 1000 tl arasında alışveris yapan müşterilere %20,
            1000 ile 2500 tl arasında alışveris yapan müşterilere %25,
            2500 ile 5000 tl arasında alışveris yapan müşterilere %35,
            5000 tl den fazla alışveris yapan müşterilere %45
            */

            double tutar = Convert.ToDouble(txtTutar.Text);


            //if (tutar > 5000)
            //{
            //    //%45
            //}
            //else if (tutar > 2500)
            //{
            //    //%35
            //}
            //else if (tutar > 1000)
            //{
            //    //%25
            //}
            //else if (tutar >= 500)
            //{
            //    //%35
            //}
            //else
            //{

            //}


            if (tutar >= 500 && tutar <= 1000)
            {
                //%20
            }
            else if (tutar > 1000 && tutar <= 2500)
            {
                //%25
            }
            else if (tutar > 2500 && tutar <= 5000)
            {
                //%35
            }
            else if (tutar > 1000 && tutar <= 2500)
            {
                //%45
            }
            else
            {
                //500 den küçük olan aşılveris için burası çalışır.
            }
        }


    }
}

