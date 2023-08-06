using Microsoft.AspNetCore.Mvc;
namespace TestApp.Controllers;   
public class MainController : Controller
{ 

    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("formpage")]
    public ViewResult FormPage()
    {
        return View("FormPage");
    }

    [HttpPost("process")]
    public IActionResult ResultPage( string Name, string Location, string FavLanguage, string Comments )
    {
    Console.WriteLine($"name: {Name}");
    Console.WriteLine($"location: {Location}");
    Console.WriteLine($"Favorite Language: {FavLanguage}");
    Console.WriteLine($"Comments: {Comments}");
        ViewBag.name = Name;
        ViewBag.location = Location;
        ViewBag.favlanguage = FavLanguage;
        ViewBag.comments = Comments;
        return View("ResultPage");
    }

    [HttpGet("resultpage")]
    public RedirectToActionResult ResultPage()
        {
            return RedirectToAction("Index");
        }

    [HttpGet("here/{name}")]
    public ViewResult Here(string name)
    {        
        ViewBag.Name = name;
        return View();
    }  
    [HttpGet("redirect/{myName}")]
    public RedirectToActionResult GoSomewhere(string myName)
    {
        // In this case to pass a parameter we must make an anonymous object and pass a key/value
        // that matches the key to the expected parameter name on the other route
        return RedirectToAction("Here", new {name = myName});
    }

}