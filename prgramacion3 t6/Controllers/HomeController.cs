using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prgramacion3_t6.Models;

namespace prgramacion3_t6.Controllers
{
  
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formu()
        {
            ViewBag.Message = "Donde esta ubicado el formulario a llenar";

            return View();
        }

        [HttpPost]
        public ActionResult Formu(Formulario form)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Ver", form);
            }
            else
            {
                return View("Formu");
            }

        }

        public ActionResult Ver(Formulario form)
        {
            ViewBag.Message = "Donde esta ubicado el formulario lleno";

            return View(form);
        }
    }
}