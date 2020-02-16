using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIPractice.Models
{
    public class RelativeLocation
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
    }
}
