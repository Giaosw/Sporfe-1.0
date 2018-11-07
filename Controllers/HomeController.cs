﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sporfe_1._0.Models;

namespace Sporfe_1._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly SprofeContext _context;
        public HomeController(SprofeContext context)
        {
            this._context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
