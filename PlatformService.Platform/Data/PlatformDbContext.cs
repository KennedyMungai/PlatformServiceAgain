using Bogus;
using Microsoft.EntityFrameworkCore;
using PlatformService.Platform.Models;

namespace PlatformService.Platform.Data;


public class PlatformDbContext : DbContext
{
    public PlatformDbContext(DbContextOptions<PlatformDbContext> options) : base(options)
    {

    }

    public DbSet<PlatformModel> Platforms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var platforms = new Faker<PlatformModel>()
                                .RuleFor(m => m.Id, f => f.IndexFaker + 1)
                                .RuleFor(m => m.Name, f => f.Commerce.ProductName())
                                .RuleFor(m => m.Publisher, f => f.Company.CompanyName())
                                .RuleFor(m => m.Cost, f => f.Random.Int(1, 100));

        modelBuilder
            .Entity<PlatformModel>()
            .HasData(platforms.Generate(1000));
    }
}