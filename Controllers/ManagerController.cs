using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using WebApplication1.Models;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Net;

namespace WebApplication1.Controllers
{
    public class ManagerController : Controller
    {
        DukoWheelsDBEntities1 db = new DukoWheelsDBEntities1();
        List<UserData> list = new List<UserData>();
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAllUsers()
        {
            var users = db.UserDBTables.ToList();
            return View(users);
        }
        public ActionResult Delete(string Email)
        {
            var res = db.UserDBTables.Where(x => x.Email == Email).First();
            db.UserDBTables.Remove(res);
            db.SaveChanges();
            var list = db.UserDBTables.ToList();
            return View("ViewAllUsers", list);
        }
        public ActionResult AddnewUser(UserData data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DukoWheelsDBEntities1 db = new DukoWheelsDBEntities1();
                    UserDBTable u = new UserDBTable();
                    u.Name = data.Name;
                    u.Email = data.Email;
                    u.Contact = data.ContactNumber;
                    u.Password = data.Password;
                    u.DateOfBirth = data.DateOfBirth;
                    db.UserDBTables.Add(u);
                    db.SaveChanges();
                }
                ModelState.Clear();
                
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Hello Rehan");
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
                
            }
            return View();
        }

        [HttpPost]
        public ActionResult EditData(UserDBTable data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DukoWheelsDBEntities1 db = new DukoWheelsDBEntities1();
                    UserDBTable u = new UserDBTable();
                    u.Name = data.Name;
                    u.Email = data.Email;
                    u.Contact = data.Contact;
                    u.Password = data.Password;
                    u.DateOfBirth = data.DateOfBirth;
                    db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    
                    
                }
                ModelState.Clear();

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Hello Rehan");
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }

            }


            var users = db.UserDBTables.ToList();
            return View("ViewAllUsers", users);
            }

        public ActionResult EditUserForm(UserDBTable data)
        {
            return View();
        }
        public ActionResult Contact(string email,string name,string message, UserDBTable data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("dukocommunity@gmail.com", "DukoCommunity");
                    var receiverEmail = new MailAddress(email, name);

                    var password = "incredebols@duko";
                    var subject = "DukoWheels";
                    var body = message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)

                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body

                    }
                    )
                    {
                        smtp.Send(mess);
                    }
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Error";
            }
            return View(data);
        }
    
        public ActionResult VehicleManagement()
        {
            return View();
        }
}
}