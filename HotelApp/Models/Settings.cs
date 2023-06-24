using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Settings:BaseModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [StringLength(1000)]
        public string AboutText { get; set; }
        [Required]
        public int RoomCount { get; set; }
        [Required]
        public int StaffCount { get; set; }
        [Required]
        public int ClientCount { get; set; }
        [Required]
        [StringLength(50)]
        public string DiscoverTitle { get; set; }
        [Required]
        [StringLength(1000)]
        public string DiscoverDesc { get; set; }

        [Required]
        public string VideoLink { get; set; }

    }
}
