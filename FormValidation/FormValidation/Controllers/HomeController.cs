using FormValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new UserInfo());
        }


        [HttpPost]
        public ActionResult Index(UserInfo UI)
        {

            if (ModelState.IsValid)
            { //will validate the object based on the rules applied in class
                return RedirectToAction("Contact");
            }
            return View(UI);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}