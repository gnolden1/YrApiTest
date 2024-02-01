using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrApiTest {
    internal class WeatherForecast {
        public DateTime UpdatedAt { get; set; }
        public WeatherForecast(WeatherForecastDeserializable rawForecast)
        {
            UpdatedAt = rawForecast.properties.meta.updated_at;
        }
    }
}
