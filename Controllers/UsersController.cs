using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        DukoWheelsDBEntities1 db = new DukoWheelsDBEntities1();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UsedCars()
        {
            var usedCars = db.UsedCarsTables.ToList();
            return View(usedCars);
        }
        public ActionResult UsedCarDetails(int id)
        {
            var res = db.UsedCarsTables.Where(x => x.Id == id).First();
            return View(res);
        }
    }
}