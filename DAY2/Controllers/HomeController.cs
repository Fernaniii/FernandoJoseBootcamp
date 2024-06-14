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
        };
            

        return View(fullname);
    }

    public IActionResult Sample()
    {
        return View();
    }

}
