using App.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace App.DAL
{
    public class MyApplicationContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MyApplicationContext(DbContextOptions<MyApplicationContext> options) : base(options) { }
    }
}
