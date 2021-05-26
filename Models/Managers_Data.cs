using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Managers_Data : Person
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime DateOfBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BranchName { get; set; }
    }
}