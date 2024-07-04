using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherForecast.Helpers
{
    public class WeatherForecastCall
    {
        private static readonly HttpClient client = new HttpClient();
        private static HttpResponseMessage response;

        public static async Task<string> GetWeatherForecastJSON()
        {
            try {
                var jsonUrl = WeatherForecastJsonXmlHelper.GetWeatherDataJsonUrl();
               response = await client.GetAsync(jsonUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch(Exception e) 
            {
                Console.WriteLine("Error: Get Weather JSON: " + e.ToString());
                return e.ToString();
            }
        }

        public static async Task<string> GetWeatherForecastXML()
        {
            try
            {
                var xmlUrl = WeatherForecastJsonXmlHelper.GetWeatherDataXMLUrl();
                response = await client.GetAsync(xmlUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Get Weather JSON: " + e.ToString());
                return e.ToString();
            }
        }
    }
}
