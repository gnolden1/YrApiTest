﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YrApiTest {
    public class WeatherForecastDeserializable {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    public class Geometry {
        public string type { get; set; }
        public float[] coordinates { get; set; }
    }

    public class Properties {
        public Meta meta { get; set; }
        public Timesery[] timeseries { get; set; }
    }

    public class Meta {
        public DateTime updated_at { get; set; }
        public Units units { get; set; }
    }

    public class Units {
        public string air_pressure_at_sea_level { get; set; }
        public string air_temperature { get; set; }
        public string cloud_area_fraction { get; set; }
        public string precipitation_amount { get; set; }
        public string relative_humidity { get; set; }
        public string wind_from_direction { get; set; }
        public string wind_speed { get; set; }
    }

    public class Timesery {
        public DateTime time { get; set; }
        public Data data { get; set; }
    }

    public class Data {
        public Instant instant { get; set; }
        public Next_12_Hours next_12_hours { get; set; }
        public Next_1_Hours next_1_hours { get; set; }
        public Next_6_Hours next_6_hours { get; set; }
    }

    public class Instant {
        public Details details { get; set; }
    }

    public class Details {
        public float air_pressure_at_sea_level { get; set; }
        public float air_temperature { get; set; }
        public float cloud_area_fraction { get; set; }
        public float relative_humidity { get; set; }
        public float wind_from_direction { get; set; }
        public float wind_speed { get; set; }
    }

    public class Next_12_Hours {
        public Summary summary { get; set; }
        public Details1 details { get; set; }
    }

    public class Summary {
        public string symbol_code { get; set; }
    }

    public class Details1 {
    }

    public class Next_1_Hours {
        public Summary1 summary { get; set; }
        public Details2 details { get; set; }
    }

    public class Summary1 {
        public string symbol_code { get; set; }
    }

    public class Details2 {
        public float precipitation_amount { get; set; }
    }

    public class Next_6_Hours {
        public Summary2 summary { get; set; }
        public Details3 details { get; set; }
    }

    public class Summary2 {
        public string symbol_code { get; set; }
    }

    public class Details3 {
        public float precipitation_amount { get; set; }
    }
}
