using System.Text.Json;

namespace WeatherApp
{
    public class WeatherService
    {
        private static readonly HttpClient client = new HttpClient();
        private const string ApiKey = "your_api_key"; // Replace with your actual API key
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather";

        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {
            var url = $"{BaseUrl}?q={city}&appid={ApiKey}&units=metric";
            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var weatherResponse = JsonSerializer.Deserialize<WeatherResponse>(responseBody);

            return weatherResponse;
        }
    }
}
