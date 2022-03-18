using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarParkingApp.Models
{
    public class Payment
    {
        [Key]
        public int Pay_Reference { get; set; } 
        
        public int Parking_Num { get; set; }

        public virtual Parking Parking { get; set; }

        public string Parking_Type { get; set; }
        [Required]
        public int Amount { get; set; }

        [Required]
        public DateTime Pay_Time { get; set; }

        ApplicationDbContext db = new ApplicationDbContext();

        public string getType()
        {
            var type =(from t in db.Payments
                       where t.Parking_Num == Parking_Num
                       select t.Parking_Type).SingleOrDefault();
            return type;
        }
        
    }
}