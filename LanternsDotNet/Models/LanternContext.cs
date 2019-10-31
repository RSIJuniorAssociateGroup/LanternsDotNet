using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsDotNet.Models
{
    public class LanternContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=lhf-db.cxl8e44xjnsm.us-east-2.rds.amazonaws.com;Database=lhf-db;user=LHF;password=FABM2019");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LakeTileLakeTileColor>().
                HasKey(x => new { x.LakeTileColorId, x.LakeTileId });

            modelBuilder.Entity<LakeTileLakeTileColor>().
                HasOne<LakeTileColor>(x => x.LakeTileColor).
                WithMany(x => x.LakeTileLakeTileColors).
                HasForeignKey(x => x.LakeTileColorId);

            modelBuilder.Entity<LakeTileLakeTileColor>().
                HasOne<LakeTile>(x => x.LakeTile).
                WithMany(x => x.LakeTileLakeTileColors).
                HasForeignKey(x => x.LakeTileId); 
        }
        
        public DbSet<LakeTile> LakeTiles { get; set; }
        public DbSet<LakeTileColor> LakeTileColor { get; set; }
        public DbSet<LakeTileLakeTileColor> LakeTileLakeTileColors { get; set; }

        public LanternContext(DbContextOptions options): base(options)
        {

        }
       
    }
}
