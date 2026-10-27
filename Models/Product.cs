using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InventoryStockManagement.Models;
public class Product
{
    public int Id { get; set; }
    [Required, StringLength(120)]
    [Display(Name = "Product name")]
    public string Name { get; set; } = "";
    [Required, StringLength(40)]
    public string SKU { get; set; } = "";
    [Range(0.01, 99999999)]
    [Column(TypeName = "decimal(10,2)")]
    public decimal UnitPrice { get; set; }
    [Range(0, 1000000)]
    public int Quantity { get; set; }
    [Range(0, 1000000)]
    [Display(Name = "Minimum stock")]
    public int MinimumStock { get; set; } = 5;
    [Required]
    [Display(Name = "Category")]
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [NotMapped]
    public bool IsLowStock => Quantity <= MinimumStock;
}
