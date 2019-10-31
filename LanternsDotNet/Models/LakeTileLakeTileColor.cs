using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsDotNet.Models
{
    public class LakeTileLakeTileColor
    {
        public int LakeTileLakeTileColorId { get; set; }
        public Guid LakeTileId { get; set; }
        public Guid LakeTileColorId { get; set; }

        public virtual LakeTile LakeTile { get; set; }
        public virtual LakeTileColor LakeTileColor { get; set; }

        

        
    }
}
