using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using AdventureWorks.Models;
using AdventureWorks.Business;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Web.UI;



namespace AdventureWorks.Controllers
{
    public class SiteLayoutController : Controller
    {
        public ActionResult HeaderLayout()
        {
            SiteLayoutModel Header = new SiteLayoutModel();           
            return View(Header);
        }

        public ActionResult FooterLayout()
        {
            SiteLayoutModel Footer = new SiteLayoutModel();
            Footer.ProductCategories = CategoryManager.GetMainCategories();
            return View(Footer);
        }

        public ActionResult ContentLayout()
        {
            SiteLayoutModel Header = new SiteLayoutModel();
            Header.ProductCategories = CategoryManager.GetMainCategories();
            return View(Header);
        }
    }
}
