using System.Text.Json;

namespace YrApiTest {
    internal class Program {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("csharpApp");

            Console.WriteLine(
                "Welcome to the Yr API test. This program uses MET's LocationForecast 2.0 API (compact).\n" +
                "Documentation can be found at https://api.met.no/weatherapi/locationforecast/2.0/documentation\n" +
                "Enter \"quit\" at any time to quit, and \"help\" for help." +
                "Both latitude and longtitude should be entered as decimal numbers."
            );

            while (true)
            {
                /*Console.Write("Latitude: ");
                string? latString = Console.ReadLine();

                onsole.Write("Longtitude: ");
                string? lonString = Console.ReadLine();

                if (latString == null || lonString == null)
                {
                    Console.WriteLine("Latitude and longtitude cannot be null. Try again.");
                    continue;
                }*/
                Console.WriteLine("Press Enter to fetch weather.");
                Console.ReadLine();

                try
                {
                    /*double lat = Double.Parse(latString);
                    double lon = Double.Parse(lonString);
                    HttpResponseMessage response = await client.GetAsync($"https://api.met.no/weatherapi/locationforecast/2.0/compact?lat={lat}&lon={lon}");*/
                    //HttpResponseMessage response = await client.GetAsync($"https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=60.10&lon=9.58");
                    //string responseBody = await response.Content.ReadAsStringAsync();
                    //Console.WriteLine(responseBody);
                    string responseBody = @"
{
  ""type"": ""Feature"",
  ""geometry"": {
    ""type"": ""Point"",
    ""coordinates"": [
      9.58,
      60.1,
      496
    ]
  },
  ""properties"": {
    ""meta"": {
      ""updated_at"": ""2024-01-31T12:37:23Z"",
      ""units"": {
        ""air_pressure_at_sea_level"": ""hPa"",
        ""air_temperature"": ""celsius"",
        ""cloud_area_fraction"": ""%"",
        ""precipitation_amount"": ""mm"",
        ""relative_humidity"": ""%"",
        ""wind_from_direction"": ""degrees"",
        ""wind_speed"": ""m/s""
      }
    },
    ""timeseries"": [
      {
        ""time"": ""2024-01-31T13:00:00Z"",
        ""data"": {
          ""instant"": {
            ""details"": {
              ""air_pressure_at_sea_level"": 1005.2,
              ""air_temperature"": -0.8,
              ""cloud_area_fraction"": 91,
              ""relative_humidity"": 87.8,
              ""wind_from_direction"": 145.1,
              ""wind_speed"": 4.2
            }
          },
          ""next_12_hours"": {
            ""summary"": {
              ""symbol_code"": ""lightsleetshowers_day""
            },
            ""details"": {}
          },
          ""next_1_hours"": {
            ""summary"": {
              ""symbol_code"": ""cloudy""
            },
            ""details"": {
              ""precipitation_amount"": 0
            }
          },
          ""next_6_hours"": {
            ""summary"": {
              ""symbol_code"": ""sleet""
            },
            ""details"": {
              ""precipitation_amount"": 1.1
            }
          }
        }
      },
{
        ""time"": ""2024-01-31T14:00:00Z"",
        ""data"": {
          ""instant"": {
            ""details"": {
              ""air_pressure_at_sea_level"": 1003.2,
              ""air_temperature"": -0.1,
              ""cloud_area_fraction"": 94,
              ""relative_humidity"": 89.7,
              ""wind_from_direction"": 140.8,
              ""wind_speed"": 4.3
            }
          },
          ""next_12_hours"": {
            ""summary"": {
              ""symbol_code"": ""lightsleetshowers_day""
            },
            ""details"": {}
          },
          ""next_1_hours"": {
            ""summary"": {
              ""symbol_code"": ""cloudy""
            },
            ""details"": {
              ""precipitation_amount"": 0
            }
          },
          ""next_6_hours"": {
            ""summary"": {
              ""symbol_code"": ""sleet""
            },
            ""details"": {
              ""precipitation_amount"": 1.4
            }
          }
        }
      },
{
        ""time"": ""2024-02-10T12:00:00Z"",
        ""data"": {
          ""instant"": {
            ""details"": {
              ""air_pressure_at_sea_level"": 1004.7,
              ""air_temperature"": -6.9,
              ""cloud_area_fraction"": 100,
              ""relative_humidity"": 72.7,
              ""wind_from_direction"": 73,
              ""wind_speed"": 0.8
            }
          }
        }
      }
    ]
  }
}
";
                    WeatherForecast? forecast = JsonSerializer.Deserialize<WeatherForecast>(responseBody);
                    Console.WriteLine(forecast.updated_at);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }
        }
    }
}