using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrApiTest {
    internal class TimePoint {
        public DateTimeOffset time { get; set; }
        public double air_pressure_at_sea_level { get; set; }
        public double air_temperature { get; set; }
        public double cloud_area_fraction { get; set; }
        public double relative_humidity { get; set; }
        public double wind_from_direction { get; set; }
        public double wind_speed { get; set; }
    }
}
