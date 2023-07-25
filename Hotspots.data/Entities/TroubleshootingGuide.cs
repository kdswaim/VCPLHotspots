using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotspots.data.Entities
{
    public class TroubleshootingGuide
    {
        [Key]
        public int GuideId {get; set;}
        public int HotspotId {get; set;}
        public string GuideTitle {get; set;}
        public string GuideContent {get; set;}

        public Hotspot Hotspot {get; set;}
    }
}