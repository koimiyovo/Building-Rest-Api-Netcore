using LandonAPI.Models;

namespace LandonAPI.Controllers
{
    internal class RootResponse : Resource
    {
        public Link Rooms { get; set; }
        public Link Info { get; set; }
    }
}