﻿using System;
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
                UserDBEntities1 db = new UserDBEntities1();
                User1 u = new User1();
                u.Name = data.Name;
                u.Email = data.Email;
                u.Contact = data.ContactNumber;
                u.Password = data.Password;
                u.DateOfBirth = data.DateOfBirth.ToString();
                db.User1.Add(u);
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
        public List<UserData> AllUserData()
        {
            List<UserData> list = new List<UserData>();
            return list;
        }
    }
}
