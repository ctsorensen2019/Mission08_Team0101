using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0101.Models;

namespace Mission08_Team0101.Controllers;

public class HomeController : Controller
{
    private HabitContext _context;
    public HomeController(HabitContext temp) //Constructor
    {
        _context = temp; //Storing temporary variable
    }
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Quadrants()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddTask()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddTask(Habit response)
    {
        _context.Habits.Add(response); //add record to database
        _context.SaveChanges();
        return View("Confirmation", response);
    }

}

