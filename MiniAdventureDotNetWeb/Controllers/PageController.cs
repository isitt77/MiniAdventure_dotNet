using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniAdventureDotNetWeb.Data;
using MiniAdventureDotNetWeb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniAdventureDotNetWeb.Controllers
{
    public class PageController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PageController(ApplicationDbContext db)
        {
            _db = db;
        }


        // GET: /<controller>/
        public IActionResult Index(string id)
        {
            Console.WriteLine("id = " + id);
            //var page1 = _db.Pages.Find(id);
            var page = _db.Pages.Find(id);
            Console.WriteLine("Page retrieved: " + page);
            return View(page);
        }
    }
}

