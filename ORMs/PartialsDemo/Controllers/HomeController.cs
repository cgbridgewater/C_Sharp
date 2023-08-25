using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialsDemo.Models;

namespace PartialsDemo.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet("")] // View ALL - index
    public IActionResult Index() 
    {
        List<Product> AllProducts = _context.Products.OrderByDescending(p => p.CreatedAt).ToList();
        ViewBag.AllUsers = _context.Users.ToList();
        return View(AllProducts);
    }


    [HttpGet("forms/new")] // NEW FORM
    public IActionResult NewForm()
    {
        return View();
    }


    [HttpPost("user/create")] // Create User Action Form
    public IActionResult CreateUser(User newUser)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newUser);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else {
            return View("NewForm");
        }
    }


    [HttpPost("product/create")] // Create Product Action Form
    public IActionResult CreateProduct(Product newProduct)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else {
            return View("NewForm");
        }
    }













    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
