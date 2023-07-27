using AutoMapper;
using Hotspots.data.Entities;
using Hotspots.data.HotspotContext;
using Hotspots.models.HotspotVM;
using Microsoft.EntityFrameworkCore;

namespace Hotspots.services.HotspotServices
{
    public class HotspotService : IHotspotService
    {
        private readonly HotspotDBContext _context;
        private readonly IMapper _mapper;
        public HotspotService(HotspotDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateHotspot(HotspotCreateVM model)
        {
            var entity = _mapper.Map<Hotspot>(model);
            await _context.Hotspots.AddAsync(entity);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<bool> DeleteHotspot(int id)
        {
            var hotspot = await _context.Hotspots.FindAsync(id);
            if (hotspot is null) return false;

            _context.Hotspots.Remove(hotspot);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<HotspotDetailVM> GetHotspot(int id)
        {
            var hotspot = await _context.Hotspots.FindAsync(id);
            if (hotspot is null) return new HotspotDetailVM{};
            return _mapper.Map<HotspotDetailVM>(hotspot);
        }

        public async Task<List<HotspotListItem>> GetHotspots(int id)
        {
            var hotspots = await _context.Hotspots.ToListAsync();
            var HotspotListItem = _mapper.Map<List<HotspotListItem>>(hotspots);
            return HotspotListItem;
        }

        public async Task<bool> UpdateHotspot(HotspotEditVM model)
        {
            var hotspot = await _context.Hotspots.FindAsync(model.HotspotId);
                if (hotspot is null) return false;
                hotspot.HotspotName = model.HotspotName;
                return await _context.SaveChangesAsync() > 0;
        }

        Task<HotspotListItem> IHotspotService.GetHotspot(int id)
        {
            throw new NotImplementedException();
        }
    }
}