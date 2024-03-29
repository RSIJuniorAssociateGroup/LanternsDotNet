﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanternsDotNet.Models
{
    public class LakeTile
    {
        [Key]

        public Guid LakeTileId { get; set; }
       
        public int LakeTileLakeTileColor { get; set; }

        public virtual ICollection<LakeTileLakeTileColor> LakeTileLakeTileColors { get; set; }
    }
}