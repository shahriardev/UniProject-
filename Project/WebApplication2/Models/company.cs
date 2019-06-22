using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class company
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "please fill")]

        [Display(Name = "Persianname")]
        public string PersianName { get; set; }
        [Display(Name = "Englishname")]
        public string EnglishName { get; set; }
        [Display(Name = "CountryId")]
        public int CountryId { get; set; }
    }
}