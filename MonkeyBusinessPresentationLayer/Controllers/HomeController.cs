using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MonkeyBusinessClassLibrary;
using MonkeyBusinessPresentationLayer.Models;


namespace MonkeyBusinessPresentationLayer.Controllers
{
    /// <summary>
    /// Reusing the Index module to save time
    /// </summary>

    public class HomeController : Controller
    {
        // Commented out original Index method
        //public ActionResult Index() { return View(); }

        public ActionResult Index(MonkeysViewModel model)
        {
            // Crate new Model if parameter is null
            if (model == null) { model = new MonkeysViewModel(); }

            // Initiate the Class & assign results to model
            var cls = new clsMonkeyBusiness();
            model.CrossingMonkeys = cls.XingMonkeys(model.LeftValue, model.RiteValue);

            return View(model);
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