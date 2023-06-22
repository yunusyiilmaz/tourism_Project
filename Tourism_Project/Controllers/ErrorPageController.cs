using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int Code)
        {
            return View();
        }
    }
}
