
using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism_Project.Models;

namespace Tourism_Project.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/Reservation")]
    public class ReservationController : Controller
    {
        DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager _reservationManager = new ReservationManager(new EfReservationDal());
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("MyCurrentReservation")]
        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationManager.GetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }
        [Route("MyOldReservation")]
        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationManager.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }
        [Route("MyApprovalReservation")]
        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationManager.GetListWithReservationByWaitAprroval(values.Id);
            return View(valuesList);
        }

        [Route("NewReservation")]
        [HttpGet]
        public async Task<IActionResult> NewReservation()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            var model = new ReservationViewModel();
            var values = _destinationManager.TGetList();
            model.Name = value.Name;
            model.Surname = value.Surname;
            model.CityList = values.Select(c => new SelectListItem { Text = c.City, Value = c.DestinationID.ToString() }).ToList();
            model.DayNightList = values.Select(c => new SelectListItem { Text = c.DayNight, Value = c.DestinationID.ToString() }).ToList();
            return View(model);
        }
        [Route("NewReservation")]
        [HttpPost]
        public async Task<IActionResult> NewReservation(ReservationViewModel p)
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _destinationManager.TGetList();
            _reservationManager.TAdd(new Entity.Concrete.Reservation
            {
                Name = p.Name,
                Surname = p.Surname,
                DestinationID =int.Parse(p.SelectedCityID.ToString()),
                City = int.Parse(p.SelectedCityID).ToString(),
                DayNight = int.Parse(p.SelectedDayNightID).ToString(),
                PersonCount = p.PersonCount,
                Description = p.Description,
                AppUserId = value.Id,
                ReservationDate = p.ReservationDate,
                Status = "Onay Bekliyor."
            });
            return RedirectToAction("MyApprovalReservation", "Reservation", new { area = "Member" });
        }
    }
}
