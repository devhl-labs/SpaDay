using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            if (ViewBag.user == null)
                return View("Add");

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User newUser, string verify)
        {
            ViewBag.user = newUser;
            
            if (newUser.Password == verify)
                return View("Index");            

            ViewBag.passwordsDoNotMatch = true;

            return View("Add");                
        }

    }
}
