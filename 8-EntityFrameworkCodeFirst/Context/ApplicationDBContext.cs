using _8_EntityFrameworkCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EntityFrameworkCodeFirst.Context
{
    public class ApplicationDBContext : DbContext
    {
        //Tabloları belirliyoruz:
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //Veritabanı Bağlantısını Set Edelim:
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YMYP7CodeFirstTestDB;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Veritabanı modeli oluşturulurken müdehale edebiliriz:
            //Burada OrderDetail tablosu üzerinde bulunan OrderID ve ProductID alanları birlikte primary key yapıldı.(composite key)
            modelBuilder.Entity<OrderDetail>()
                .HasKey(o => new {o.OrderID,o.ProductID });
        }
    }
}
