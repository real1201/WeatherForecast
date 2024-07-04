using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WeatherForecast.Endpoint;

namespace WeatherForecast.Helpers
{
    public static class WeatherForecastJsonXmlHelper
    {
        private static string GetApiKey()
        {
            return ConfigurationManager.AppSettings["apikey"];
        }

        public static string GetWeatherDataJsonUrl()
        {
            return $@"{BaseUrl.weatherUrl}q=London&appid={GetApiKey()}";
        }

        public static string GetWeatherDataXMLUrl()
        {
            return $@"{BaseUrl.weatherUrl}q=London&mode=xml&appid={GetApiKey()}";
        }

        public static T DeserializeXML<T>(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader sb = new StringReader(xml))
            {
                return (T)serializer.Deserialize(sb);
            }
        }
    }
}
