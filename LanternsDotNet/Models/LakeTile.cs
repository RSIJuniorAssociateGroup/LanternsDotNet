using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsDotNet.Models
{
    public class LakeTile
    {
        [Key]

        public Guid LakeTileId { get; set; }
    }
}
