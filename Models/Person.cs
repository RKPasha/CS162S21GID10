using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public abstract class Person
	{
        public abstract string Name { get; set; }
        public abstract DateTime DateOfBirth { get; set; }
        public abstract string Email { get; set; }
        public abstract string Password { get; set; }
    }
}