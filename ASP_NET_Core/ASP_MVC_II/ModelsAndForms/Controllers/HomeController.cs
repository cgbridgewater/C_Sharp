using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsAndForms.Models;

namespace ModelsAndForms.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("register")]
    public IActionResult ResultPage() // updated
    {    
        // process the form...
        // You can start by logging the data to the console
        // or using the debugger to inspect the HogwartsStudent instance!
        // Console.WriteLine(student.Name);
        // Console.WriteLine(student.House);
        // Console.WriteLine(student.CurrentYear);
        return View();
    } 

    public IActionResult Register(HogwartsStudent student)
    {

        return View(student);
    }

    public IActionResult HogwartsForm()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
