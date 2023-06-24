using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Slider:BaseModel
    {
        [Required]
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Link { get; set; }
        public bool isActive { get; set; }
    }
}
