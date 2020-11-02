using AutoMapper;
using LandonAPI.Data;
using LandonAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace LandonAPI.Services
{
    public class DefaultRoomService : IRoomService
    {
        private readonly HotelApiDbContext _context;
        private readonly IMapper _mapper;

        public DefaultRoomService(HotelApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Room> GetRoomAsync(Guid id)
        {
            var entity = await _context.Rooms.SingleOrDefaultAsync(r => r.Id == id);

            if (entity == null)
                return null;

            return _mapper.Map<Room>(entity);
        }
    }
}
