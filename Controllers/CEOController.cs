using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CEOController : Controller
    {
        DukoWheelsDBEntities1 db = new DukoWheelsDBEntities1();
        //List<Managers_Data> list = new List<Managers_Data>();
        // GET: CEO
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddManager()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddManagerToDb(Managers_Data data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ManagerDBTable u = new ManagerDBTable();
                    u.Name = data.Name;
                    u.Email = data.Email;
                    u.Contact = data.ContactNumber;
                    u.Password = data.Password;
                    u.DateOfBirth = data.DateOfBirth;
                    u.CNIC_NO = data.CnicNumber;
                    u.BranchName = data.BranchName;
                    db.ManagerDBTables.Add(u);
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
            var DBlist = db.ManagerDBTables.ToList();
            return View("ManagersList", DBlist);
        }

        public ActionResult ManagersList()
        {
            var managers = db.ManagerDBTables.ToList();
            return View(managers);
        }

        [HttpPost]
        public ActionResult EditManagerToDb(ManagerDBTable data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ManagerDBTable u = new ManagerDBTable();
                    u.Name = data.Name;
                    u.Email = data.Email;
                    u.Contact = data.Contact;
                    u.Password = data.Password;
                    u.DateOfBirth = data.DateOfBirth;
                    u.CNIC_NO = data.CNIC_NO;
                    u.BranchName = data.BranchName;
                    db.Entry(u).State = System.Data.Entity.EntityState.Modified;
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
            var list = db.ManagerDBTables.ToList();
            return View("ManagersList", list);
        }
        public ActionResult EditManager(ManagerDBTable model)
        {
            return View();
        }
        public ActionResult DeleteManagerData(String Email)
        {
            var res = db.ManagerDBTables.Where(x => x.Email == Email).First();
            db.ManagerDBTables.Remove(res);
            db.SaveChanges();
            var list = db.ManagerDBTables.ToList();
            return View("ManagersList", list);
        }

        public ActionResult ComplaintsAndReports()
        {
            var CR = db.ContactTables.ToList();
            return View(CR);
        }
    }
}