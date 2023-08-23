#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PartialsDemo.Models;
public class Product
{
    [Key]

    public int ProductId { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string ProductName { get; set; } 

    [Required(ErrorMessage = "REQUIRED!")]
    [Range(0,5000000, ErrorMessage="Must be greater than 0.")]  
    public double? Price { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}