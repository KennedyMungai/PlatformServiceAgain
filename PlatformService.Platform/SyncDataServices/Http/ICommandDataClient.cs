using PlatformService.Platform.Models.Dtos;

namespace PlatformService.Platform.SyncDataServices.Http;

public interface ICommandDataClient
{
    Task SendPlatformToCommand(PlatformReadDto platform);
}