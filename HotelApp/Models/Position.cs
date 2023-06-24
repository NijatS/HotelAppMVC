namespace HotelApp.Models
{
    public class Position:BaseModel
    {
        public string Name { get; set; }
        public List<Staff> Staffs { get; set;}
    }
}
