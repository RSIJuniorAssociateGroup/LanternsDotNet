using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsDotNet.Models
{
    public class LakeTileColor
    {
        [Key]

        public Guid LakeTileColorId { get; set; }

        public string Color { get; set; }

        public string URl { get; set; }
        
        public virtual ICollection<LakeTileLakeTileColor> LakeTileLakeTileColors { get; set; }
    }
}
