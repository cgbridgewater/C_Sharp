﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _context = context;
        _logger = logger;
    }


    ////   VIEWS   ///

    // View All Products => create and show all products
    [HttpGet("")] 
    public IActionResult Index()
    {
        ViewBag.AllProducts = _context.Products.OrderBy(n => n.Name).ToList();
        return View();
    }


    // View All Categories  => create and show all categories
    [HttpGet("categories")] 
    public IActionResult Categories()
    {
        ViewBag.AllCategories = _context.Categories.OrderBy(n => n.Name).ToList();
        return View();
    }


    // View One Product
    [HttpGet("products/{Id}")] 
    public IActionResult OneProduct(int Id)
    {
        // get product by Id
        ViewBag.OneProduct = _context.Products.FirstOrDefault( i => i.ProductId == Id);
        // get list of all categories created
        List<Category> AllCategories = _context.Categories.OrderBy(n => n.Name).ToList();
        ViewBag.AllCategories = AllCategories;
        // Get the products with joined categories
        var ProdsAndCats =_context.Products
                                .Include(a => a.Associations)
                                .ThenInclude(a => a.Category)
                                .FirstOrDefault(p => p.ProductId == Id);
        ViewBag.ProdsAndCats = ProdsAndCats;
        // Create an empty list
        List<Category> JoinedCats = new List<Category>();
        // push all associated categories to list // this must be done to use "EXCEPT"
        foreach (var c in ProdsAndCats.Associations){
            JoinedCats.Add(c.Category);
        }
        // compare using Except and filter out 'associated' categories
        List<Category> FilteredCats = AllCategories.Except(JoinedCats).ToList();
        ViewBag.FilteredCats = FilteredCats;
        return View();
    }


    // View One Category
    [HttpGet("categories/{Id}")]  
    public IActionResult OneCategory(int Id)
    {
        // get category by Id
        ViewBag.OneCategory = _context.Categories.FirstOrDefault( i => i.CategoryId == Id);
        // get list of all products created
        List<Product> AllProducts = _context.Products.OrderBy(n => n.Name).ToList();
        ViewBag.AllProducts = AllProducts;
        // Get the categories with joined products
        var CatsAndProds =_context.Categories
                                .Include(a => a.Associations)
                                .ThenInclude(a => a.Product)
                                .FirstOrDefault(p => p.CategoryId == Id);
        ViewBag.CatsAndProds = CatsAndProds;
        // Create an empty list
        List<Product> JoinedProds = new List<Product>();
        // push all associated products to list // this must be done to use "EXCEPT" function
        foreach (var c in CatsAndProds.Associations){
            JoinedProds.Add(c.Product);
        }
        // compare using Except and filter out 'associated' products
        List<Product> FilteredProds = AllProducts.Except(JoinedProds).ToList();
        ViewBag.FilteredProds = FilteredProds;
        return View();
    }


    ////   CREATE PRODUCTS AND CATEGORIES   ////

    // create product form action
    [HttpPost("post/createproduct")] 
    public IActionResult CreateProduct(Product newProduct)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else{
            ViewBag.AllProducts = _context.Products.OrderBy(n => n.Name).ToList();
            return View("Index");
        }
    }


    // create category form action
    [HttpPost("post/createcategory")] 
    public IActionResult CreateCategory(Category newCategory)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("Categories");
        } else{
            ViewBag.AllCategories = _context.Categories.OrderBy(n => n.Name).ToList();
            return View("Categories");
        }
    }


    ////   CREATE ASSOCIATIONS   ////

    // join categories action
    [HttpPost("productaddcat")] 
    public IActionResult productAddCat(Association newAssoc)
    {
            _context.Add(newAssoc);
            _context.SaveChanges();
            return RedirectToAction("OneProduct", new { Id = newAssoc.ProductId });
    }


    // join products action
    [HttpPost("catandprod")] 
    public IActionResult catAddProd(Association newAssoc)
    {
            _context.Add(newAssoc);
            _context.SaveChanges();
            return RedirectToAction("OneCategory", new { Id = newAssoc.CategoryId });
    }


    ////   REMOVE ASSOCIATIONS   ////

    // remove association => return to category by Id
    [HttpPost("catandprod/{Id}/delete")] 
    public IActionResult removeProd(int Id)
    {
        Association ProdToRemove = _context.Associations.SingleOrDefault(p => p.AssociationId == Id);
        _context.Associations.Remove(ProdToRemove);
        _context.SaveChanges();
        return RedirectToAction("OneCategory", new {Id = ProdToRemove.CategoryId});
    }


    // remove association => return to product by Id
    [HttpPost("productaddcat/{Id}/delete")] 
    public IActionResult removeCat(int Id)
    {
        Association? CatToRemove = _context.Associations.SingleOrDefault(c => c.AssociationId == Id);
        _context.Associations.Remove(CatToRemove);
        _context.SaveChanges();
        return RedirectToAction("OneProduct", new {Id = CatToRemove.ProductId});
    }


    //// RESPONSE CACHE ////

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}