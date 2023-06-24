using HotelApp.Models;

namespace HotelApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Slider> ?Sliders { get; set; }
        public IEnumerable<Service> ?Services { get; set; }
        public IEnumerable<Staff> ?Staffs { get; set; }
        public IEnumerable<Room> ?Rooms { get; set; }
        public Settings ?Settings { get; set; }  
    }
}
