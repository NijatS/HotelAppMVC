using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class DayCount:BaseModel
    {
        [Required]
        public string Routine { get; set; }
        public List<RoomDayCount> RoomDayCounts { get; set; }
    }
}
