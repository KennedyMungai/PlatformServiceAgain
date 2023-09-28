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

    public async Task CreatePlatform(PlatformModel platform)
    {
        try
        {
            await _context.Platforms.AddAsync(platform);
            await SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public async Task<IEnumerable<PlatformModel>> GetAllPlatforms()
    {
        return await _context.Platforms.ToListAsync();
    }

    public async Task<PlatformModel> GetPlatformById(int id)
    {
        return await _context.Platforms.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<bool> SaveChanges()
    {
        return await Task.FromResult(_context.SaveChanges() > 0);
    }
}