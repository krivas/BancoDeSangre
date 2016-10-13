using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Banco_de_Sangre.Models;

namespace Banco_de_Sangre.Controllers
{
    
    public class RegisterController : Controller
    {
        private static ClientDBContext _db = new ClientDBContext();
        // GET: Register
        public ActionResult User()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Client model)
        {
            if (ModelState.IsValid)
            {
                _db.Client.Add(model);
                _db.SaveChanges();
                return View("Success",model);
            }
            return View("User", model);
            
        }

        public ActionResult List()
        {
            var clients = _db.Client.ToList();
            return View("List", clients);
        }



    }
}