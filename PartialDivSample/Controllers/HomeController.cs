using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialDivSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Items = Enumerable.Range(1, 10);

            return View();
        }

        public ActionResult GetNumber(int number)
        {
            ViewBag.Number = number;
            return PartialView();
        }

    }
}
