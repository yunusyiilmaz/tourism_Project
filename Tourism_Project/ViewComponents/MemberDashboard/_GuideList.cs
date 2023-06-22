using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuideManager _guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = _guideManager.TGetList();
            return View(values);
        }
    }
}
