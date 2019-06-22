using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
       [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "please fill")]
    
        [Display(Name = "categoryId")]
        public int CategoryId { get; set; }
         [Display(Name="BrandId")] 
        public int BrandId { get; set; }
        [Display(Name = "Modelname")]
        public string ModelName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}