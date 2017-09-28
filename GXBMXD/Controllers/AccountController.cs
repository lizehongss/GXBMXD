using GXBMXD.Infrastructure.Abstract;
using GXBMXD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GXBMXD.Controllers
{
    public class AccountController : Controller
    {
        IAuthProvider authProvider;

        public AccountController(IAuthProvider auth)
        {
            authProvider = auth;
        }

        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            

            if (ModelState.IsValid)
            {
                if (authProvider.Authenticate(model.UserName, model.Password))
                {
                    return RedirectToAction("Index", "Admins");
                }
                else
                {
                    ModelState.AddModelError("", "密码不正确");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}