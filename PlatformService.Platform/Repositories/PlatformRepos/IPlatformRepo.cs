using PlatformService.Platform.Models;

namespace PlatformService.Platform.Repositories.PlatformRepos;


public interface IPlatformRepo
{
    Task<bool> SaveChanges();
    Task<IEnumerable<PlatformModel>> GetAllPlatforms();
    Task<PlatformModel> GetPlatformById(Guid id);
    Task CreatePlatform(PlatformModel platform);
}