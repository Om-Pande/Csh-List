using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Create a list of countries
            List<string> countries = new List<string>
            {
                "India",
                "USA",
                "UK",
                "Japan"
            };

            // Add the list of countries to ViewData
            ViewData["Countries"] = countries;

            return View();
        }
    }
}
