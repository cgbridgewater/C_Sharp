#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PetTestProject.Models;

public class Pet
{
    [Key]
    public int PetId {get; set;}
    
    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string PetName {get; set;}

    [Required(ErrorMessage = "REQUIRED!")]   
    [MinLength(2, ErrorMessage="Must be at least 2 characters in length.")]  
    public string PetType {get; set;}

    [Required(ErrorMessage = "REQUIRED!")] 
    [Range(1,int.MaxValue)]
    public int PetAge {get; set;}

    [Required(ErrorMessage = "REQUIRED!")] 
    public bool HasFur {get; set;}
    public  DateTime CreatedAt {get; set;} = DateTime.Now;
    public  DateTime UpdatedAt {get; set;} = DateTime.Now;
}