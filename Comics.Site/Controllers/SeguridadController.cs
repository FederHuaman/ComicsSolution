﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Comics.Site.Controllers
{
    public class SeguridadController : Controller
    {
        public IActionResult MiCuenta()
        {
            return View();
        }
    }
}