#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;
public class Dish
{
    [Key]

    public int DishId { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string DishName { get; set; } 

    public int Tastiness { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [Range(0,5000000, ErrorMessage="Must be greater than 0.")]  
    public int? Calories { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int? UserId { get; set; }
    // Our navigation property to track which User made this Post
    // It is VERY important to include the ? on the datatype or this won't work!
    public User? Chef { get; set; }
}