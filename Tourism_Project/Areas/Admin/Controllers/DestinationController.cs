using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.Areas.Admin
{
    [Area("Admin")]
    [Route("Admin/Destination")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
        [Route("AddDestination")]
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [Route("AddDestination")]
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
        [Route("DeleteDestination")]
        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
        [Route("UpdateDestination")]
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            return View(values);
        }
        [Route("UpdateDestination")]
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {     
            _destinationService.TUpdate(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
    }
}
