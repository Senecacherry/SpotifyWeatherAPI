using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIPractice.Models
{
    public class Location
    {
        public string City { get; set; }
        public string State { get; set; }
        public Vector Distance { get; set; }
        public Vector Bearing { get; set; }
    }
}
