using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.Controllers
{
    public class CommendController : Controller
    {
        //CommentManager commentManager = new CommentManager(new EfCommentDal());
        //[HttpGet]
        //public PartialViewResult AddComment()
        //{
        //    return PartialView();
        //}

        //[HttpPost]
        //public IActionResult AddComment(Comment p)
        //{
        //    p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.CommentState = true;
        //    p.DestinationID = 1;
        //    commentManager.TAdd(p);
        //    return RedirectToAction("Index","Destination");
        //}
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly UserManager<AppUser> _userManager;
        public CommendController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            // ViewBag.destID = id;
            //var value = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userID = 5;
            // ViewBag.a = "merhaba";
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            commentManager.TAdd(p);
            return RedirectToAction("Index", "Destination");
        }
    }
}
