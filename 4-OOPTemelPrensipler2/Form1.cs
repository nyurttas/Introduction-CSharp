using _4_OOPTemelPrensipler2.Entities;

namespace _4_OOPTemelPrensipler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Aciklama
            //CepTelefonu c = new CepTelefonu();
            //Gomlek g = new Gomlek();

            //Kalýtým yolu ile oluþturulduklarýndan dolayý Gomlek ve CepTelefonu nesneleri aslýnda ayný zamanda birer Urun nesnesidir.

            //Urun urun = new Gomlek();
            //Urun urun1= new CepTelefonu();
            #endregion

            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            cmbKategoriler.Items.AddRange(new string[] { "Gömlek", "Cep Telefonu" });
        }

        int secilenKategori;
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKategori = cmbKategoriler.SelectedIndex;
        }

        Sepet sepetim = new Sepet();

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {

            if (secilenKategori == 0)
            {
                //gomlek
                Gomlek gomlek = new Gomlek()
                {
                    Description = "Yeni sezon",
                    Material = "Pamuk",
                    UnitPrice = 6000,
                    ProductName = txtUrunAdi.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    Size = "XL"
                };

                sepetim.SepeteUrunEkle(gomlek);
            }
            else
            {
                //cep telefonu
                CepTelefonu telefon = new CepTelefonu()
                {
                    ProductName = txtUrunAdi.Text,
                    BatteryLife = 5,
                    Description = "Yeni teknoloji bir ürün",
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    RamCapacity = 64,
                    UnitPrice = 56000
                };
                sepetim.SepeteUrunEkle(telefon);
            }
            ListeyiGuncelle();
        }

        private void ListeyiGuncelle()
        {
            lstSepet.Items.Clear();

            //foreach (var item in sepetim.TumUrunleriListele())
            //{
            //    lstSepet.Items.Add(item);
            //}

            //lambda expression => (öyleki)
            sepetim.TumUrunleriListele()?.ForEach(x => lstSepet.Items.Add(x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gomlek g = new Gomlek();
            g.UnitPrice = 1000;
            MessageBox.Show(g.Tax().ToString());

            CepTelefonu c = new CepTelefonu();
            c.UnitPrice = 2000;
            MessageBox.Show(c.Tax().ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedIndex!=-1)
            {
                //secilen ürünü silelim.
                sepetim.SepettenUrunCikar(secilenUrun);
                ListeyiGuncelle();
            }
        }

        Urun? secilenUrun;
        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenUrun = (Urun?)lstSepet.SelectedItem;
        }
    }
}
