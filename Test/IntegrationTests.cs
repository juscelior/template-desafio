using System.Net;
using Test.Fixture;

namespace Test;

public class IntegrationTests: IClassFixture<WebApplicationFixture<Program>>
{
    private readonly HttpClient _httpClient;

    public IntegrationTests(WebApplicationFixture<Program> factory)
    {
        _httpClient = factory.CreateClient();
    }

    [Fact]
    public async Task Test_desafio_04_get_return_200()
    {
        //Esta chamada esta retornando erro 404, mas era para esta retornando 200
        var response = await _httpClient.GetAsync("/WeatherForecast/GetWeatherForecast");

        string json = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("summary", json);
    }
}