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
    public partial class _2_TurDonusumleri : Form
    {
        public _2_TurDonusumleri()
        {
            InitializeComponent();
        }

        private void _2_TurDonusumleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //string değişkeni double 'a dönüştürme
            string deger = txtBirimFiyat.Text;
            double birimFiyat = Convert.ToDouble(deger);
            double kdvliFiyat = birimFiyat * 1.20;

            //sayısal bir değeri string 'e dönüştürme
            MessageBox.Show(birimFiyat.ToString());

            string number1 = "123";
            string number2 = "456";

            //int toplam = number1 + number2;
            int toplam = Convert.ToInt32(number1) + Convert.ToInt32(number2);

            //+ ile string birleştirmek yerine başka bir alternatif yöntem var mı?
            //String interpolation
           // lblMesaj.Text = "Ürün Fiyatı: " + birimFiyat + "KDV'li Fiyatı: " + kdvliFiyat;

            lblMesaj.Text = $"Ürün Fiyatı: {birimFiyat} Kdv'li Fiyatı: {kdvliFiyat}";
        }
    }
}
