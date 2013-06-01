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
            IEnumerable<string> items = Enumerable.Range(1, 10).Select(x => "Number " + x.ToString());
            ViewBag.Items = items;

            return View();
        }

        public ActionResult GetNumber(string number)
        {
            ViewBag.Number = number;
            return PartialView();
        }

    }
}
