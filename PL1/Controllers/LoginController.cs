using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            ML.Result result = new ML.Result();
            result = BL.Usuario.GetByEmail(email);
            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario)result.Object;
                if (usuario.Email == email && usuario.Password == password)
                {
                    return RedirectToAction("Index", "Home");

                }
                else
                {
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
