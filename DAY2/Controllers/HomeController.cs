using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DAY2.Models;

namespace DAY2.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {

        NameS fullname = new NameS(){
            firstName = "Fernando Jose",
            middleName = "Maniaga",
            lastName = "Magnaye"

            return View(fullname);

        }
            

        return View();
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
