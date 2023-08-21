#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PetTestProject.Models;
public class Pet
{
    [Key]
    public int PetId {get; set;}
    public string PetName {get; set;}
    public string PetType {get; set;}
    public int PetAge {get; set;}
    public bool HasFur {get; set;}
    public  DateTime CreatedAt {get; set;} = DateTime.Now;
    public  DateTime UpdatedAt {get; set;} = DateTime.Now;
}