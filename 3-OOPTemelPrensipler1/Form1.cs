using _3_OOPTemelPrensipler1.Entities;

namespace _3_OOPTemelPrensipler1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string? urunAdi = "Iphone 15 Pro Max";
            //double birimFiyati = 98500.54;
            //int stokMiktari = 100;
            //int urunID = 1;

            //string productName = "Rode Mikrofon";
            //int unitPrice = 15000;
            //byte unitsInStock = 211;
            //string productID = "4";

            Product p = new Product()
            {
                ProductName = "Dell Laptop",
                Description = "G�zel bir laptop.",
                ProductID = 4,
                UnitsInStock = 68,
                UnitPrice = 79568
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product urun = new Product();
            urun.ProductID = 1;
            urun.ProductName = "Rode Mikrofon";
            urun.UnitPrice = 5600;
            urun.Description = "G�zel bir mikrofon.";
            urun.UnitsInStock = 450;

            urun.SellProduct(1);
            urun.DeleteProduct(3);

            //get
            MessageBox.Show(urun.ProductName);

            //set
            urun.ProductName = "Rode Masa�st� Mikrofon";

            MessageBox.Show(urun.ProductName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Uygulama i�erisinde bir m��teri yap�l�rken mutlaka CompanyName ve Country bilgileri girilerek yap�ls�n.

            Customer musteri = new Customer("Ar�elik", "T�rkiye");
            musteri.IsActive = true;

            Customer musteri1 = new Customer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order od = new Order(3, 5);
        }
    }
}
