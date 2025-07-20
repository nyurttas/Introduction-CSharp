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
    public partial class _10_KursTakip : Form
    {
        public _10_KursTakip()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //TC,Ad Soyad, Seçilen Eğitim bilgileri alınarak asağıdaki sekilde listeye eklenecektir.

            //21188212252-Caner Mollaoğlu/React,Angular,C# Introduction

            try
            {
                string tc = txtTC.Text;
                string adSoyad = txtAdSoyad.Text;
                string secilenler = SecilenleriGetir();

                lstListe.Items.Add($"{tc}-{adSoyad}/{secilenler}");
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormuTemizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }

        List<string> secilenListe = new List<string>();
        //List<T> sınıfı, belirli bir türdeki öğelerin koleksiyonunu depolamak için kullanılır. List<T> sınıfı, dizilere benzer, ancak boyutları dinamik olarak büyüyebilir. List<T> sınıfı, koleksiyonunuzda öğeleri eklemek, silmek ve aramak için yöntemler sağlar. List<T> sınıfı, koleksiyonunuzda öğeleri sıralı bir şekilde depolar ve bu öğelere dizinle erişim sağlar.

        //Generic nedir?
        //Generic kodun tekrar kullanılabilirliğini artıran ve tür güvenliği sağlayan bir programlama özelliğidir. List sınıfın türden bağımsız olarak çalışabilmesini sağlar.
        private string SecilenleriGetir()
        {
            foreach (var item in grpEgitimler.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox? chk = item as CheckBox;
                    if (chk.Checked)
                    {
                        secilenListe.Add(chk.Text);
                        chk.Checked = false;
                    }
                }
            }
            return string.Join(',', secilenListe);
        }

        private void _10_KursTakip_Load(object sender, EventArgs e)
        {

        }
    }
}
