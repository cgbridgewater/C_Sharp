#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Session_WorkShop.Models;

public class User
{
    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string Name {get;set;}
}