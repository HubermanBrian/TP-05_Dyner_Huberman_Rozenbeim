using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_05_Dyner_Huberman_Rozenbeim.Models;

namespace TP_05_Dyner_Huberman_Rozenbeim.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
