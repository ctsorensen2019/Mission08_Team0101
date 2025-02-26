using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Team0101.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Mission08_Team0101.Controllers;

public class HomeController : Controller
{
    private QuadrantContext _context;

    public HomeController(QuadrantContext temp)//Constructor
    {
        _context = temp;
    }
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Quadrants()
    {
        return View();
    }


    //public IActionResult EditMovie()
    //{

    //    var movies = _context.Movies
    //        .ToList();

    //    return View(movies);
    //}

    //[HttpGet]
    //public IActionResult Edit(int id)
    //{
    //    var recordToEdit = _context.Movies
    //        .Single(x => x.MovieId == id);



    //    ViewBag.Categories = _context.Categories
    //        .OrderBy(x => x.CategoryName)
    //        .ToList();

    //    return View("MovieForm", recordToEdit);
    //}

    //[HttpPost]
    //public IActionResult Edit(Habit updatedInfo)
    //{
    //    _context.Update(updatedInfo);
    //    _context.SaveChanges();

    //    return RedirectToAction("EditTask");
    //}

    //[HttpGet]
    //public IActionResult Delete(int id)
    //{
    //    var recordToDelete = _context.Movies
    //        .Single(x => x.MovieId == id);

    //    return View(recordToDelete);
    //}

    //[HttpPost]
    //public IActionResult Delete(Habit application)
    //{
    //    _context.Movies.Remove(application);
    //    _context.SaveChanges();

    //    return RedirectToAction("EditMovie");
    //}

}
