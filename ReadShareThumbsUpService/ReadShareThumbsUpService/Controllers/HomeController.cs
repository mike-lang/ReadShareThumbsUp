using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadShareThumbsUpService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is the ReadShareThumbsUp back end service!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
