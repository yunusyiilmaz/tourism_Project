using Entity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.Models
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AppUserId { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string PersonCount { get; set; }
        //public int Destination { get; set; }
        public string SelectedDayNightID { get; set; }
        public List<SelectListItem> DayNightList { get; set; } = new();
        public DateTime ReservationDate { get; set; }
        public string SelectedCityID { get; set; }
        public List<SelectListItem> CityList { get; set; } = new();
        public Destination Destination { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
