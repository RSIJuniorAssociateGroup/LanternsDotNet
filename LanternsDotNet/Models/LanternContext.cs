using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsDotNet.Models
{
    public class LanternContext : DbContext
    {
        public DbSet<LakeTile> LakeTiles { get; set; }
        public DbSet<LanternCard> LanternCards { get; set; }

        public LanternContext(DbContextOptions options): base(options)
        {

        }
    }
}
