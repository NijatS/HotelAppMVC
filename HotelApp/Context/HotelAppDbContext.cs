using HotelApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Context
{
    public class HotelAppDbContext:DbContext
    {
        public HotelAppDbContext(DbContextOptions<HotelAppDbContext> options): base(options)
        {
            
        }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<DayCount> DayCounts { get; set; }
        public DbSet<RoomDayCount> RoomDayCounts { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<RoomSpecification> RoomSpecifications { get; set; }


    }
}
