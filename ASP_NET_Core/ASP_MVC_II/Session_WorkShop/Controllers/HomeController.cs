using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Session_WorkShop.Models;

namespace Session_WorkShop.Controllers;

public class HomeController : Controller
{
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

    [HttpPost("")]  // leave this blank, to prevent showing a url for your 'action path'
    public IActionResult Create(User newUser)  // set up an instance of a new "User"
    {
        if(ModelState.IsValid)
        {
        HttpContext.Session.SetString("UserName", newUser.Name); // set session string call in render side -> <h4>My session user's name is: @Context.Session.GetString("UserName")</h4>
        HttpContext.Session.SetInt32("Digit", 22); // set session digit call in render side--> <h4>My session user's name is: @Context.Session.GetInt32("Digit")</h4>
            // user=newUser;  // pass that variable up to the static holder
            return RedirectToAction("Results");
        }
        else
        {
            return View("Index");
        }
    }

    [HttpGet("results")]
    public IActionResult Results()
    {
        // string UserName = HttpContext.Session.GetString("UserName");
            if (HttpContext.Session.GetString("UserName") != null)
                {
                    int? IntVariable = HttpContext.Session.GetInt32("UserAge");
                    return View(); // Render the view with the variable data from the Model
                }
                else{
                    return RedirectToAction("ClearSession");
                }
    }

    [HttpPost("update")]  // leave this blank, to prevent showing a url for your 'action path'
    public IActionResult UpdateNumber(string Value)  // set up an instance of a new "User"
    {
        if(Value == "+1")
        {
            int temp = (int)HttpContext.Session.GetInt32("Digit");
            temp += 1;
            HttpContext.Session.SetInt32("Digit", temp);
            return RedirectToAction("Results");
        }
        if(Value == "-1")
        {
            int temp = (int)HttpContext.Session.GetInt32("Digit");
            temp -= 1;
            HttpContext.Session.SetInt32("Digit", temp);
            return RedirectToAction("Results");
        }
        if(Value == "x2")
        {
            int temp = (int)HttpContext.Session.GetInt32("Digit");
            temp *= 2;
            HttpContext.Session.SetInt32("Digit", temp);
            return RedirectToAction("Results");
        }
        if(Value == "random")
        {
            Random rand = new Random();
            int MyRandomNumber = rand.Next(1,11);
            int temp = (int)HttpContext.Session.GetInt32("Digit");
            temp += MyRandomNumber;
            HttpContext.Session.SetInt32("Digit", temp);
            return RedirectToAction("Results");
        }
        else
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }

    [HttpGet("clear")]
    public IActionResult ClearSession()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
