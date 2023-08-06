using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

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

    public IActionResult Numbers()
    {
        List<int> MyNumbers = new List<int>(){1,2,3,4,5,6,7};
        return View(MyNumbers);
    }
    public IActionResult User()
    {
        User Ricky = new User()
        {
            FirstName = "Ricky",
            LastName = "Bobby"
        };
        User Timmy = new User()
        {
            FirstName = "Timmy",
            LastName = "Trumpet"
        };
        User Steve = new User()
        {
            FirstName = "Steve",
            LastName = "Aokie"
        };
        User Frank = new User()
        {
            FirstName = "Frank",
            LastName = "DaTank"
        };
        List<User> UsersList = new List<User>();
        UsersList.Add(Ricky);
        UsersList.Add(Timmy);
        UsersList.Add(Steve);
        UsersList.Add(Frank);
        return View(UsersList);
    }
    public IActionResult Users()
    {
        User Ricky = new User()
        {
            FirstName = "Ricky",
            LastName = "Bobby"
        };
        User Timmy = new User()
        {
            FirstName = "Timmy",
            LastName = "Trumpet"
        };
        User Steve = new User()
        {
            FirstName = "Steve",
            LastName = "Aokie"
        };
        User Frank = new User()
        {
            FirstName = "Frank",
            LastName = "DaTank"
        };
        List<User> UsersList = new List<User>();
        UsersList.Add(Ricky);
        UsersList.Add(Timmy);
        UsersList.Add(Steve);
        UsersList.Add(Frank);
        return View(UsersList);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
