using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tourism_Project.Areas.Member.Models;

namespace Tourism_Project.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel
            {
                Name = values.Name,
                Surname = values.Surname,
                PhoneNumber = values.PhoneNumber,
                Mail = values.Email
            };
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            if(p.Image!=null)
            {
                var resource = Directory.GetCurrentDirectory();//resmin kaynağı
                var extension = Path.GetExtension(p.Image.FileName);//uzantı. yönlecenek alan
                var imageName = Guid.NewGuid() + extension;//resim adı
                var saveLocation = resource + "/wwwroot/UserImages" + imageName;//resim kaydedilir
                var stream = new FileStream(saveLocation, FileMode.Create);//akış
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
            return RedirectToAction("SignIn","Login");
            }
            return View();
        }        
        }
}
