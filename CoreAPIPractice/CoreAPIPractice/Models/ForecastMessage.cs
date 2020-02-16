using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIPractice.Models
{
    public class ForecastMessage
    {
        public int Id { get; set; }
        public string ForecastOffice { get; set; }
        public string Forecast { get; set; }
        public string ForecastHourly { get; set; }
        public RelativeLocation RelativeLocation { get; set; }
        public Location Location { get; set; }
    }
}
