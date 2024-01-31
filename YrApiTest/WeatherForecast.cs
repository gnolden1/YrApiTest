using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrApiTest {
    internal class WeatherForecast {
        public DateTimeOffset updated_at { get; set; }
        public double[] coordinates { get; set; }
        public List<TimePoint> timeseries { get; set; }
    }
}
