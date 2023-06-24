using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Room:BaseModel
    {
        [Required]
        public string ?Type { get; set; }
        [Required]
        public string ?Description { get; set; }
        [Required]
        public int Star { get; set; }
        [Required]
        public string Photo { get; set; }
        public List<RoomSpecification> Specifications { get; set; }
        public List<RoomDayCount> RoomDayCounts { get; set; }
    }
}
