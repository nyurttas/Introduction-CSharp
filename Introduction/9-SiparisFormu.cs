using System.Collections;

namespace Introduction
{
    public partial class _9_SiparisFormu : Form
    {
        public _9_SiparisFormu()
        {
            InitializeComponent();
        }

        private void _9_SiparisFormu_Load(object sender, EventArgs e)
        {
            //ComboboxGetNames();
            ComboboxGetValues();
            UrunleriOlustur();
        }

        string[,] urunListesi = new string[3, 2];

        private void UrunleriOlustur()
        {
            urunListesi[0, 0] = "1";
            urunListesi[0, 1] = "HP Laptop";

            urunListesi[1, 0] = "1";
            urunListesi[1, 1] = "Iphone Pro Max";

            urunListesi[2, 0] = "2";
            urunListesi[2, 1] = "Bahçe Oturma Grubu";

        }

        private void ComboboxGetValues()
        {
            Array dizi = Enum.GetValues(typeof(Kategoriler));

            foreach (var item in dizi)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void ComboboxGetNames()
        {
            //GetNames metodunu kullanarak eumeration listesindeki elemanları alıp combobox'a ekleyebiliriz.
            string[] tumKategoriler = Enum.GetNames(typeof(Kategoriler));
            foreach (var item in tumKategoriler)
            {
                cmbKategori.Items.Add(item);
            }
        }

        byte secilen;
        string secilenUrun;
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //secilen bir şey varsa
            if (cmbKategori.SelectedIndex != -1)
            {
                secilen = (byte)cmbKategori.SelectedItem;
                UrunleriListeyeDoldur(secilen);
            }


        }

        private void UrunleriListeyeDoldur(byte secilen)
        {
            lstUrunListesi.Items.Clear();

            int satirSayisi = urunListesi.GetLength(0); //3
            int sutunSayisi = urunListesi.GetLength(1); //2

            for (int i = 0; i < satirSayisi; i++)
            {
                if (urunListesi[i, 0] == secilen.ToString())
                {
                    lstUrunListesi.Items.Add(urunListesi[i, 1]);
                }
            }
        }

        decimal sonuc;
        private void txtBirimFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstUrunListesi.SelectedIndex != -1 && nmrAdet.Value != 0 && !string.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    sonuc = nmrAdet.Value * Convert.ToDecimal(txtBirimFiyat.Text);
                    txtToplamTutar.Text = sonuc.ToString();
                }
            }
        }

        decimal kdvliTutar;
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioControl())
                {
                    bool hangiFatura = rdBireysel.Checked ? true : false;

                    if (hangiFatura)
                    {
                        //bireysel
                        kdvliTutar = sonuc * 1.18m;
                    }
                    else
                    {
                        //kurumsal
                        kdvliTutar = sonuc * 1.20m;
                    }

                    ListeyeEkle();

                }
                else
                {
                    throw new Exception("Fatura tipi seçmeniz gerekmektedir.!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ArrayList, System.Collections ad alanında(namespace) bulunan bir sınıftır. ArrayList sınıfı, boyutu dinamik olarak genişleyebilen bir dizi oluşturur. İçerisine her türden veri ekleyebiliriz.Çünkü verileri object türünde tutar.

        ArrayList toplamTutarlar = new ArrayList();
        private void ListeyeEkle()
        {
            lstSepet.Items.Add($"{secilenUrun}-{nmrAdet.Value}-{txtBirimFiyat.Text}-{kdvliTutar}");
            toplamTutarlar.Add(kdvliTutar);
            lblSepetToplami.Text = ToplamTutarGuncelle().ToString();
        }

        private decimal ToplamTutarGuncelle()
        {
            decimal toplam = 0;
            foreach (var item in toplamTutarlar)
            {
                toplam = toplam + Convert.ToDecimal(item);
            }
            return toplam;
        }

        private bool RadioControl()
        {
            //is anahtar kelimesi ile bir nesnenin bir türden olup olmadığını kontrol edebiliriz. Eğer nesne belirtilen türe ait ise is operatörü true döner.

            //as anahtar kelimesi ile bir nesnenin bir türe dönüştürülüp dönüştürülemeyeceğini kontrol edebiliriz. Eğer dönüşüm başarılı olursa as operatörü nesneyi dönüştürür, başarısız olursa null döner.

            foreach (var item in grpFaturaTipi.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton? rd = item as RadioButton;
                    //RadioButton rd2 = (RadioButton)item;
                    if (rd.Checked)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void lstUrunListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenUrun = lstUrunListesi.SelectedItem.ToString();
        }
    }
}