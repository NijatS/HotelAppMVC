using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class RoomDayCount:BaseModel
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int DayCountId { get; set; }
        public DayCount DayCount { get; set; }  
        [Required]
        [Range(0, 9999999999999999.99)]
        public double Price { get; set; }
        
    }
}
