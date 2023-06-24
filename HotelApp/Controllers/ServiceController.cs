using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
