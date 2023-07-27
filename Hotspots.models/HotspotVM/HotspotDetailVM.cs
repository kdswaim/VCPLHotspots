using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.data.Entities;

namespace Hotspots.models.HotspotVM
{
    public class HotspotDetailVM
    {
         [Required]
        [Key]
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
        public string SSIDModelName {get; set;}
        [Required]
        public string OriginSSID {get; set;}
        [Required]
        public string OriginPassword {get; set;}
        [Required]
        public string Notes {get; set;}

        ///public string OwnerId {get; set;} = null!;

        ///[ForeignKey(nameof(OwnerId))]

        ///public virtual User Owner {get; set;} = null!;
    }
}