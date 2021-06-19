using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

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
        [HttpPost]
        


        public ActionResult Delete(string Email)
        {
            var res = db.UserDBTables.Where(x => x.Email == Email).First();
            db.UserDBTables.Remove(res);
            db.SaveChanges();
            var list = db.UserDBTables.ToList();
            return View("ViewAllUsers", list);
        }

    }
}