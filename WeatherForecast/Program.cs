using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Helpers;
using WeatherForecast.WeatherForcastData;
using static WeatherForecast.WeatherForcastData.WeatherForecastXML;

namespace WeatherForecast
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Weather Forecast | Please type: xml or json");
            string input = Console.ReadLine();

            if (input.Equals("json"))
            {
                await GetJSONData();
            }
            else if (input.Equals("xml"))
            {
                await GetXMLData();
            }
            else
            {
                Console.WriteLine("Weather Forecast type: xml or json");
                Console.ReadLine();
            }
        }

        private static async Task GetJSONData()
        {
            string data = await WeatherForecastCall.GetWeatherForecastJSON();
            var json = JsonConvert.DeserializeObject<WeatherForecastJSON>(data);

            Console.WriteLine("=**** Coordinates ****=");
            Console.WriteLine("  lon: " + json.coord.lon.ToString());
            Console.WriteLine("  lat: " + json.coord.lat.ToString());
            Console.WriteLine("=**** Weather ****=");
            Console.WriteLine("  id: " + json.weather[0].id.ToString());
            Console.WriteLine("  main: " + json.weather[0].main.ToString());
            Console.WriteLine("  description: " + json.weather[0].description.ToString());
            Console.WriteLine("  icon: " + json.weather[0].icon.ToString());
            Console.WriteLine("=**** Main ****=");
            Console.WriteLine("  temp: " + json.weather[0].id.ToString());
            Console.WriteLine("  feels_like: " + json.main.feels_like.ToString());
            Console.WriteLine("  temp_min: " + json.main.temp_min.ToString());
            Console.WriteLine("  temp_max: " + json.main.temp_max.ToString());
            Console.WriteLine("  pressure: " + json.main.pressure.ToString());
            Console.WriteLine("  humidity: " + json.main.humidity.ToString());
            Console.WriteLine("  visibility: " + json.visibility.ToString());
            Console.WriteLine("=**** Wind ****=");
            Console.WriteLine("  speed: " + json.wind.speed.ToString());
            Console.WriteLine("  deg: " + json.wind.deg.ToString());
            Console.WriteLine("=**** Clouds ****=");
            Console.WriteLine("  all: " + json.clouds.all.ToString());
            Console.WriteLine("  dt: " + json.dt.ToString());
            Console.WriteLine("=**** Sys ****=");
            Console.WriteLine("  type: " + json.sys.type.ToString());
            Console.WriteLine("  id: " + json.sys.id.ToString());
            Console.WriteLine("  country: " + json.sys.country.ToString());
            Console.WriteLine("  sunrise: " + json.sys.sunrise.ToString());
            Console.WriteLine("  sunset: " + json.sys.sunset.ToString());
            Console.WriteLine("  timezone: " + json.timezone.ToString());
            Console.WriteLine("  id: " + json.id.ToString());
            Console.WriteLine("  name: " + json.name.ToString());
            Console.WriteLine("  cod: " + json.cod.ToString());

            Console.WriteLine("===========================Success Get JSON=============================");
            Console.ReadLine();

        }


        private static async Task GetXMLData()
        {
            string data = await WeatherForecastCall.GetWeatherForecastXML();
            var xml = WeatherForecastJsonXmlHelper.DeserializeXML<Current>(data);

            Console.WriteLine("***=> City <=***");
            Console.WriteLine(" id: " + xml.city.id.ToString());
            Console.WriteLine(" name: " + xml.city.name.ToString());
            Console.WriteLine(" timezone: " + xml.city.timezone.ToString());
            Console.WriteLine("***=> Sun <=***");
            Console.WriteLine(" rise: " + xml.city.sun.rise.ToString());
            Console.WriteLine(" set: " + xml.city.sun.set.ToString());
            Console.WriteLine("***=> Temperature <=***");
            Console.WriteLine(" value: " + xml.temperature.value.ToString());
            Console.WriteLine(" min: " + xml.temperature.min.ToString());
            Console.WriteLine(" max: " + xml.temperature.max.ToString());
            Console.WriteLine("***=> Feels Like <=***");
            Console.WriteLine(" value: " + xml.feels_like.value.ToString());
            Console.WriteLine(" unit: " + xml.feels_like.unit.ToString());
            Console.WriteLine("***=> Humidity <=***");
            Console.WriteLine(" value: " + xml.humidity.value.ToString());
            Console.WriteLine(" unit: " + xml.humidity.unit.ToString());
            Console.WriteLine("***=> Pressure <=***");
            Console.WriteLine(" value: " + xml.pressure.value.ToString());
            Console.WriteLine(" unit: " + xml.pressure.unit.ToString());
            Console.WriteLine("***=> Wind <=***");
            Console.WriteLine(" ***=> Speed <=***");
            Console.WriteLine(" value: " + xml.wind.speed.value.ToString());
            Console.WriteLine(" unit: " + xml.wind.speed.unit.ToString());
            Console.WriteLine(" name: " + xml.wind.speed.name.ToString());
            Console.WriteLine("***=> Direction <=***");
            Console.WriteLine(" value: " + xml.wind.direction.value.ToString());
            Console.WriteLine(" code: " + xml.wind.direction.code.ToString());
            Console.WriteLine(" name: " + xml.wind.direction.name.ToString());
            Console.WriteLine("***=> Clouds <=***");
            Console.WriteLine(" value: " + xml.clouds.value.ToString());
            Console.WriteLine("***=> Visibility <=***");
            Console.WriteLine(" value: " + xml.visibility.value.ToString());
            Console.WriteLine("***=> Precipitation <=***");
            Console.WriteLine(" mode: " + xml.precipitation.mode.ToString());
            Console.WriteLine("***=> Weather <=***");
            Console.WriteLine(" number: " + xml.weather.number.ToString());
            Console.WriteLine(" value: " + xml.weather.value.ToString());
            Console.WriteLine(" icon: " + xml.weather.icon.ToString());
            Console.WriteLine("***=> Last Update <=***");
            Console.WriteLine(" value: " + xml.lastupdate.value.ToString());

            Console.WriteLine("===========================Success Get XML=============================");
            Console.ReadLine();
        }


    }
}
