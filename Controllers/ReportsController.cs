using InventoryStockManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace InventoryStockManagement.Controllers;
public class ReportsController : Controller
{
    private readonly AppDbContext _db;
    public ReportsController(AppDbContext db) => _db = db;
    public async Task<IActionResult> Index()
    {
        ViewBag.TotalProducts = await _db.Products.CountAsync();
        ViewBag.TotalUnits = await _db.Products.SumAsync(p => (int?)p.Quantity) ?? 0;
        ViewBag.LowStock = await _db.Products.CountAsync(p => p.Quantity <= p.MinimumStock);
        ViewBag.InventoryValue = await _db.Products.SumAsync(p => (decimal?)(p.Quantity * p.UnitPrice)) ?? 0m;
        return View(await _db.Products.Include(p => p.Category).OrderBy(p => p.Name).ToListAsync());
    }
}
