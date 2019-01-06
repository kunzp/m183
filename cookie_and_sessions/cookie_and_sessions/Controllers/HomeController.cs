using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace role_based_authorization.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            HttpCookie reqCookies = Request.Cookies["userInfo"];
            if (reqCookies != null)
            {
                return View();
            }
            else
            {
                reqCookies = new HttpCookie("userInfo");
            }
            var username = Request["username"];
            var password = Request["password"];
            var keepLoginStatus = Request["keepLoginStatus"];


            if (username == "admin" & password == "test")
            {
               
                reqCookies["username"] = username;
                if(keepLoginStatus == "on")
                {
                    reqCookies.Expires.Add(new TimeSpan(14,0,0,0));
                }
                Response.Cookies.Add(reqCookies);
            }
            else
            {
                ViewBag.Message = "Wrong Credentials";
            }
            return View();
        }
    }
}