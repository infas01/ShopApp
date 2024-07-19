using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Models;

namespace ShopApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}
