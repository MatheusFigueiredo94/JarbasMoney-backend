using JarbasMoney.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JarbasMoney.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().ToTable("Stocks");
            modelBuilder.Entity<Stock>().Property(x => x.Id);
            modelBuilder.Entity<Stock>().Property(x => x.StockCode).HasMaxLength(120).HasColumnType("varchar(120)");
            modelBuilder.Entity<Stock>().HasIndex(b => b.StockCode);
        }
    }
}
