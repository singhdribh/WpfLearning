using Microsoft.EntityFrameworkCore;
using SimpleTrader.Domain.Models;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(x => x.Stock);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=SimpleTraderDb;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
