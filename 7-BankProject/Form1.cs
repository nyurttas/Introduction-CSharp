using _7_BankProject.Entities;

namespace _7_BankProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Description
            /*
             Hesap A��l�� ��lemleri
            Otomatik olarak bir hesap numaras� olu�turulmas� gerekmektedir.
            Hesap a��l�s� yap�l�rken mutlaka hesap sahibinin ad� soyad� ve ilk bakiye girilmelidir.

            Hesaba para yat�rabilmeliyim:
            Para yat�r�rken 0 dan b�y�k bir de�er olmas� sa�lanmal�d�r.

            Hesaptan para �ekebilmeliyim:
            �ekilecek tutar 0 dan b�y�k olmal�
            Hesap bakiyemin de yeterli olmas� gerekmektedir.

            Hesap T�rleri:

            InterestEarningAccount (Faiz Getiri Hesab�)
                E�er mevcut bakiye 500$ dan fazla ise ay sonu %5 faiz getirisi sa�lar. 

            LineOfCreditAccount (Kredi Limit Hesab�)
                Eksi bakiyeye d��ebilir.
                Ancak eksi bakiye s�z konusu ise her ay sonu %7 faiz gideri uygulanacakt�r.

            GiftCardAccout(Hediye Kart� Hesab�)
                Her ay sonu istenirse bir miktar para yat�rma i�lemi yap�labilir.
             */
            #endregion
            GetAllEnums();
            txtAySonuBakiye.Visible = false;
            lblAySonu.Visible = false;
        }

        private void GetAllEnums()
        {
            var islemTurleri = Enum.GetValues(typeof(IslemTurleri));

            foreach (var item in islemTurleri)
            {
                cmbIslemTuru.Items.Add(item);
            }

            var hesapTurleri = Enum.GetValues(typeof(HesapTurleri));

            foreach (var item in hesapTurleri)
            {
                cmbHesapTuru.Items.Add(item);
            }
        }

        private void lblSonBakiye_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        BankAccount? account;
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            try
            {
                string owner = txtAdSoyad.Text;
                decimal initialBalance = Convert.ToDecimal(txtIlkBakiye.Text);

                if (hesapTuru == HesapTurleri.Interest_Earning_Account)
                {
                    account = new InterestEarningAccount(owner, initialBalance);
                }
                else if (hesapTuru == HesapTurleri.LineOf_Credit_Account)
                {
                    account = new LineOfCreditAccount(owner, initialBalance);
                }
                else
                {
                    account = new GiftCardAccount(owner, initialBalance);
                }

                txtHesapNo.Text = account.Number?.ToString();
                GetHistory();
                MessageBox.Show("Hesap Ba�ar�l� Bir �ekilde A��lm��t�r.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetHistory()
        {
            lblHesapHareketleri.Text = account?.GetAccountHistory();
            lblSonBakiye.Text = $"{account?.Balance.ToString("N2")} TL";
        }

        HesapTurleri? hesapTuru;
        private void cmbHesapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesapTuru = (HesapTurleri?)cmbHesapTuru.SelectedItem;

            //if (hesapTuru==HesapTurleri.Gift_Card_Account)
            //{
            //    lblAySonu.Visible = true;
            //    txtAySonuBakiye.Visible = true;
            //}
            //else
            //{
            //    lblAySonu.Visible = false;
            //    txtAySonuBakiye.Visible = false;
            //}

            bool durum = hesapTuru == HesapTurleri.Gift_Card_Account ? true : false;
            lblAySonu.Visible = durum;
            txtAySonuBakiye.Visible = durum;
        }

        IslemTurleri? islemTuru;
        private void cmbIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            islemTuru = (IslemTurleri?)cmbIslemTuru.SelectedItem;
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            try
            {
                string not = txtNot.Text;
                decimal amount = Convert.ToDecimal(txtTutar.Text);

                if (islemTuru==IslemTurleri.Para_Cekme)
                {
                    account?.MakeWithDrawal(amount, DateTime.Now, not);
                }
                else
                {
                    account?.MakeDeposit(amount, DateTime.Now, not);
                }

                GetHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
