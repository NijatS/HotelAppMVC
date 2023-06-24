using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Specification:BaseModel
    {
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Name { get; set; }
        public List<RoomSpecification> RoomSpecifications { get; set; }
    }
}
