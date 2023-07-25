using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotspots.models.TroubleshootingGuideVM
{
    public class GuideDetailVM
    {
        public int GuideId {get; set;}
        public int HotspotId {get; set;}
        public string GuideTitle {get; set;}
        public string GuideContent {get; set;}
    }
}