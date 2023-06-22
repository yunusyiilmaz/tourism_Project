using AutoMapper;
using Business.Abstract;
using Dto.DTOs.AnnouncementDTOs;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism_Project.Areas.Admin.Models;

namespace Tourism_Project.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/Announcement")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;
        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var model = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());
            return View(model);
        }
        [Route("AddAnnouncement")]
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [Route("AddAnnouncement")]
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index", "Announcement", new { area = "Admin" });
            }
            return View();
        }
        [Route("DeleteAnnouncement")]
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetByID(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index", "Announcement", new { area = "Admin" });

        }
        [Route("UpdateAnnouncement")]
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetByID(id));
            return View(values);
        }
        [Route("UpdateAnnouncement")]
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
        {
           if(ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID=model.AnnouncementID,
                    Title=model.Title,
                    Content=model.Content,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
            return RedirectToAction("Index", "Announcement", new { area = "Admin" });
            }
            return View(model);
        }
    }
}
