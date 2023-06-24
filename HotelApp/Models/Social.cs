namespace HotelApp.Models
{
    public class Social:BaseModel
    {
        public string Icon { get; set; }
        public string Link { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
