using JWTAuth.WebAPI.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace JWTAuth.WebAPI.Tests;

public class WeatherForcastTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;
    private IConfiguration _config;

    public WeatherForcastTests(WebApplicationFactory<Program> factory)
    {
        // Build configuration
        _config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        _client = factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
            });
        }).CreateClient();
    }

    [Fact]
    public async Task GetWeatherForecast_WithValidCredentials_ReturnsWeatherForecasts()
    {
        //Arrange
        var loginModel = new LoginModel { Username = "asd", Password = "asd" };

        var json = JsonSerializer.Serialize(loginModel);
        var content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json);

        var response = await _client.PostAsync("/api/auth/login", content);
        var stringContent = await response.Content.ReadAsStringAsync();


        // Act
        var response2 = await _client.GetAsync("/api/weatherforecast/list");

        // Assert

    }
}