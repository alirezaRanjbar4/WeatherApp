using System.Text.Json.Serialization;

namespace WeatherApp
{
    public class WeatherResponse
    {
        [JsonPropertyName("main")]
        public Main Main { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("weather")]
        public Weather[] Weather { get; set; }
    }

    public class Main
    {
        [JsonPropertyName("temp")]
        public float Temp { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
