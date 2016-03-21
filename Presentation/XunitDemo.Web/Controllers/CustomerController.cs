using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XunitDemo.Entity;
using XunitDemo.Services;

namespace XunitDemo.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        public ActionResult Index(string city)
        {
            List<Customer> model = new List<Customer>();
            if (string.IsNullOrWhiteSpace(city))
            {
                ViewBag.ErrorMsg = "請輸入居住地";
            }
            else
            {
                model = _customerService.GetCustomers(city);
            }
            return View(model);
        }
    }
}