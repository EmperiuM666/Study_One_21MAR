using One_21MAR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace One_21MAR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Istec()
        {
            Pessoa ze = new Pessoa(1,"Ze Carioca", "211234567");
            ViewBag.escola = "Istec";
            ViewData["turma"] = "Turma B";
            TempData["disciplina"] = "TintIII";
            return View(ze);

        }
        public ActionResult Index()
        {
            return View( );
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View( );
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View( );
        }

       
    }
}