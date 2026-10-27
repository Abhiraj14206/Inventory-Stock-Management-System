using System.ComponentModel.DataAnnotations;
namespace InventoryStockManagement.Models;
public class Category
{
    public int Id { get; set; }
    [Required, StringLength(80)]
    public string Name { get; set; } = "";
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
