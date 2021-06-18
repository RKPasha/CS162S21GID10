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
            foreach (var dbObj in users)
            {
                UserData md = new UserData();
                
                md.Name = dbObj.Name;
                md.DateOfBirth = dbObj.DateOfBirth;
                md.Email = dbObj.Email;
                md.Password = dbObj.Password;
                md.ContactNumber = dbObj.Contact;
                list.Add(md);
            }
            return View(list);
        }
        public bool DeleteUser(string name)
        {
            using (var context=new UserDBEntities1())
            {
                var user = context.User1.FirstOrDefault(x => x.Name == name);
                if (user!=null)
                {
                    context.User1.Remove(user);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        [HttpPost]
        public ActionResult Delete(string name)
        {
            DeleteUser(name);
            return RedirectToAction("ViewAllUsers");
        }
    }
}