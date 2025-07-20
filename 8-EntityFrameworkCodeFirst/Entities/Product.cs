namespace _8_EntityFrameworkCodeFirst.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryID { get; set; }
        public string? Description { get; set; }
        public Category? Category { get; set; }
        //public List<Order>? Orders { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
