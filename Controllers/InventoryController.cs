using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BrickInventory.Models;

namespace BrickInventory.Controllers;

public class InventoryController : Controller
{
    private readonly ILogger<InventoryController> _logger;

    public InventoryController(ILogger<InventoryController> logger)
    {
        _logger = logger;
    }


    public IActionResult Manage(string id)
    {
        return View();
    }

}

