﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CEOController : Controller
    {
        // GET: CEO
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddManager()
        {
            return View();
        }
    }
}