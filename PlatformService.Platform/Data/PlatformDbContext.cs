using Microsoft.EntityFrameworkCore;
using PlatformService.Platform.Models;

namespace PlatformService.Platform.Data;


public class PlatformDbContext : DbContext
{
    public PlatformDbContext(DbContextOptions<PlatformDbContext> options) : base(options)
    {

    }

    public DbSet<PlatformModel> Platforms { get; set; }
}