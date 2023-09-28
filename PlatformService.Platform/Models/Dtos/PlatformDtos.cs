namespace PlatformService.Platform.Models.Dtos;

public class PlatformReadDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public decimal Cost { get; set; }
}

public class PlatformCreateDto
{
    public string Name { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public decimal Cost { get; set; }
}