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
    public partial class _12_KelimeOyunu1 : Form
    {
        public _12_KelimeOyunu1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OBJECT ORIENTED PROGRAMMING (OOP)
            //instance
            Button btn = new Button();
            btn.Text = "Merhaba";
            btn.Name = "btnMerhaba";
            btn.Size = new Size(250, 100);
            btn.Location = new Point(20, 100);
            btn.Click += btnMerhaba_Click;
            //this.Controls.Add(btn);
            grpButonlar.Controls.Add(btn);

        }

        private void btnMerhaba_Click(object? sender, EventArgs e)
        {

        }

        private void _12_KelimeOyunu1_Load(object sender, EventArgs e)
        {

        }
        string kelime;
        private void btnKelime_Click(object sender, EventArgs e)
        {
            //butona bastığımızda kelimenin harf sayısı kadar buton dinamik olarak oluşturularak grupbox'a eklenecek.
            grpButonlar.Controls.Clear();

            kelime = txtKelime.Text;
            //Her string aslında bir char dizisidir.
            //char deger = kelime[0];

            int kelimeUzunluk = kelime.Length;

            for (int i = 0; i < kelimeUzunluk; i++)
            {
                Button btn = new Button();
                btn.Text = "--";
                btn.Name = "btn" + i;
                btn.Tag = i;
                btn.Size = new Size(80, 80);
                btn.Location = new Point(90 + (i * 80), 80);
                btn.Click += Btn_Click;
                grpButonlar.Controls.Add(btn);
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            //Button btn1=(Button)sender;
            Button btn = sender as Button;
            byte kacinciHarf = Convert.ToByte(btn.Tag);
            btn.Text = kelime[kacinciHarf].ToString();
        }
    }
}
