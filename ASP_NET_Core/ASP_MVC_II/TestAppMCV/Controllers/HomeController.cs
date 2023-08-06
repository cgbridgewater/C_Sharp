using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestAppMCV.Models;

namespace TestAppMCV.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Friend Ricky = new Friend()
        {
            FirstName = "Ricky",
            LastName = "Bobby"
        };
        Friend Timmy = new Friend()
        {
            FirstName = "Timmy",
            LastName = "Trumpet"
        };
        Friend Steve = new Friend()
        {
            FirstName = "Steve",
            LastName = "Aokie"
        };
        Friend Frank = new Friend()
        {
            FirstName = "Frank",
            LastName = "DaTank"
        };
        
        // List<string> names = new List<string>();
        // names.Add("Nick");
        // names.Add("Riley");
        // names.Add("James");
        // names.Add("Sara");
        
        List<Friend> MyFriends = new List<Friend>();
        MyFriends.Add(Ricky);
        MyFriends.Add(Timmy);
        MyFriends.Add(Steve);
        MyFriends.Add(Frank);
        return View(MyFriends);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult TestPage()
    {
        int MyNumber = 7;
        string MyWord = "Hello";
        return View("TestPage",MyNumber);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
