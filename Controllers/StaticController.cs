using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banco_de_Sangre.Controllers
{
    public class StaticController : Controller
    {
        // GET: Static
        public ActionResult Requisitos()
        {
            return View();
        }
    }
}