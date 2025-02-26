using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0101.Models;

namespace Mission08_Team0101.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Quadrants()
    {
        return View();
    }

}
