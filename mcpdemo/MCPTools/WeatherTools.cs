using ModelContextProtocol.Server;
using System.ComponentModel;
using mcpdemo.Models;
using Microsoft.Extensions.DependencyInjection;
using mcpdemo.Services;



namespace mcpdemo.MCPTools{
    
[McpServerToolType]
public static class WeatherTool
{
    [McpServerTool]
    [Description("Gets the weather information from a external API using a specific city.")]
    public static async Task<WeatherRequest> GetWeatherByCity(
        [Description("The city to retrieve weather information for")] string city,
        IServiceProvider serviceProvider) // Can inject services here
    {
        // Resolve the service to make the API call
        var weatherService = serviceProvider.GetRequiredService<WeatherService>();
        return await weatherService.GetWeatherByCityAsync(city);
    }

    [McpServerTool]
    [Description("Gets the weather information from a external API using a specific city.")]
    public static async Task<WeatherRequest> GetWeatherForecastByCity(
        [Description("The city to retrieve weather information for")] string city,
        [Description("The number of days to forecast")] int days,
        [Description("The hourly interval")] int hourlyInterval,
        IServiceProvider serviceProvider) // Can inject services here
    {
        // Resolve the service to make the API call
        var weatherService = serviceProvider.GetRequiredService<WeatherService>();
        return await weatherService.GetWeatherForecastByCityAsync(city, days, hourlyInterval);
    }
}
}