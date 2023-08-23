#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PartialsDemo.Models;
public class User
{
    [Key]

    public int UserId { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string Username { get; set; } 

    [Required(ErrorMessage = "REQUIRED!")]
    [Range(0,120, ErrorMessage="Must be greater than 0.")]  
    public int Age { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}