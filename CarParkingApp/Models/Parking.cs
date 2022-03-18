using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarParkingApp.Models
{
    public class Parking
    {
        [Key]
        public int Parking_Num { get; set; }
        [Required]  
        public string Parking_Type { get; set; }
        public DateTime Slots{ get; set; }

        public string Park_Space { get; set; }

        public ICollection<Payment> payments { get; set; }
        

    }
}