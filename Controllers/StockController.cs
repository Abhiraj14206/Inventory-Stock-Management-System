using InventoryStockManagement.Data;
using InventoryStockManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace InventoryStockManagement.Controllers;
public class StockController : Controller
{
    private readonly AppDbContext _db;
    public StockController(AppDbContext db) => _db = db;
    public async Task<IActionResult> Index() => View(await _db.StockMovements.Include(m => m.Product)
        .OrderByDescending(m => m.CreatedAt).Take(200).ToListAsync());
    public async Task<IActionResult> Create()
    {
        ViewBag.ProductId = new SelectList(await _db.Products.OrderBy(p => p.Name).ToListAsync(), "Id", "Name");
        return View(new StockMovement());
    }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(StockMovement movement)
    {
        var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == movement.ProductId);
        if (product == null) ModelState.AddModelError(nameof(movement.ProductId), "Choose a valid product.");
        if (movement.Type != "IN" && movement.Type != "OUT")
            ModelState.AddModelError(nameof(movement.Type), "Choose stock in or stock out.");
        if (product != null && movement.Type == "OUT" && movement.Quantity > product.Quantity)
            ModelState.AddModelError(nameof(movement.Quantity), "Not enough stock available.");
        if (!ModelState.IsValid)
        {
            ViewBag.ProductId = new SelectList(await _db.Products.OrderBy(p => p.Name).ToListAsync(), "Id", "Name", movement.ProductId);
            return View(movement);
        }
        await using var tx = await _db.Database.BeginTransactionAsync();
        product!.Quantity += movement.Type == "IN" ? movement.Quantity : -movement.Quantity;
        movement.CreatedAt = DateTime.UtcNow;
        _db.StockMovements.Add(movement);
        await _db.SaveChangesAsync();
        await tx.CommitAsync();
        TempData["Success"] = "Stock movement recorded and quantity updated.";
        return RedirectToAction(nameof(Index));
    }
}
