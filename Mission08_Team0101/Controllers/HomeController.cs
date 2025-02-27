using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Team0101.Models;
using static System.Net.Mime.MediaTypeNames;

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
        var tasks = _context.Habits
            .Select(m => new Habit
            {
                HabitId = m.HabitId,
                TaskName = m.TaskName ?? "Unknown", // Default TaskName if null
                DueDate = m.DueDate, // Ensure DateTime is properly assigned
                QuadrantId = m.QuadrantId, // Assign QuadrantId directly
                Completed = m.Completed, // No need for conditional check
                CategoryId = m.CategoryId,
                Category = m.Category != null ? new Category { CategoryName = m.Category.CategoryName } : null // Handle null Category
            })
            .AsEnumerable()
            .ToList();

        return View(tasks);
    }




    public IActionResult EditTask()
    {

        var habit = _context.Habits
            .ToList();

        return View(habit);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Habits
            .Single(x => x.HabitId == id);



        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();

        return View("AddTask", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Habit updatedInfo)
    {
        _context.Update(updatedInfo);
        _context.SaveChanges();

        return RedirectToAction("EditTask");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordToDelete = _context.Habits
            .Single(x => x.HabitId == id);

        return View(recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete(Habit application)
    {
        _context.Habits.Remove(application);
        _context.SaveChanges();

        return RedirectToAction("EditTask");
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

