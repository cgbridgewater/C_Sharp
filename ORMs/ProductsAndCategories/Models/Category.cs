#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;
public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]
    [Display(Name = "Name:")]

    public string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Association> Prod { get; set; } = new List<Association>();
}