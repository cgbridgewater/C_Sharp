using Microsoft.AspNetCore.Mvc;
namespace Portfolio_I.Controllers;   
public class HelloController : Controller
{ 

    [HttpGet("")]
    public ViewResult Index()
    {
        ViewBag.Example = "Hello World!";
        ViewBag.Name = "Chris Bridgewater";
        return View("Index");
    }
    

    [HttpGet("projects")]
    public ViewResult Projects()
    {
        ViewBag.Test = "TEST!";
        return View("Projects");
    }

    [HttpGet("contacts")]
    public ViewResult Contact()
    {
        ViewBag.FoodList = new List<string>() {"Apple Pie", "Pizza", "Cinnamon Rolls", "Lasagna", "Donuts", "Chocolate Cake", "Burritos"};
        return View("Contacts");
    }

    [HttpGet("csharp")]
    public ViewResult CSharp()
    {
        return View("CSharp");
    }

    [HttpGet("razorfun")]
    public ViewResult RazorFun()
    {
        return View("RazorFun");
    }

}