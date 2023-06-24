namespace HotelApp.Models
{
    public class RoomSpecification:BaseModel
    {
        public int RoomId { get; set; }
        public int SpecificationId { get; set; }
        public Room Room { get; set; }
        public Specification Specification { get; set; }
    }
}
