using Microsoft.EntityFrameworkCore;
using PlatformService.Platform.Data;
using PlatformService.Platform.Repositories.PlatformRepos;
using PlatformService.Platform.SyncDataServices.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PlatformDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("PlatformDbConnString"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("PlatformDbConnString"))); ;
});
builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddHttpClient<ICommandDataClient, HttpCommandDataClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using var scope = app.Services.CreateScope();
var dataContext = scope.ServiceProvider.GetRequiredService<PlatformDbContext>();
dataContext.Database.Migrate();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
