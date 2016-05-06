using NorthwindRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBootcamp_Web.Controllers
{
    public class CustomerRouteController : Controller
    {
        private CustomerRepository custRepo = new CustomerRepository();

        // GET: CustomeRoute
        public ActionResult Index()
        {
            return View(custRepo.GetAllData().Take(5));
        }

        public ActionResult Search(string id)
        {
            var cust = custRepo.Search(id);
            return View(cust);
        }
    }
}