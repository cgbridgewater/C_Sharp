using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetTestProject.Models;

namespace PetTestProject.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("")]
    public IActionResult Index() //View ALL
    {
        // ViewBag.AllPets = _context.Pets.ToList();
        // ViewBag.AllDogs = _context.Pets.Where(d => d.PetType == "Dog");
        // ViewBag.MostRecent = _context.Pets.OrderByDescending(m => m.CreatedAt).Take(5).ToList();
        List<Pet> AllPets = _context.Pets.ToList();
        return View(AllPets);
    }

    [HttpGet("pets/new")] //Create One Form Page
    public IActionResult NewPet()
    {
        return View();
    }


    [HttpPost("pets/create")] // Create One Action Route
    public IActionResult CreatePet(Pet newPet)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newPet);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else {
            return View("NewPet");
        }
    }

    [HttpGet("pets/{id}")]
    public IActionResult OnePet(int id) // View One
    {
        Pet? OnePet = _context.Pets.FirstOrDefault(i=> i.PetId == id);
        return View(OnePet);
    }

    [HttpGet("pets/{Id}/edit")] // Get/populate update form
    public IActionResult EditPet(int Id)
    {
            Pet? PetToEdit = _context.Pets.FirstOrDefault(a => a.PetId == Id); 
                if(PetToEdit != null)
                {
                    return View(PetToEdit);
                } else{
                    return RedirectToAction("Index");
                }
    }

    [HttpPost("pets/{Id}/update")] // Post action for Update
    public IActionResult UpdatePet(int Id,Pet NewVersion)
    {
        Pet? OldVersion = _context.Pets.FirstOrDefault(p => p.PetId == Id);
        if(ModelState.IsValid)
        {
            OldVersion.PetName = NewVersion.PetName;
            OldVersion.PetType = NewVersion.PetType;
            OldVersion.PetAge = NewVersion.PetAge;
            OldVersion.HasFur = NewVersion.HasFur;
            OldVersion.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else {
            return View("EditPet", OldVersion);
        }
    }

    [HttpPost("pets/{Id}/delete")] // Delete Action
    public IActionResult DeletePet(int Id)
    {
        Pet? PetToDelete = _context.Pets.SingleOrDefault(p => p.PetId == Id);
        _context.Pets.Remove(PetToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }


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
