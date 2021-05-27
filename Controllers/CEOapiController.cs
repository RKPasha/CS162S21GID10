using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CEOapiController : ApiController
    {
        private static CEOapiController obj;

        private List<Managers_Data> list;

        private CEOapiController()
        {
            list = new List<Managers_Data>();
        }

        public static CEOapiController getObject()
        {
            if (obj == null)
            {
                obj = new CEOapiController();
            }
            return obj;
        }

        [HttpPost]
        public void addEmployee(Managers_Data M)
        {
            list.Add(M);
        }

        [HttpPost]
        public List<Managers_Data> getAllManagers()
        {
            return list;
        }
    }
}
