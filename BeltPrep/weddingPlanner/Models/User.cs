#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace weddingPlanner.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [UniqueEmail]
    [Display(Name = "Email")]    
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    [Display(Name = "Password")]
    public string Password { get; set; }

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    [NotMapped]
    [Compare("Password")]
    [Display(Name = "Confirm Password")]
    public string PasswordConfirm { get; set; }

    // 1:m join
    public List<Wedding> AllWeddings { get; set; } = new List<Wedding>();
    // n:m join
    public List<Rsvp> Rsvps { get; set; } = new List<Rsvp>();
}


public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value == null)
        {
            return new ValidationResult("Email is required!");
        }
        MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
        if(_context.Users.Any(e => e.Email == value.ToString()))
        {
            return new ValidationResult("Email must be unique!");
        } else {
            return ValidationResult.Success;
        }
    }
}