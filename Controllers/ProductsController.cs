using InventoryStockManagement.Data;
using InventoryStockManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace InventoryStockManagement.Controllers;
public class ProductsController : Controller
{
    private readonly AppDbContext _db;
    public ProductsController(AppDbContext db) => _db = db;
    public async Task<IActionResult> Index(string? search)
    {
        ViewBag.Search = search;
        var q = _db.Products.Include(p => p.Category).AsQueryable();
        if (!string.IsNullOrWhiteSpace(search))
            q = q.Where(p => p.Name.Contains(search) || p.SKU.Contains(search));
        return View(await q.OrderBy(p => p.Name).ToListAsync());
    }
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();
        var p = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
        return p == null ? NotFound() : View(p);
    }
    public async Task<IActionResult> Create()
    {
        await LoadCategories(); return View(new Product());
    }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Product product)
    {
        if (await _db.Products.AnyAsync(p => p.SKU == product.SKU))
            ModelState.AddModelError(nameof(product.SKU), "SKU already exists.");
        if (!await _db.Categories.AnyAsync(c => c.Id == product.CategoryId))
            ModelState.AddModelError(nameof(product.CategoryId), "Choose a valid category.");
        if (!ModelState.IsValid) { await LoadCategories(product.CategoryId); return View(product); }
        product.CreatedAt = DateTime.UtcNow;
        _db.Products.Add(product);
        await _db.SaveChangesAsync();
        TempData["Success"] = "Product created successfully.";
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();
        var product = await _db.Products.FindAsync(id);
        if (product == null) return NotFound();
        await LoadCategories(product.CategoryId); return View(product);
    }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Product product)
    {
        if (id != product.Id) return NotFound();
        if (await _db.Products.AnyAsync(p => p.SKU == product.SKU && p.Id != id))
            ModelState.AddModelError(nameof(product.SKU), "SKU already exists.");
        if (!ModelState.IsValid) { await LoadCategories(product.CategoryId); return View(product); }
        var existing = await _db.Products.FindAsync(id);
        if (existing == null) return NotFound();
        existing.Name = product.Name; existing.SKU = product.SKU;
        existing.UnitPrice = product.UnitPrice; existing.Quantity = product.Quantity;
        existing.MinimumStock = product.MinimumStock; existing.CategoryId = product.CategoryId;
        await _db.SaveChangesAsync();
        TempData["Success"] = "Product updated.";
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();
        var p = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
        return p == null ? NotFound() : View(p);
    }
    [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var p = await _db.Products.FindAsync(id);
        if (p == null) return NotFound();
        if (await _db.StockMovements.AnyAsync(m => m.ProductId == id))
        {
            TempData["Error"] = "This product has stock history and cannot be deleted.";
            return RedirectToAction(nameof(Index));
        }
        _db.Products.Remove(p); await _db.SaveChangesAsync();
        TempData["Success"] = "Product deleted.";
        return RedirectToAction(nameof(Index));
    }
    private async Task LoadCategories(int? selected = null) =>
        ViewBag.CategoryId = new SelectList(await _db.Categories.OrderBy(c => c.Name).ToListAsync(), "Id", "Name", selected);
}
