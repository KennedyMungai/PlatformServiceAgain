using System.ComponentModel.DataAnnotations;

namespace PlatformService.Platform.Models;

public class PlatformModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Publisher { get; set; } = string.Empty;
    [Required]
    public decimal Cost { get; set; }
}