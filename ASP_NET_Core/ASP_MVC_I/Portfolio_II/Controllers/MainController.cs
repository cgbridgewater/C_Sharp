using Microsoft.AspNetCore.Mvc;
namespace Portfolio_II.Controllers;   
public class MainController : Controller
{ 

    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
    

    [HttpGet("projects")]
    public ViewResult Projects()
    {
        return View("Projects");
    }

    [HttpGet("contacts")]
    public ViewResult Contact()
    {
        return View("Contact");
    }

}