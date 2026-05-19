using System.ComponentModel.DataAnnotations;

namespace BusinessScheduler.Api.Models;

public class Appointment
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int ResourceId { get; set; }
    public Resource Resource { get; set; } = null!;
    public string UserId { get; set; } = string.Empty;
    public bool IsConfirmed { get; set; }
    public string Language { get; set; } = "en"; // en/tr
}