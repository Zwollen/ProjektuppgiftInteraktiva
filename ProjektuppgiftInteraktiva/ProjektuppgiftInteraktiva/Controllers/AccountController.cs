using ProjektuppgiftInteraktiva.Data;
using ProjektuppgiftInteraktiva.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjektuppgiftInteraktiva.Controllers
{
    public class AccountController : Controller
    {
        DbOperations db = new DbOperations();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {

                if (db.CheckUserCredentials(model.Username, model.Password))
                {
                    // skapar en login cooki som försvinner när browser stängs.
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    return Redirect(ReturnUrl);
                }

                else
                {
                    ModelState.AddModelError("", "Felaktigt användarnamn eller lösenord.");
                } 

            }
            return View();
           
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}