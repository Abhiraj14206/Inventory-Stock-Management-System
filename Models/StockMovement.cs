using System.ComponentModel.DataAnnotations;
namespace InventoryStockManagement.Models;
public class StockMovement
{
    public int Id { get; set; }
    [Required, StringLength(20)]
    public string Type { get; set; } = ""; // IN or OUT
    [Required]
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    [Range(1, 1000000)]
    public int Quantity { get; set; }
    [StringLength(250)]
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
