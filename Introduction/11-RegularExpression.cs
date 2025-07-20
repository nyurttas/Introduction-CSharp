using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class _11_RegularExpression : Form
    {
        public _11_RegularExpression()
        {
            InitializeComponent();
        }

        private void _11_RegularExpression_Load(object sender, EventArgs e)
        {
            /*
             Regular Expression (Düzenli İfadeler)
            Düzenli ifadeler, metin işleme ve arama işlemlerinde kullanılan bir yapıdır. Bir metin içerisinde ifadeleri tanımlamak için kullanılan özel karakterler ve semboller kombinasyonudur.

            https://en.wikipedia.org/wiki/Regular_expression

            [0-9]       : rakamsal değerleri temsil eder.
            [a-z]       : küçük harfleri temsil eder.
            [A-Z]       : büyük harfleri temsil eder.
            [a-zA-Z]    : küçük ve büyük harfleri temsil eder.
            [0-9a-zA-Z] : rakam ve harfleri temsil eder.
            [^0-9]      : rakam olmayan değerleri temsil eder.
            [^a-z]      : küçük harf olmayan değerleri temsil eder.
            [^A-Z]      : büyük harf olmayan değerleri temsil eder.
            [^a-zA-Z]   : küçük ve büyük harf olmayan değerleri temsil eder.
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtDeger.Text, "[^0-9]"))
                {
                    throw new Exception("Lütfen sadece rakamsal değerler giriniz.");
                }

                int stokMiktari = Convert.ToInt32(txtDeger.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtDeger.Text, "[^A-Z-a-zöÖşŞıIİüÜğĞ ]"))
                {
                    throw new Exception("Lütfen alfabetik bir değerler giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            // E-posta kontrolü
            try
            {
                if (Regex.IsMatch(txtDeger.Text, @"^([\w\.\-]+)@([\w\-]+)\.(com|net|org|co|edu|biz|io)$"))
            {
                MessageBox.Show("E-posta adresi doğru.");
            }
            else
            {
                throw new Exception("E-posta adresi yanlış.");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
