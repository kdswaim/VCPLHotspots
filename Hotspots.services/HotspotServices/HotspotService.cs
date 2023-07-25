using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.data.HotspotContext;
using Hotspots.models.HotspotVM;

namespace Hotspots.services.HotspotServices
{
    public class HotspotService : IHotspotService
    {
        private readonly HotspotDBContext _context;
        public Task<bool> CreateHotspot(HotspotCreateVM model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHotspot(int id)
        {
            throw new NotImplementedException();
        }

        public Task<HotspotListItem> GetHotspot(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<HotspotListItem>> GetHotspots()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateHotspot(HotspotEditVM model)
        {
            throw new NotImplementedException();
        }
    }
}