using Microsoft.AspNetCore.Mvc;

namespace FrontToBackAspNet.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
