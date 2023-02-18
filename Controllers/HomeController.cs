using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BrickInventory.Models;

namespace BrickInventory.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult index(string id)
    {
        return View("index");
    }



    // [Route("Home/Bricks")]
    // public IActionResult Bricks()
    // {
    //     return View("index");
    // }

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
