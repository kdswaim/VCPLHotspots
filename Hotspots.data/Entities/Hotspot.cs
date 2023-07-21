using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotspots.data.Entities
{
    public class Hotspot
    {
        [Required]
        public int HotspotId {get; set;}
        [Required]
        public string HotspotName {get; set;}
        [Required]
        public string Password {get; set;}
        [Required]
        public string SerialNumber {get; set;}
        [Required]
        public string AdminPassword {get; set;}
        [Required]
        public string MobileNumber {get; set;}
        [Required]
        public string SIM {get; set;}
        [Required]
        public string IMEI {get; set;}
        [Required]
        public string DeviceModelName {get; set;}
        [Required]
        public string SSID {get; set;}
        [Required]
        public string OriginalSSID {get; set;}
        [Required]
        public string OriginalPassword {get; set;}
        [Required]
        public string Notes {get; set}
    }
}