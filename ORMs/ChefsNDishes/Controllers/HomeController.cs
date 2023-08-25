using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using ChefsNDishes.Models;

namespace ChefsNDishes.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _context = context;
        _logger = logger;
    }



    public IActionResult Index()
    {
        List<User> AllUsers = _context.Users.Include(user => user.AllDishes).ToList();

        return View(AllUsers);
    }



    [HttpGet("chef/new")] // NEW FORM
    public IActionResult NewChef()
    {
        return View();
    }



    [HttpPost("chef/create")] // Create Action Form
    public IActionResult CreateChef(User newChef)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else {
            return View("NewChef");
        }
    }



    [HttpGet("dishes")]
    public IActionResult Dishes()
    {
        List<Dish> AllDishes = _context.Dishes.Include(c => c.Chef).OrderByDescending(t => t.Tastiness).ToList();
        return View(AllDishes);
    }



    [HttpGet("dishes/new")] // NEW FORM
    public IActionResult NewDish()
    {
        ViewBag.AllUsers  = _context.Users.ToList();
        return View();
    }



    [HttpPost("dishes/create")] // Create Action Form
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Dishes");
        } else {
            return View("NewDish");
        }
    }

    [HttpGet("privacy")]
    public IActionResult Privacy()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}