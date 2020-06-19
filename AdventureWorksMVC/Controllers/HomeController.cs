using System;
using System.Web.Mvc;
using System.Web.Security;

namespace AdventureWorks.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Default()
        {
            ViewBag.BodyClass = "homepage";
            return View();
        }

        



    }
}
