using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class country
    {
        [Key]
         
        public int Id { get; set; }

        [Required(ErrorMessage = "please fill")]

        [Display(Name = "name")]
        public string Name { get; set; }
    }
}