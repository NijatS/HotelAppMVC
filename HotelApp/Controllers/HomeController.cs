using HotelApp.Context;
using HotelApp.Models;
using HotelApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HotelAppDbContext _context;

        public HomeController(HotelAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index ()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Sliders = await _context.Slider.Where(x => !x.IsDeleted).ToListAsync();
            homeViewModel.Services = await _context.Service.Where(x => !x.IsDeleted).ToListAsync();
            homeViewModel.Settings = await _context.Settings.FirstOrDefaultAsync();
            homeViewModel.Staffs = await _context.Staffs.Where(x => !x.IsDeleted)
                .Include(x=> x.Position)
                .Include(x=>x.Socials).ToListAsync();
            homeViewModel.Rooms = await _context.Rooms.Where(x => !x.IsDeleted)
                .Include(x => x.Specifications)
                   .ThenInclude(x => x.Specification)
                .Include(x => x.RoomDayCounts)
                   .ThenInclude(x => x.DayCount)
                .ToListAsync();
            return View(homeViewModel);
        }
        #region Position
        //public async Task<IActionResult> CreatePosition()
        //{
        //    List<Position> positions = new List<Position> { 
        //    new Position{
        //        Name = "Designer",
        //        CreatedDate = DateTime.Now,
        //        IsDeleted = false,
        //    },
        //    new Position{
        //        Name = "Singer",
        //        CreatedDate = DateTime.Now,
        //        IsDeleted = false,
        //    },
        //    new Position{
        //        Name = "Programmer",
        //        CreatedDate = DateTime.Now,
        //        IsDeleted = false,
        //    }};
        //    await _context.Positions.AddRangeAsync(positions);
        //   await  _context.SaveChangesAsync();

        //    return Json("Ok");
        //}
        #endregion
        #region Staff
        //public async Task<IActionResult> CreateStaff()
        //{

        //    Staff staff1 = new Staff
        //    {
        //        FullName = "Nijat Soltanov",
        //        CreatedDate = DateTime.Now,
        //        PositionId = 3,
        //        Photo = "team-1.jpg",
        //        IsDeleted = false
        //    };
        //    Staff staff2 = new Staff {
        //        FullName = "Niyameddin Musayev",
        //        CreatedDate = DateTime.Now,
        //        PositionId = 2,
        //        Photo = "team-2.jpg",
        //        IsDeleted = false,
        //    };
        //    Staff staff3 = new Staff
        //    {
        //        FullName = "Mahmud Baba",
        //        CreatedDate = DateTime.Now,
        //        PositionId = 1,
        //        Photo = "team-3.jpg",
        //        IsDeleted = false
        //    };

        //    List<Social> socials = new List<Social>
        //    {
        //            new Social
        //            {
        //                CreatedDate = DateTime.Now,
        //                Icon = "<i class='fab fa-facebook-f'></i>",
        //                Link = "https://www.facebook.com/nicat.soltanov.940",
        //                Staff = staff1
        //            },
        //            new Social
        //            {
        //                CreatedDate = DateTime.Now,
        //                Icon = "<i class='fab fa-twitter'></i>",
        //                Link = "https://www.facebook.com/nicat.soltanov.940",
        //                Staff = staff1

        //            },
        //            new Social
        //            {
        //                CreatedDate = DateTime.Now,
        //                Icon = "<i class='fab fa-instagram'></i>",
        //                Link = "https://www.facebook.com/nicat.soltanov.940",
        //                Staff = staff1
        //            },
        //            new Social
        //            {
        //                CreatedDate = DateTime.Now,
        //                Icon = "<i class='fab fa-facebook-f'></i>",
        //                Link = "https://www.facebook.com/nicat.soltanov.940",
        //                Staff = staff2

        //            },
        //            new Social
        //            {
        //                CreatedDate = DateTime.Now,
        //                Icon = "<i class='fab fa-facebook-f'></i>",
        //                Link = "https://www.facebook.com/nicat.soltanov.940",
        //                Staff = staff3

        //            },
        //            new Social
        //            {
        //                CreatedDate = DateTime.Now,
        //                Icon = "<i class='fab fa-twitter'></i>",
        //                Staff = staff2,
        //                Link = "https://www.facebook.com/nicat.soltanov.940",
        //            },
        //                          new Social
        //            {
        //                CreatedDate = DateTime.Now,
        //                Icon = "<i class='fab fa-instagram'></i>",
        //                Staff = staff2,
        //                Link = "https://www.facebook.com/nicat.soltanov.940",
        //            },
        //    };
        //    await _context.Staffs.AddAsync(staff1);
        //    await _context.Staffs.AddAsync(staff2);
        //    await _context.Staffs.AddAsync(staff3);
        //    await _context.Socials.AddRangeAsync(socials);
        //    await _context.SaveChangesAsync();

        //    return Json("Ok");
        //}
        #endregion
    }
}
