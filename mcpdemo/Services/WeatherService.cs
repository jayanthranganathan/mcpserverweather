using System.Net.Http.Json; 
using System.Threading.Tasks;
using mcpdemo.Models;

namespace mcpdemo.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherRequest> GetWeatherByCityAsync(string city)
        {
            // Consuming a public API for demonstration
            var weatherInfo = await _httpClient.GetFromJsonAsync<WeatherRequest>($"https://api.weatherstack.com/current?access_key=a85b886d75aa6001e3628775ed0182a8&query={city}");
            return weatherInfo ?? new WeatherRequest();
        }

        public async Task<WeatherRequest> GetWeatherForecastByCityAsync(string city, int days, int hourlyInterval)
        {
            // Consuming a public API for demonstration
            var weatherInfo = await _httpClient.GetFromJsonAsync<WeatherRequest>($"https://api.weatherstack.com/forecast?access_key=a85b886d75aa6001e3628775ed0182a8&query={city}&forecast_days={days}&hourly={hourlyInterval}");
            return weatherInfo ?? new WeatherRequest();
        }
    }
}