﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using weddingPlanner.Models;

namespace weddingPlanner.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _context = context;
        _logger = logger;
    }


            //////// GET ACTIONS ////////


    // Landing Page
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    // Login Page
    [HttpGet("users/login")]
    public IActionResult Login()
    {
        return View();
    }
    
    // Registration Page
    [HttpGet("users/register")]
    public IActionResult Register()
    {
        return View();
    }

    // View All Weddings
    [SessionCheck]
    [HttpGet("weddings")]
    public IActionResult Weddings()
    {
        int? Id = HttpContext.Session.GetInt32("UserId");
        ViewBag.LoggedUser = _context.Users.FirstOrDefault( u => u.UserId == Id );
        var weddings = _context.Weddings
            .Include(u => u.Guests)
            .ToList();
        ViewBag.weddings = weddings;
        return View();
    }


    // View One Wedding
    [SessionCheck]
    [HttpGet("weddings/{Id}")]
    public IActionResult OneWedding(int Id)
    {
        int? UId = HttpContext.Session.GetInt32("UserId");
        ViewBag.LoggedUser = _context.Users.FirstOrDefault( u => u.UserId == UId);
        Wedding? OneWedding = _context.Weddings.FirstOrDefault(w => w.WeddingId == Id);
        var WeddingsAndUsers = _context.Weddings
                            .Include(r => r.Guests)
                            .ThenInclude(w => w.User)
                            .FirstOrDefault(u => u.WeddingId == Id);
        ViewBag.WeddingRsvps = WeddingsAndUsers;
        return View(OneWedding);
    }


    // New Wedding Form
    [SessionCheck]
    [HttpGet("weddings/new")]
    public IActionResult PlanWedding()
    {
        int? Id = HttpContext.Session.GetInt32("UserId");
        ViewBag.LoggedUser = _context.Users.FirstOrDefault( u => u.UserId == Id);
        return View();
    }


    // Edit Wedding Page
    [SessionCheck]
    [HttpGet("weddings/{Id}/edit")]
    public IActionResult EditWedding(int Id)
    {
        int? UId = HttpContext.Session.GetInt32("UserId");
        ViewBag.LoggedUser = _context.Users.FirstOrDefault( u => u.UserId == UId);
        Wedding? WeddingToEdit = _context.Weddings.FirstOrDefault(e => e.WeddingId == Id);
            if(WeddingToEdit != null)
            {
                return View(WeddingToEdit);
            } else {
                return RedirectToAction("Weddings");
            }
    }


    // Logout User
    [HttpGet("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }


            //////// POST ACTIONS ////////


    // Create New User
    [HttpPost("users/create")]   
    public IActionResult CreateUser(User newUser)
    {        
        if(ModelState.IsValid)
        {
            User? checkForEmail = _context.Users.FirstOrDefault(u => u.Email == newUser.Email);
            // If email exists with in the database
            if(checkForEmail != null)
            {
                // Add an error to ModelState and return to View!
                ModelState.AddModelError("Email", "Email is already used");
                return View("Register");        
            }
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            _context.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("Weddings");
        } else {
            return View("Register");
        }
    }


    // Login User
    [HttpPost("users/login")]
    public IActionResult LoginUser(LoginUser userSubmission)
    {
        if(ModelState.IsValid)
        {
            User? userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.LEmail);
            if(userInDb == null)
            {            
                ModelState.AddModelError("LEmail", "Invalid Email/Password");
                return View("Login");
            }
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LPassword);
            if(result == 0)
            {
                ModelState.AddModelError("LEmail", "Invalid Email/Password");
                return View("Login");
            } else{
            HttpContext.Session.SetInt32("UserId", userInDb.UserId);
            return RedirectToAction("Weddings"); 
            }
        } else {
            ModelState.AddModelError("LEmail", "Invalid Email/Password");
            return View("Login");
        }
    }


    // Create new wedding event
    [HttpPost("weddings/create")]
    public IActionResult CreateWedding(Wedding newWedding)
    {
        if(ModelState.IsValid)
        {
            newWedding.UserId = (int)HttpContext.Session.GetInt32("UserId");
            _context.Add(newWedding);
            _context.SaveChanges();
            return RedirectToAction("Weddings");
        } else{
            int? Id = HttpContext.Session.GetInt32("UserId");
            ViewBag.LoggedUser = _context.Users.FirstOrDefault( u => u.UserId == Id);
            return View("PlanWedding");
        }
    }


    // Update Wedding Event
    [HttpPost("weddings/{Id}/update")] 
    public IActionResult UpdateWedding(int Id, Wedding NewVersion)
    {
        Wedding? OldVersion = _context.Weddings.FirstOrDefault(e => e.WeddingId == Id);
            if(ModelState.IsValid)
            {
                OldVersion.Bride = NewVersion.Bride;
                OldVersion.Groom = NewVersion.Groom;
                OldVersion.EventDate = NewVersion.EventDate;
                OldVersion.Address = NewVersion.Address;
                _context.SaveChanges();
                return RedirectToAction("OneWedding", new {id = Id} );
            } else {
                return View("UpdateWedding", OldVersion);
            }
    }


    // Delete Wedding Event
    [HttpPost("Weddings/{Id}/delete")] // Delete Action
    public IActionResult DeleteWedding(int Id)
    {
        Wedding? WeddingToDelete = _context.Weddings.SingleOrDefault(w=> w.WeddingId == Id);
        _context.Weddings.Remove(WeddingToDelete);
        _context.SaveChanges();
        return RedirectToAction("Weddings");
    }


            ///////////////////  RSVPS  ////////////////////

    // Create RSVP Associations 
    [HttpPost("RSVP")]
    public IActionResult RSVP(Rsvp newRsvp)
    {
        _context.Add(newRsvp);
        _context.SaveChanges();
        return RedirectToAction("Weddings");
    }


    // Remove RSVP Associations
    [HttpPost("RSVP/{Id}/remove")]
    public IActionResult rsvpRemove(int Id)
    {
        Rsvp rsvpToRemove = _context.Rsvps.SingleOrDefault(r => r.RsvpId == Id);
        _context.Rsvps.Remove(rsvpToRemove);
        _context.SaveChanges();
        return RedirectToAction("Weddings");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


    // Validation Check
    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int? userId = context.HttpContext.Session.GetInt32("UserId");
            if(userId == null)
            {
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }