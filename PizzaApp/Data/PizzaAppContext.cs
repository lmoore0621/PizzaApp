using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Data
{
    public class PizzaAppContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=WIN-A9PGGCOIFI4;Initial Catalog=PizzaApp;Integrated Security=True;TrustServerCertificate=true");
        }
    }
}