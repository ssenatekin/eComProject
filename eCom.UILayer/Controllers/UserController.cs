﻿using Microsoft.AspNetCore.Mvc;

namespace eCom.UILayer.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
