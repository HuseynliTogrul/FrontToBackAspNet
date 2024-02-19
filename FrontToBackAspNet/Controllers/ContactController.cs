using Microsoft.AspNetCore.Mvc;

namespace FrontToBackAspNet.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
