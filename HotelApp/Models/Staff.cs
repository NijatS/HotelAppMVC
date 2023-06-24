namespace HotelApp.Models
{
    public class Staff:BaseModel
    {
        public string FullName { get; set; }
        public string Photo { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public List<Social> Socials { get; set; }
    }
}
