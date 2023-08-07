#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Validations.Models;

public class User
{
    // Each property in a model gets its own set of DataAnnotations
    // Each annotation applies only to the property that is directly below it
    [Required(ErrorMessage = "REQUIRED!")]   
    // We can stack annotations to apply multiple requirements to one property
    // In this case, a Name is required but must also be at least 2 characters long 
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]   
    public string Name {get;set;}
    
    // Notice how we must use [Required] again here to apply to the next property
    [Required(ErrorMessage = "REQUIRED!")]   
    // This will apply a standard Email format regex to this property 
    [EmailAddress] 
    public string Email {get;set;}
    
    [Required(ErrorMessage = "REQUIRED!")]   
    // You will see what the [DataType] annotation does when we get over to making our form
    [DataType(DataType.Password)]    
    public string Password {get;set;}
}