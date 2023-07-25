using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotspots.data.Entities
{
    public class TroubleshootingGuide
    {
        public int GuideId {get; set;}
        public int HotspotId {get; set;}
        public string GuideTitle {get; set;}
        public string GuideContent {get; set;}

        public Hotspot Hotspot {get; set;}
    }
}