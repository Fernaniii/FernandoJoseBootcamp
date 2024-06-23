using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DAY3.Models;
using DAY3.Model;

namespace PracticeWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Product product = new Product(
        12,
        "NOVA", 
        "EXPIRED", 
        "13A",
        31,
        "03-06-2001"
        );

        return View(product);
    }    
    public IActionResult Test(Product product) {
        return RedirectToAction("Index");
    }
}
