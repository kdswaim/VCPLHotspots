using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.models.HotspotVM;

namespace Hotspots.services.HotspotServices
{
    public interface IHotspotService
    {
        Task<bool>CreateHotspot(HotspotCreateVM model);
        Task<bool>UpdateHotspot(HotspotEditVM model);
        Task <bool> DeleteHotspot (int id);
        Task<HotspotListItem>GetHotspot(int id);
        Task<List<HotspotListItem>> GetHotspots();
    }
}