using EC_Repuetos_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EC_Repuetos_v2.Controllers
{
    public class LoginController : Controller
    {
        private DB_PROYECTO_WEBEntities db = new DB_PROYECTO_WEBEntities();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult VerifyUser(string EC_USUARIOS_EMAIL, string EC_USUARIOS_CONTRASENNA)
        {

            if (!String.IsNullOrEmpty(EC_USUARIOS_EMAIL) && !String.IsNullOrEmpty(EC_USUARIOS_CONTRASENNA))
            {

                var user = from e in db.EC_USUARIOS
                               select e;

                user = user.Where( userEmail => ( userEmail.EC_USUARIOS_EMAIL.Equals(EC_USUARIOS_EMAIL) ));

                if (user.Count() > 0)
                {
                    if (user.First().EC_USUARIOS_CONTRASENNA.Equals(EC_USUARIOS_CONTRASENNA))
                    {
                        Session["usuarios"] = user.First();
                        return RedirectToAction("Index", "EC_PRODUCTOS");
                    }
                }
            }
            return RedirectToAction("Login", "Login");
        }

        public ActionResult CloseSession()
        {
            Session.RemoveAll();
            return RedirectToAction("Login", "Login");
        }
    }
}