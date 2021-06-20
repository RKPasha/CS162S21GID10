using Amazon.SecurityToken.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Signup_Form()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult Upcoming_Cars()
        {
            return View();
        }
        public ActionResult Duko_Community()
        {
            return View();
        }
    }
       
    }
