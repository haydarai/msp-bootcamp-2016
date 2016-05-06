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

        // GET: CustomersAjax
        [Route("CustomerData/AllCustomer")]
        public ActionResult Index()
        {
            return View(custRepo.GetAllData().Take(5));
        }

        [Route("CustomerData/{id}")]
        public ActionResult Search(string id)
        {
            return View(custRepo.Search(id));
        }
    }
}