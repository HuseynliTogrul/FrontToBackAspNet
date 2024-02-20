using FrontToBackAspNet.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackAspNet.Controllers
{
    public class HomeController : Controller
    {
        readonly ChocoDbContext _chocoDbContext;

        public HomeController(ChocoDbContext chocoDbContext)
        {
            _chocoDbContext = chocoDbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
