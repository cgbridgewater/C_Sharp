#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace OneToMany.Models;
public class LoginUser
{
    // No other fields!
    [Required]    
    [EmailAddress]
    [Display(Name = "Email")]
    public string LEmail { get; set; }  

    [Required]    
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LPassword { get; set; } 
}