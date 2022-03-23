using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarParkingApp.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParkingId { get; set; }
        public Parking()
        {

        }
    }
}