using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CEOController : Controller
    {
        DukoWheelsDBEntities1 db = new DukoWheelsDBEntities1();
        List<Managers_Data> list = new List<Managers_Data>();
        // GET: CEO
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddManager()
        {
            return View();
        }
        public ActionResult ViewAllManagers()
        {
            var managers = db.ManagerDBTables.ToList();
            foreach(var dbObj in managers)
            {
                Managers_Data md = new Managers_Data();
                md.Name = dbObj.Name;
                md.DateOfBirth = dbObj.DateOfBirth;
                md.Email = dbObj.Email;
                md.Password = dbObj.Password;
                md.ContactNumber = dbObj.Contact;
                md.CnicNumber = dbObj.CNIC_NO;
                md.BranchName = dbObj.BranchName;
                list.Add(md);
            }
            return View(list);
        }
    }
}