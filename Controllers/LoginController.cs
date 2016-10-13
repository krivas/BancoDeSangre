using Banco_de_Sangre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banco_de_Sangre.Controllers
{
    public class LoginController : Controller
    {
        public static ClientDBContext Db { get; } = new ClientDBContext();


        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(string email, string password)
        {

            var user = Db.Client.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
            {
                ViewBag.Error = "El usuario no existe";
                return View();
            }
            return RedirectToAction("List", "Register");
        }
    }
}