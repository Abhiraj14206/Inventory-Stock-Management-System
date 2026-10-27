using InventoryStockManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace InventoryStockManagement.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<StockMovement> StockMovements => Set<StockMovement>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasIndex(p => p.SKU).IsUnique();
        modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<StockMovement>().HasOne(m => m.Product).WithMany()
            .HasForeignKey(m => m.ProductId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Stationery" },
            new Category { Id = 3, Name = "Accessories" }
        );
    }
}
