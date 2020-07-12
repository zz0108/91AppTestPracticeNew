﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _91AppTest2.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
