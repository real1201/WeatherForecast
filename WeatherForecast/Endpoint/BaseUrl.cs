namespace WeatherForecast.Endpoint
{
    public static class BaseUrl
    {
        private static string baseUrl = "https://api.openweathermap.org/";
        public static string weatherUrl = baseUrl + "data/2.5/weather?";
    }
}
