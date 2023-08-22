using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }


    [HttpGet("")] // View ALL - index
    public IActionResult Index() 
    {
        List<Dish> AllDishes = _context.Dishes.OrderByDescending(n => n.CreatedAt).ToList();
        ViewBag.TopDish = _context.Dishes.OrderByDescending(t=> t.Tastiness).Take(1).ToList();
        return View(AllDishes);
    }


    [HttpGet("dishes/{Id}")]  // View One
    public IActionResult OneDish(int Id)
    {
        Dish? OneDish = _context.Dishes.FirstOrDefault(i=> i.DishId == Id);
        return View(OneDish);
    }


    [HttpGet("dishes/new")] // NEW FORM
    public IActionResult NewDish()
    {
        return View();
    }


    [HttpPost("dishes/create")] // Create Action Form
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else {
            return View("NewDish");
        }
    }


    [HttpGet("Dishes/{Id}/edit")] // Update Form
    public IActionResult EditDish(int Id)
    {
        Dish? DishToEdit = _context.Dishes.FirstOrDefault(e => e.DishId == Id);
            if(DishToEdit != null)
            {
                return View(DishToEdit);
            } else {
                return RedirectToAction("Index");
            }
    }


    [HttpPost("Dishes/{Id}/update")] // Update Form Action => With Route back to details page
    public IActionResult UpdateDish(int Id, Dish NewVersion)
    {
        Dish? OldVersion = _context.Dishes.FirstOrDefault(e => e.DishId == Id);
            if(ModelState.IsValid)
            {
                OldVersion.Name = NewVersion.Name;
                OldVersion.Chef = NewVersion.Chef;
                OldVersion.Tastiness = NewVersion.Tastiness;
                OldVersion.Calories = NewVersion.Calories;
                OldVersion.Description = NewVersion.Description;
                _context.SaveChanges();
                return RedirectToAction("OneDish", new {id = Id} );
            } else {
                return View("EditDish", OldVersion);
            }
    }


    [HttpPost("Dishes/{Id}/delete")] // Delete Action
    public IActionResult DeleteDish(int Id)
    {
        Dish? DishToDelete = _context.Dishes.SingleOrDefault(d => d.DishId == Id);
        _context.Dishes.Remove(DishToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
