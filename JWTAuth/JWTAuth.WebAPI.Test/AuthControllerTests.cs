using JWTAuth.WebAPI.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace JWTAuth.WebAPI.Tests;

public class AuthControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public AuthControllerTests(WebApplicationFactory<Program> factory)
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
    public async Task Login_WithValidCredentials_ReturnsOkAndJwtToken()
    {
        // Arrange
        var loginRequest = new LoginModel { Username = "testuser", Password = "password123" };
        var content = new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/auth/login", content);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var responseString = await response.Content.ReadAsStringAsync();
        dynamic responseObject = JsonConvert.DeserializeObject(responseString);
        string token = responseObject?.token;

        Assert.False(string.IsNullOrEmpty(token));
    }

    [Fact]
    public async Task Login_WithInvalidCredentials_ReturnsUnauthorized()
    {
        // Arrange
        var loginRequest = new LoginModel { Username = "", Password = "" };
        var content = new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/auth/login", content);

        // Assert
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }

}