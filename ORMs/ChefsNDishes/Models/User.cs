#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;
public class User
{
    [Key]

    public int UserId { get; set; }

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    [Display(Name = "First Name: ")]
    public string FirstName { get; set; } 

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    [Display(Name = "Last Name: ")]
    public string LastName { get; set; } 


    [Required(ErrorMessage = "REQUIRED!")]  
    [DataType(DataType.Date)]
    [ValidateDate]
    [Display(Name = "Birthdate: ")]
    public DateTime Age {get;set;}


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // Our navigation property to track the many Posts our user has made
    // Be sure to include the part about instantiating a new List!
    public List<Dish> AllDishes { get; set; } = new List<Dish>();
}





public class ValidateDateAttribute : ValidationAttribute
{
protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        DateTime CurrentTime = DateTime.Now;
        string date = CurrentTime.ToString("yyyy-MM-dd");
        DateTime eighteen = CurrentTime.AddYears(-18);

            Console.WriteLine(value);
        if ((DateTime)value > eighteen)
        {
            return new ValidationResult("You must be 18 or older to register!");
        } 
        
        else {
            return ValidationResult.Success;
        }

    }
}