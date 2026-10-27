using InventoryStockManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace InventoryStockManagement.Controllers;
public class DashboardController : Controller
{
    private readonly AppDbContext _db;
    public DashboardController(AppDbContext db) => _db = db;
    public async Task<IActionResult> Index()
    {
        ViewBag.ProductCount = await _db.Products.CountAsync();
        ViewBag.TotalUnits = await _db.Products.SumAsync(p => (int?)p.Quantity) ?? 0;
        ViewBag.LowStockCount = await _db.Products.CountAsync(p => p.Quantity <= p.MinimumStock);
        ViewBag.StockValue = await _db.Products.SumAsync(p => (decimal?)(p.Quantity * p.UnitPrice)) ?? 0m;
        ViewBag.RecentMovements = await _db.StockMovements.Include(m => m.Product)
            .OrderByDescending(m => m.CreatedAt).Take(6).ToListAsync();
        ViewBag.LowStockProducts = await _db.Products.Include(p => p.Category)
            .Where(p => p.Quantity <= p.MinimumStock).OrderBy(p => p.Quantity).Take(8).ToListAsync();
        return View();
    }
}
