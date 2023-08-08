#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Validations.Models;
// DateTime CurrentTime = DateTime.Now;
// DateTime now = DateTime.Now;
// Save today's date.


public class User
{
    // Each property in a model gets its own set of DataAnnotations
    // Each annotation applies only to the property that is directly below it
    [Required(ErrorMessage = "REQUIRED!")]   
    // We can stack annotations to apply multiple requirements to one property
    // In this case, a Name is required but must also be at least 2 characters long 
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    // [NoZNames] 
    public string Name {get;set;}
    
    // Notice how we must use [Required] again here to apply to the next property
    [Required(ErrorMessage = "REQUIRED!")]   
    // This will apply a standard Email format regex to this property 
    [EmailAddress] 
    public string Email {get;set;}
    
    [Required(ErrorMessage = "REQUIRED!")]   
    // You will see what the [DataType] annotation does when we get over to making our form
    [DataType(DataType.Password)]    
    [MinLength(8, ErrorMessage="Must be at least 8 characters in length.")]   
    public string Password {get;set;}

    [Required(ErrorMessage = "REQUIRED!")]  
    [DataType(DataType.Date)]
    [ValidateDate]
    public DateTime Birthday {get;set;}


    [IsOdd]
    public int OddNumber {get;set;}
}

public class ValidateDateAttribute : ValidationAttribute
{
protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        DateTime CurrentTime = DateTime.Now;
        string date = CurrentTime.ToString("yyyy-MM-dd");
        DateTime eighteen = CurrentTime.AddYears(-18);

        if ((DateTime)value > eighteen)
        {
            return new ValidationResult("You must be 18 or older to register!");
        } 
        
        else {
            return ValidationResult.Success;
        }
    }
}


public class IsOddAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if ((int)value % 2 == 0 || (int)value == 0)
        {
            return new ValidationResult("Your number must be odd");
        } else {
            return ValidationResult.Success;
        }
    }
}

// // // validator to prevent "Zach" from signing up
// public class NoZNamesAttribute : ValidationAttribute
// {
//   protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//     {
//         if (((string)value).ToLower()[0] == 'z')
//         {
//             return new ValidationResult("No names starting with Z allowed! This means you Zach!!");
//         } else {
//             return ValidationResult.Success;
//         }
//     }
// }