using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NotyNotification.Extension;
using NotyNotification.Model;

namespace NotyExample.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View()
                .WithNotification("Welcome!", Position.center)
                .WithNotification("Chainned together!");
        }

        public ActionResult Index_Error()
        {
            return RedirectToAction("Index")
                .WithNotification("This is an error from RedirectToAction.", alertType: AlertType.error, timeOut: 5000);
        }

        public ActionResult Index_Warning()
        {
            return Redirect("~")
                .WithNotification("This is a warning from Redirect", alertType: AlertType.warning);
        }
    }
}