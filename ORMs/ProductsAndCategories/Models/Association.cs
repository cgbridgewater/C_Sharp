#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;
public class Association

{
    [Key]
    public int AssociationId { get; set; }
    public int Product { get; set; }
    public int Category { get; set; }
    public Product? Products { get; set; }
    public Category? Categories { get; set; }
}