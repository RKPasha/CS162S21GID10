using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CEOapiController : ApiController
    {
        [HttpPost]
        public bool addManager(Managers_Data data)
        {
            try
            {
                DukoWheelsDBEntities1 db = new DukoWheelsDBEntities1();
                ManagerDBTable u = new ManagerDBTable();
                u.Name = data.Name;
                u.Email = data.Email;
                u.Contact = data.ContactNumber;
                u.Password = data.Password;
                u.DateOfBirth = data.DateOfBirth;
                u.CNIC_NO = data.CnicNumber;
                u.BranchName = data.BranchName;
                db.ManagerDBTables.Add(u);
                //db.ManagerDBTables.Remove(u);
                db.SaveChanges();
                return true;
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
                return false;
            }

        }

        //[HttpGet]
        //public ManagerDBTable getManagerByID()
        //{
        //    return ;
        //}

          
    }
}


