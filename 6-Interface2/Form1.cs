using _6_Interface2.Entities;

namespace _6_Interface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            GarantiBankasi g = new GarantiBankasi();
            g.BankID = 1;
            g.BankName = "Garanti Bankasý";

            ZiraatBankasi z = new ZiraatBankasi();
            z.BankID = 2;
            z.BankName = "Ziraat Bankasý";

            BankRepository bankRepo = new BankRepository(g);
            MessageBox.Show(bankRepo.Ekle());
            BankRepository bankRepo1 = new BankRepository(z);
            MessageBox.Show(bankRepo1.Ekle());

        }
    }
}
