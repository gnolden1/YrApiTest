using System.Text.Json;

namespace YrApiTest {
    internal class Program {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("csharpApp");

            Console.WriteLine(
                "Welcome to the Yr API test. This program uses MET's LocationForecast 2.0 API (compact).\n" +
                "Documentation can be found at https://api.met.no/weatherapi/locationforecast/2.0/documentation\n" //+
                //"Enter \"quit\" at any time to quit, and \"help\" for help. (not implemented)" +
                //"Both latitude and longtitude should be entered as decimal numbers."
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
                    HttpResponseMessage response = await client.GetAsync($"https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=60.10&lon=9.58");
                    string responseBody = await response.Content.ReadAsStringAsync();
                    WeatherForecastDeserializable? forecastDeserializable = JsonSerializer.Deserialize<WeatherForecastDeserializable>(responseBody);
                    WeatherForecast forecast = new WeatherForecast(forecastDeserializable);
                    Console.WriteLine(forecast.UpdatedAt);
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