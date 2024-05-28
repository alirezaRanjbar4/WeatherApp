namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter the city name:");
            var city = Console.ReadLine();

            var weatherService = new WeatherService();
            var weatherResponse = await weatherService.GetWeatherAsync(city);

            Console.WriteLine($"Weather in {weatherResponse.Name}:");
            Console.WriteLine($"Temperature: {weatherResponse.Main.Temp}°C");
            Console.WriteLine($"Humidity: {weatherResponse.Main.Humidity}%");
            Console.WriteLine($"Description: {weatherResponse.Weather[0].Description}");
        }
    }
}
