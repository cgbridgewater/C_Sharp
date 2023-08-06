using Microsoft.AspNetCore.Mvc;
namespace Countdown.Controllers;   
public class MainController : Controller
{ 

    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

}