#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace weddingPlanner.Models;

public class Wedding
{
    [Key]
    public int WeddingId {get; set;}
    
    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    [Display(Name = "Bride Name:")]
    public string Bride {get; set;}
    
    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    [Display(Name = "Groom Name:")]
    public string Groom {get; set;}

    [Required(ErrorMessage = "REQUIRED!")]  
    [DataType(DataType.Date)]
    [ValidateDate] 
    [Display(Name = "Event Date:")]
    public string Date {get; set;}

    [Required(ErrorMessage = "REQUIRED!")] 
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")] 
    [Display(Name = "Event Address:")]
    public int Address {get; set;}

    public  DateTime CreatedAt {get; set;} = DateTime.Now;
    public  DateTime UpdatedAt {get; set;} = DateTime.Now;
}

public class ValidateDateAttribute : ValidationAttribute
{
protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        DateTime currentTime = DateTime.Now;
        if ((DateTime)value < currentTime)
        {
            return new ValidationResult("Date must be in future!");
        } 
        else {
            return ValidationResult.Success;
        }
    }
}