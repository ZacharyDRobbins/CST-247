using Milestone.Models;
using Milestone.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Milestone.Controllers
{
    public class Login_RegisterController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        //POST : Login
        [HttpPost]
        public ActionResult Login(User model)
        {
            SecurityService service = new SecurityService();
            bool result = service.login(model);
            if (result == true)
            {
                ViewData["user"] = model;
                return View("Home");
            }
            else
                return View("LoginFailed");

        }

        //POST : Login
        [HttpPost]
        public ActionResult Register(User model)
        {
            SecurityService service = new SecurityService();
            bool result = service.register(model);
            if (result == true)
            {
                ViewData["user"] = model;
                return View("Login");
            }
            else
                return View("LoginFailed");

        }
    }
}
