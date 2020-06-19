using System.Web.Mvc;

namespace AdventureWorks.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Default()
        {
            ViewBag.ErrMsg = "An error occurred while processing your request.";
            return View();
        }

        public ActionResult GenericError()
        {
            ViewBag.ErrMsg = "An error occurred while processing your request.";
            return View();
        }

    }
}
