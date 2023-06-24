using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
