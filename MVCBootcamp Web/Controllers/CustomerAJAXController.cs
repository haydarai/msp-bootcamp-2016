using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NorthwindRepository.Repositories;

namespace MVCBootcamp_Web.Controllers
{
    public class CustomerAJAXController : Controller
    {

        private CustomerRepository custRepo = new CustomerRepository();

        // GET: CustomerAJAX
        public ActionResult Index()
        {
            return View(custRepo.GetAllData().Take(10));
        }
    }
}