using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiniAdventureDotNetWeb.Data;
using MiniAdventureDotNetWeb.Models;

namespace MiniAdventureDotNetWeb.Controllers;

public class HomeController : Controller
{

    //private readonly ApplicationDbContext _db;

    //public HomeController(ApplicationDbContext db)
    //{
    //    _db = db;
    //}



    public IActionResult Index()
    {
        //var page1 = _db.Pages.Find("0");
        //Console.WriteLine("Page 1 retrieved: " + page1.Title);
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

