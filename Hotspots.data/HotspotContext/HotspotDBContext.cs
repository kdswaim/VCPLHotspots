using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotspots.data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotspots.data.HotspotContext
{
    public class HotspotDBContext : IdentityDbContext<User>
    {
        public HotspotDBContext(DbContextOptions options):base(options){}
        
        public DbSet<Hotspot> Hotspots { get; set; }

        public DbSet <TroubleshootingGuide> Guide {get; set;}
        }
    }
