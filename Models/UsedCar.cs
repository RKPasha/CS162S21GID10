using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UsedCar : Car
    {
        [Required]
        public int Milage { get; set; }
    }
}