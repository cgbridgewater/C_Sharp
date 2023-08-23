using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using LoginReg.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginReg.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("users/login")]
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpGet("users/register")]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost("users/create")]   
    public IActionResult CreateUser(User newUser)    
    {        
        if(ModelState.IsValid)        
        {
            // Initializing a PasswordHasher object, providing our User class as its type            
            PasswordHasher<User> Hasher = new PasswordHasher<User>();   
            // Updating our newUser's password to a hashed version         
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);            
            //Save your user object to the database 
            _context.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("Main");

        } else {
            // handle else
            return View("Register");
        }   
    }

    [HttpPost("users/login")]
    public IActionResult LoginUser(LoginUser userSubmission)
    {    
        if(ModelState.IsValid)    
        {        
            // If initial ModelState is valid, query for a user with the provided email        
            User? userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.LEmail);        
            // If no user exists with the provided email        
            if(userInDb == null)        
            {            
                // Add an error to ModelState and return to View!            
                ModelState.AddModelError("LEmail", "Invalid Email/Password");            
                return View("Login");        
            }   
            // Otherwise, we have a user, now we need to check their password                 
            // Initialize hasher object        
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();                    
            // Verify provided password against hash stored in db        
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LPassword);
            // Result can be compared to 0 for failure        
            if(result == 0)        
            {            
                ModelState.AddModelError("LEmail", "Invalid Email/Password");            
                return View("Login");
            } else{
            // Handle success (this should route to an internal page) 
            HttpContext.Session.SetInt32("UserId", userInDb.UserId);
            return RedirectToAction("Main"); 
            }
        } else {
            // Handle else
            ModelState.AddModelError("LEmail", "Invalid Email/Password");    
            return View("Login");
        }
    }


    [SessionCheck]
    [HttpGet("main")]
    public IActionResult Main()
    {
        return View();
    }


    [HttpGet("logout")]
    public IActionResult Logout()
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


   // Name this anything you want with the word "Attribute" at the end
    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Find the session, but remember it may be null so we need int?
            int? userId = context.HttpContext.Session.GetInt32("UserId");
            // Check to see if we got back null
            if(userId == null)
            {
                // Redirect to the Index page if there was nothing in session
                // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }