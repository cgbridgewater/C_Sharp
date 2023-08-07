#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidations.Models;

public class UserSurvey
{
    [Required(ErrorMessage = "REQUIRED!")]
    [MinLength(3, ErrorMessage = "Must be at least 3 characters!")]
    public string Name {get; set;}

    [Required(ErrorMessage = "REQUIRED!")]
    [MinLength(2, ErrorMessage = "Must be at least 2 characters!")]
    public string Language {get; set;}

    [Required(ErrorMessage = "REQUIRED!")]
    [MinLength(3, ErrorMessage = "Must be at least 3 characters!")]
    public string Location {get; set;}

    [MinLength(20, ErrorMessage = "Must be at least 20 characters!")]
    public string Comments {get; set;}
}