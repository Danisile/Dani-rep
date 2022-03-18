using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarParkingApp.Models
{
    public class Details
    {
        [Key]
        [Display(Name ="ID")]
        public int Person_Id { get; set; }
        [Required]
        [Display(Name ="Full Name")]
        public string Person_Name { get; set; }

        [Display(Name = "ID Number")]
        public string Person_IdNum{ get; set; }

        [Display(Name ="Gender")]
        public string Person_Gender { get; set; }  

        
        
    }
}