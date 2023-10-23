namespace WeatherApp.NETMAUI.Models
{
    /// <summary>
    /// Represents the weather data for a specific location and time.
    /// Attributes include temperature, weather condition, humidity, and wind speed.
    /// </summary>
    public class Weather
    {
        public double Temperature { get; set; }
        public string WeatherCondition { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
    }
}