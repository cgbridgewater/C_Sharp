using Microsoft.AspNetCore.Mvc;
namespace Portfolio_I.Controllers;   
public class HelloController : Controller
{ 

    [HttpGet("")]
    public string Index()
    {
        return "This is my index!";
    }

    [HttpGet("projects")]
    public string Projects()
    {
        return "These are my projects";
    }

    [HttpGet("Contact")]
    public string Contact()
    {
        return "This is my contact!";
    }

}