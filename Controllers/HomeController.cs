﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;

namespace RoleTopMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Usuario()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
