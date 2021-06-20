using Amazon.SecurityToken.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        [HttpPost]
        public ActionResult ContactDb(ContactTable data)
        {
            DukoWheelsDBEntities1 db = new DukoWheelsDBEntities1();
            try
            {
                if (ModelState.IsValid)
                {
                    ContactTable u = new ContactTable();
                    u.SenderName = data.SenderName;
                    u.SenderEmail = data.SenderEmail;
                    u.Message = data.Message;
                    db.ContactTables.Add(u);
                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
            return View("Contact");
        }
    }
       
    }
