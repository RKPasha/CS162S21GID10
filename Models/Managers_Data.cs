using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Managers_Data : Person
    {
        public string BranchName { get; set; }
        public string CnicNumber { get; set; }
        public int ContactNumber { get; set; }
        public bool Gender { get; set; }        
    }
}