﻿using System;
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


        // GET: /Page/Index
        public IActionResult Index(string id)
        {
            Console.WriteLine("id = " + id);
            var page = _db.Pages.Find(id);

            if (page != null)
            {
                Console.WriteLine("Page retrieved: " + page.ActionCode + ": " + page.Title);
                return View(page);
            }
            return RedirectToAction("Error");
        }

        // GET /Page/Error
        public IActionResult Error()
        {
            return View();
        }
    }
}

