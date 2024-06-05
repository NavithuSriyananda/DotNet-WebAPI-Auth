using JWT.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebAPI.JWT.Test
{
    public class WeatherForcastTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public WeatherForcastTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    //services.AddSingleton<IConfiguration>(config);
                });
            }).CreateClient();
        }

        [Fact]
        public async Task GetWeatherForecast_WithValidCredentials_ReturnsWeatherForecasts()
        {
            //Arrange

            // Act
            var response = await _client.GetAsync("/api/weatherforecast/list");

            // Assert

        }
    }
}
