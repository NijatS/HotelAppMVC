using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
