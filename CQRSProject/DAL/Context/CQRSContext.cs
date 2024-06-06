using CQRSProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.DAL.Context
{
    public class CQRSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EGD\\SQLEXPRESS;initial catalog=CQRSDb;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
