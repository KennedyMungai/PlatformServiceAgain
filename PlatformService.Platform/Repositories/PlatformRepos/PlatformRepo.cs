using Microsoft.EntityFrameworkCore;
using PlatformService.Platform.Data;
using PlatformService.Platform.Models;

namespace PlatformService.Platform.Repositories.PlatformRepos;


public class PlatformRepo : IPlatformRepo
{
    private readonly PlatformDbContext _context;

    public PlatformRepo(PlatformDbContext context)
    {
        _context = context;
    }

    public Task CreatePlatform(PlatformModel platform)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<PlatformModel>> GetAllPlatforms()
    {
        return await _context.Platforms.ToListAsync();
    }

    public Task<PlatformModel> GetPlatformById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> SaveChanges()
    {
        return await Task.FromResult(_context.SaveChanges() > 0);
    }
}