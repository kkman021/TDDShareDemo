using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using XunitDemo.Web.Models;

namespace XunitDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVw model)
        {
            if (model.Account == "test" && model.Pwd == "1234")
            {
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "帳號密碼異常");
                return View();
            }
        }

        public ActionResult Welcome()
        {

            return View();
        }
    }


}