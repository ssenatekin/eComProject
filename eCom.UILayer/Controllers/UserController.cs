﻿using eCom.DataAccessLayer.Concrete;
using eCom.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eCom.UILayer.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        Context c = new Context();

        public ActionResult UserDelete(int id)
        {
            var b = c.Users.Find(id);
            c.Users.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
