#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;
public class Dish
{
    [Key]

    public int DishId { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string Name { get; set; } 

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string Chef { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [Range(0,6, ErrorMessage="Must be between 1 and 5.")]  
    public int Tastiness { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [Range(0,5000000, ErrorMessage="Must be greater than 0.")]  
    public int? Calories { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}