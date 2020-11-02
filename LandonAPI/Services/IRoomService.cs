using LandonAPI.Models;
using System;
using System.Threading.Tasks;

namespace LandonAPI.Services
{
    public interface IRoomService
    {
        Task<Room> GetRoomAsync(Guid id);
    }
}
