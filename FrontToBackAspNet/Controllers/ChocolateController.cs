using Microsoft.AspNetCore.Mvc;

namespace FrontToBackAspNet.Controllers
{
    public class ChocolateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
