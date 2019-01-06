﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace role_based_authorization.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Dashboard()
        {
            var current_user = (string)Session["username"];
            var user_roles = MvcApplication.UserRoles;
            var current_user_role = (string)user_roles[current_user];

            if (current_user_role == "User")
            {

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}