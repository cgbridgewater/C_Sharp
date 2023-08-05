using Microsoft.AspNetCore.Mvc;
namespace Portfolio_I.Controllers;   
public class HelloController : Controller
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