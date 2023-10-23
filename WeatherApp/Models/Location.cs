namespace WeatherApp.NETMAUI.Models
{
    /// <summary>
    /// Represents a geographical location.
    /// Attributes include city name, latitude, longitude, and country.
    /// </summary>
    public class Location
    {
        public string CityName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; }
    }
}
