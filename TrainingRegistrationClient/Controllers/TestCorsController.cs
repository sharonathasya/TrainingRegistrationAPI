﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingRegistrationClient.Controllers
{
    public class TestCorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
