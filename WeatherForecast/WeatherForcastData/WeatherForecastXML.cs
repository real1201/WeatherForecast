using System.Xml.Serialization;

namespace WeatherForecast.WeatherForcastData
{
    public class WeatherForecastXML
    {
        [XmlRoot(ElementName = "current")]
        public class Current
        {
            [XmlElement(ElementName = "city")]
            public City city { get; set; }

            [XmlElement(ElementName = "temperature")]
            public Temperature temperature { get; set; }

            [XmlElement(ElementName = "feels_like")]
            public FeelLike feels_like { get; set; }

            [XmlElement(ElementName = "humidity")]
            public Humidity humidity { get; set; }

            [XmlElement(ElementName = "pressure")]
            public Pressure pressure { get; set; }

            [XmlElement(ElementName = "wind")]
            public Wind wind { get; set; }

            [XmlElement(ElementName = "clouds")]
            public Clouds clouds { get; set; }

            [XmlElement(ElementName = "visibility")]
            public Visibility visibility { get; set; }

            [XmlElement(ElementName = "precipitation")]
            public Precipitation precipitation { get; set; }

            [XmlElement(ElementName = "weather")]
            public Weather weather { get; set; }

            [XmlElement(ElementName = "lastupdate")]
            public LastUpdate lastupdate { get; set; }

        }

        [XmlRoot(ElementName = "city")]
        public class City
        {
            [XmlAttribute(AttributeName = "id")]
            public int id { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string name { get; set; }

            [XmlElement(ElementName = "coord")]
            public Coord coord { get; set; }


            [XmlAttribute(AttributeName = "country")]
            public string country { get; set; }

            [XmlAttribute(AttributeName = "timezone")]
            public int timezone { get; set; }

            [XmlElement(ElementName = "sun")]
            public Sun sun { get; set; }
        }


        [XmlRoot(ElementName = "coord")]
        public class Coord
        {
            [XmlAttribute(AttributeName = "lon")]
            public double lon { get; set; }


            [XmlAttribute(AttributeName = "lat")]
            public double lat { get; set; }
        }

        [XmlRoot(ElementName = "sun")]
        public class Sun
        {
            [XmlAttribute(AttributeName = "rise")]
            public string rise { get; set; }
            [XmlAttribute(AttributeName = "set")]
            public string set { get; set; }
        }

        [XmlRoot(ElementName = "temperature")]
        public class Temperature
        {
            [XmlAttribute(AttributeName = "value")]
            public double value { get; set; }
            [XmlAttribute(AttributeName = "min")]
            public double min { get; set; }
            [XmlAttribute(AttributeName = "max")]
            public double max { get; set; }
            [XmlAttribute(AttributeName = "unit")]
            public string unit { get; set; }
        }

        [XmlRoot(ElementName = "feels_like")]
        public class FeelLike
        {
            [XmlAttribute(AttributeName = "value")]
            public double value { get; set; }

            [XmlAttribute(AttributeName = "unit")]
            public string unit { get; set; }
        }



        [XmlRoot(ElementName = "humidity")]
        public class Humidity : FeelLike
        {
        }

        [XmlRoot(ElementName = "pressure")]
        public class Pressure : FeelLike
        {
        }

        [XmlRoot(ElementName = "wind")]
        public class Wind
        {
            [XmlElement(ElementName = "speed")]
            public Speed speed { get; set; }

            [XmlAttribute(AttributeName = "gusts")]
            public string gusts { get; set; }

            [XmlElement(ElementName = "direction")]
            public Direction direction { get; set; }
        }

        [XmlRoot(ElementName = "speed")]
        public class Speed : FeelLike
        {
            [XmlAttribute("name")]
            public string name { get; set; }
        }

        [XmlRoot(ElementName = "direction")]
        public class Direction
        {
            [XmlAttribute(AttributeName = "value")]
            public double value { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string name { get; set; }
            [XmlAttribute(AttributeName = "code")]
            public string code { get; set; }
        }

        [XmlRoot(ElementName = "clouds")]
        public class Clouds
        {
            [XmlAttribute(AttributeName = "value")]
            public double value { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string name { get; set; }
        }

        [XmlRoot(ElementName = "visibility")]
        public class Visibility
        {
            [XmlAttribute(AttributeName = "value")]
            public int value { get; set; }
        }

        [XmlRoot(ElementName = "precipitation")]
        public class Precipitation
        {
            [XmlAttribute(AttributeName = "mode")]
            public string mode { get; set; }
        }

        [XmlRoot(ElementName = "weather")]
        public class Weather
        {
            [XmlAttribute(AttributeName = "number")]
            public int number { get; set; }
            [XmlAttribute(AttributeName = "value")]
            public string value { get; set; }

            [XmlAttribute(AttributeName = "icon")]
            public string icon { get; set; }
        }

        [XmlRoot(ElementName = "lastupdate")]
        public class LastUpdate
        {
            [XmlAttribute(AttributeName = "value")]
            public string value { get; set; }
        }
    }
}
