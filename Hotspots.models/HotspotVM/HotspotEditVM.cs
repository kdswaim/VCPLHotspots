using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.data.Entities;

namespace Hotspots.models.HotspotVM
{
    public class HotspotEditVM
    {
        [Required]
        public int HotspotId {get; set;}
        [Required]
        public string HotspotName {get; set;} = null!;
        public string Password {get; set;}
        public string SerialNumber {get; set;}
        public string AdminPassword {get; set;}
        public string MobileNumber {get; set;}
        public string SIM {get; set;}
        public string IMEI {get; set;}
        public string DeviceModelName {get; set;}
        public string SSIDModelName {get; set;}
        public string OriginSSID {get; set;}
        public string OriginPassword {get; set;}
        public string Notes {get; set;}

       // public string OwnerId {get; set;} = null!;

        //public virtual User Owner {get; set;} = null!;
        
    }
}