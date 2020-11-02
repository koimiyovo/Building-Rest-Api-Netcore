using LandonAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LandonAPI.Data
{
    public class HotelApiDbContext : DbContext
    {
        public HotelApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RoomEntity> Rooms { get; set; }
    }
}
