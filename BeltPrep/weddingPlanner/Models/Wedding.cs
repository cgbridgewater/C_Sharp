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
    public DateTime EventDate {get; set;}

    [Required(ErrorMessage = "REQUIRED!")] 
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")] 
    [Display(Name = "Event Address:")]
    public string Address {get; set;}

    public  DateTime CreatedAt {get; set;} = DateTime.Now;
    public  DateTime UpdatedAt {get; set;} = DateTime.Now;

    // 1:many join 
    public int UserId { get; set; }
    public User? Creator { get; set; }
    // n:m join
    public List<Rsvp> Guests { get; set; } = new List<Rsvp>();
}




public class ValidateDateAttribute : ValidationAttribute
{
protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
            DateTime CurrentTime = DateTime.Now;
        if ((DateTime)value < CurrentTime)
        {
            return new ValidationResult("Date must be in future!");
        } 
        else {
            return ValidationResult.Success;
        }
    }
}

