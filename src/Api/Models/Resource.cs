using System.ComponentModel.DataAnnotations;

namespace BusinessScheduler.Api.Models;

public class Resource
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty; // Room, Equipment, etc.
    public bool IsAvailable { get; set; } = true;
}