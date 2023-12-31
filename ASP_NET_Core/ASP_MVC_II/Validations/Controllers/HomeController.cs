﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Validations.Models;

namespace Validations.Controllers;

public class HomeController : Controller
{
    static User user; // static variable holder to pass between controller methods
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        HttpContext.Session.SetString("UserName", "Chris"); // set session string call in render side -> <h4>My session user's name is: @Context.Session.GetString("UserName")</h4>

        HttpContext.Session.SetInt32("Digit", 44); // set session digit call in render side--> <h4>My session user's name is: @Context.Session.GetInt32("Digit")</h4>

        return View();
    }

    [HttpPost("")]  // leave this blank, to prevent showing a url for your 'action path'
    public IActionResult Create(User newUser)  // set up an instance of a new "User"
    {
        if(ModelState.IsValid)
        {
            user=newUser;  // pass that variable up to the static holder
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
        return View(user); // Render the view with the variable data from the Model
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


    [HttpGet("clear")]
    public IActionResult ClearSession()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}
