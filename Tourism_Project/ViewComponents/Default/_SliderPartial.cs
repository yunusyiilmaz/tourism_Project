using Microsoft.AspNetCore.Mvc;

namespace Tourism_Project.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
