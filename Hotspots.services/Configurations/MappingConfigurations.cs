using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hotspots.data.Entities;
using Hotspots.models.HotspotVM;
using Hotspots.models.TroubleshootingGuideVM;
using Hotspots.models.UserVM;

namespace Hotspots.services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations()
        {
            CreateMap<Hotspot, HotspotCreateVM>().ReverseMap();
            CreateMap<Hotspot, HotspotDetailVM>().ReverseMap();
            CreateMap<Hotspot, HotspotEditVM>().ReverseMap();
            CreateMap<Hotspot, HotspotListItem>().ReverseMap();

            CreateMap<TroubleshootingGuide, GuideCreateVM>().ReverseMap();
            CreateMap<TroubleshootingGuide, GuideDetailVM>().ReverseMap();
            CreateMap<TroubleshootingGuide, GuideListItem>().ReverseMap();
            CreateMap<TroubleshootingGuide, GuideUpdateVM>().ReverseMap();

            CreateMap<User, AuthResponseVM>().ReverseMap();
            CreateMap<User, LoginVM>().ReverseMap();
            CreateMap<User, UserEntityVM>().ReverseMap();
            CreateMap<User, UserRegisterVM>().ReverseMap();
        }
    }
}