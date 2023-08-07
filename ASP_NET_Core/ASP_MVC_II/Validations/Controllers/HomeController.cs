using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Validations.Models;

namespace Validations.Controllers;

public class HomeController : Controller
{
    static User user;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("results")]
    public IActionResult Results()
    {
        return View(user);
    }

    [HttpPost("register")]
    public IActionResult Register(User newUser)
    {
        user = newUser;
        return RedirectToAction("Results");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
