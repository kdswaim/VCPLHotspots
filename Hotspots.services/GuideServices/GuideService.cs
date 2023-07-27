using System.Security.Claims;
using AutoMapper;
using Hotspots.data.Entities;
using Hotspots.data.HotspotContext;
using Hotspots.models.TroubleshootingGuideVM;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Hotspots.services.GuideServices
{
    public class GuideService : IGuideService
    {
        private readonly HotspotDBContext _context;
        private readonly IMapper _mapper;
        private readonly int _userid;
        public GuideService(IHttpContextAccessor httpContextAccesssor, HotspotDBContext context, IMapper mapper)
        {
            var userClaims = httpContextAccesssor.HttpContext.User.Identity as ClaimsIdentity;
            var value = userClaims?.FindFirst("id")?.Value;
            var validId = int.TryParse(value, out _userid);

        if (!validId)
        throw new Exception("Attempted to build GuideService without User Id claim.");
            _context = context;
            _mapper = mapper;
        }

        public GuideService(HotspotDBContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateGuide(GuideCreateVM model)
        {
            var guide = _mapper.Map<TroubleshootingGuide>(model);
            _context.Guide.Add(guide);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteGuide(int id)
        {
            var guide = await _context.Guide.FindAsync(id);
            _context.Guide.Remove(guide);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;

        }

        public async Task<GuideDetailVM> GetGuide(int id)
        {
            var guide = await _context.Guide.FindAsync(id);
            if(guide is null) return new GuideDetailVM();
            var guideDetail = _mapper.Map<GuideDetailVM>(guide);
            return guideDetail;
        }

        public async Task<List<GuideListItem>> GetGuides()
        {
            var guides = await _context.Guide.ToListAsync();
            var GuideListItem = _mapper.Map<List<GuideListItem>>(guides);
            return GuideListItem;
        }

        public Task<bool> UpdateGuide(GuideUpdateVM model)
        {
            throw new NotImplementedException();
        }
    }
}