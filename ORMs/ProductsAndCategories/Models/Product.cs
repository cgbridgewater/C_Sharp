#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;
public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]
    [Display(Name = "Name:")]
    public string Name { get; set; }

    [Required]
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]
    [Display(Name = "Description:")]
    public string Description { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    [Display(Name = "Price:")]
    public double Price { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Association> Cats { get; set; } = new List<Association>();
}
