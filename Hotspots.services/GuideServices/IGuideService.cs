using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.models.TroubleshootingGuideVM;

namespace Hotspots.services.GuideServices
{
    public interface IGuideService
    {
        Task<bool>CreateGuide(GuideCreateVM model);
        Task<bool> UpdateGuide (GuideUpdateVM model);
        Task <bool> DeleteGuide(int id);
        Task<GuideDetailVM> GetGuide(int id);
        Task<List<GuideListItem>> GetGuides();
    }
}