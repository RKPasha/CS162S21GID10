using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserApiController : ApiController
    {
        [HttpPost]
        public bool AddUser(UserData data)
        {
            try
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
                return true;
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
                return false;
            }

        }
        [HttpGet]
        public List<UserData> AllUserData()
        {
            List<UserData> list = new List<UserData>();
            UserDBEntities1 db = new UserDBEntities1();
            var dblist = db.User1.ToList();
            foreach(var dbobj in dblist)
            {
                UserData u = new UserData();
                u.Name = dbobj.Name;
                u.ContactNumber = dbobj.Contact;
                //u.DateOfBirth = dbobj.DateOfBirth;
                u.Email = dbobj.Email;
                u.Password = dbobj.Password;
                list.Add(u);
            }
            return list;
        }


    }
}
