using HotelApp.Context;
using HotelApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services
{
    public class SettingService
    {
        private readonly HotelAppDbContext _context;

        public SettingService(HotelAppDbContext context)
        {
            _context = context;
        }
        public async Task<Settings> GetSetting()
        {
            Settings? settings = await _context.Settings.FirstOrDefaultAsync();
            return settings;
        }
    }
}
