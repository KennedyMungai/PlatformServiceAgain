using System.Text;
using System.Text.Json;
using PlatformService.Platform.Models.Dtos;

namespace PlatformService.Platform.SyncDataServices.Http;


public class CommandDataClient : ICommandDataClient
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public CommandDataClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task SendPlatformToCommand(PlatformReadDto platform)
    {
        var httpContent = new StringContent(
            JsonSerializer.Serialize(platform),
            Encoding.UTF8,
            "application/json"
        );

        var response = await _httpClient.PostAsync("http://localhost:5010/api/Commands/", httpContent);

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Sync POST to CommandService was OK");
        }
        else
        {
            Console.WriteLine("Sync POST to CommandService was NOT OK");
        }
    }
}