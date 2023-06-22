using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism_Project.Models;

namespace Tourism_Project.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/Reservation")]
    public class ReservationController : Controller
    {
        private IReservationService _reservationService;
        private IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _reservationService = reservationService;
            _destinationService = destinationService;
            _userManager = userManager;
        }
        [Route("Index")]
        public IActionResult Index(int id)
        {
            var ReservationValues = _reservationService.GetListWithReservation(id);
            return View(ReservationValues);
        }
        [Route("Approve")]
        public IActionResult Approve(int id)
        {
           _reservationService.Approve(id);
            return RedirectToAction("Index", "Reservation", new { area = "Admin" });
        }

        [Route("Denied")]
        public IActionResult Denied(int id)
        {
            _reservationService.Denied(id);
            return RedirectToAction("Index", "Reservation", new { area = "Admin" });
        }
    }
}
