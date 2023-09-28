using PlatformService.Platform.Models;

namespace PlatformService.Platform.Repositories.PlatformRepos;


public interface IPlatformRepo
{
    bool SaveChanges();
    IEnumerable<PlatformModel> GetAllPlatforms();
    PlatformModel GetPlatformById(int id);
    void CreatePlatform(PlatformModel platform);
}