namespace _3_OOPTemelPrensipler1.Entities
{
    //public    : Access Modifiers (Erişim Belirleyici)
    public class Product
    {
        //field (alan)
        private int _deger;

        //property (özellik)
        public int ProductID { get; set; }
        //? : ProductName property'sinin null olmasına izin verildiği anlamına gelir.
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }

        //methods (metodlar)
        public void SellProduct(int id)
        {

        }
        public void DeleteProduct(int id)
        {

        }
    }
}