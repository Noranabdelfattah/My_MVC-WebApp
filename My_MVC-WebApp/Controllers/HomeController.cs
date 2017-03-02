﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_MVC_WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.Countries = new List<string>
            {
                "Egypt","Italy","France"
            };
            return View();
        }
    }
}