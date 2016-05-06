using MVCBootcamp_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBootcamp_Web.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public string Browse(string category)
        {
            return HttpUtility.HtmlEncode("hello from browse with category " + category);
        }

        public string News(int year, int month, int day)
        {
            return HttpUtility.HtmlEncode(year.ToString() + month.ToString() + day.ToString());
        }

        public ActionResult Home()
        {
            return View("~/Views/Home/Contact.cshtml");
        }

        public ActionResult DataSample()
        {
            ViewData["event"] = "MSP Bootcamp";
            ViewData["place"] = "Hotel Neo";
            ViewBag.events = "MSP Bootcamp";
            ViewBag.place = "Hotel Neo";

            var books = new List<string> { "ASP", "SQL", "Windows" };
            ViewBag.books = books;

            return View();
        }

        public ViewResult StronglyTypeView()
        {

            var listCust = new List<CustomerData>();
            listCust.Add(new CustomerData() { CompanyName = "Native Enterprise", City = "Bandung" });
            listCust.Add(new CustomerData() { CompanyName = "Microsoft", City = "Jakarta" });

            return View(listCust);
        }
    }
}