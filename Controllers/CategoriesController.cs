using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Models;

namespace ShopApp.Controllers;

public class CategoriesController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    // public IActionResult Edit(int? id)
    // {
    //     if(id.HasValue){
    //         return new ContentResult {Content = id.ToString()};
    //     }
    //     else{
    //         return new ContentResult {Content = "null content"};
    //     }
    // }
    public IActionResult Edit(int? id)
    {
        var category = new Category {CategoryId = id.HasValue?id.Value:0};
        return View(category); 
    }
}
