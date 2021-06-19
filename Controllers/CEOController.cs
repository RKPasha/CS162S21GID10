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

        public ActionResult ManagersList()
        {
            var managers = db.ManagerDBTables.ToList();
            return View(managers);
        }
        public ActionResult DeleteManagerData(String Email)
        {
            var res = db.ManagerDBTables.Where(x => x.Email == Email).First();
            db.ManagerDBTables.Remove(res);
            db.SaveChanges();
            var list = db.ManagerDBTables.ToList();
            return View("ManagersList",list);
        }
    }
}