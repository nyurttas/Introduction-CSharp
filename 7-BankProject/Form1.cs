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
             Hesap Açýlýþ Ýþlemleri
            Otomatik olarak bir hesap numarasý oluþturulmasý gerekmektedir.
            Hesap açýlýsý yapýlýrken mutlaka hesap sahibinin adý soyadý ve ilk bakiye girilmelidir.

            Hesaba para yatýrabilmeliyim:
            Para yatýrýrken 0 dan büyük bir deðer olmasý saðlanmalýdýr.

            Hesaptan para çekebilmeliyim:
            Çekilecek tutar 0 dan büyük olmalý
            Hesap bakiyemin de yeterli olmasý gerekmektedir.

            Hesap Türleri:

            InterestEarningAccount (Faiz Getiri Hesabý)
                Eðer mevcut bakiye 500$ dan fazla ise ay sonu %5 faiz getirisi saðlar. 

            LineOfCreditAccount (Kredi Limit Hesabý)
                Eksi bakiyeye düþebilir.
                Ancak eksi bakiye söz konusu ise her ay sonu %7 faiz gideri uygulanacaktýr.

            GiftCardAccout(Hediye Kartý Hesabý)
                Her ay sonu istenirse bir miktar para yatýrma iþlemi yapýlabilir.
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
                MessageBox.Show("Hesap Baþarýlý Bir Þekilde Açýlmýþtýr.");
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
