﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class XController : Controller
    {
        public IActionResult ControllerX()
        {
            int x = 1;
            int y = 2;
            int c = x + y;
            return View();
        }
    }
}