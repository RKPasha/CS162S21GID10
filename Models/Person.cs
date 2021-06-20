using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Person
	{
        [Required(ErrorMessage = "Name Field must be filled..")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Select Date of Birth..")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email Field must be filled..")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Field must be filled..")]
        [MinLength(8, ErrorMessage = "Password must be 8 characters long..")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Contact Field must be filled..")]
        [MinLength(11, ErrorMessage = "Contact No must be 11 digits long..")]
        public string ContactNumber { get; set; }
    }
}