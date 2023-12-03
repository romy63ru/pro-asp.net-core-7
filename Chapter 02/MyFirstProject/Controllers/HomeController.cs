using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Models;

namespace MyFirstProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public  ViewResult Index()
    {
        var hours = DateTime.Now.Hour;
        string viewModel = "Good Evening";
        if(hours<12) {
            viewModel = "GoodMorning";
        }

        return View("MyView", viewModel);
    }

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
