using Microsoft.AspNetCore.Mvc;

namespace FrontToBackAspNet.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
