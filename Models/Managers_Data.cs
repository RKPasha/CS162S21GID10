using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Managers_Data : Person
    {
        [Required(ErrorMessage = "Branch Name can't be empty..")]
        public string BranchName { get; set; }

        [Required(ErrorMessage = "Cnic No Field must be filled..")]
        public string CnicNumber { get; set; }
    }
}