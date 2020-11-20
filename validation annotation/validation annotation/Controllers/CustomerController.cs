using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace validation_annotation.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Models.Customer myCustomer = new Models.Customer();
            myCustomer.ID = 1234;
            myCustomer.Name = "John Doe";
            myCustomer.Email = "1234@gmail.com";

            return View("Index", myCustomer);
        }
    }
}