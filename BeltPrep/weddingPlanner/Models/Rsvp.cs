#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace weddingPlanner.Models;

public class Rsvp
{
    [Key]
    public int RsvpId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int WeddingId { get; set; }
    public User? User { get; set; }
    public Wedding? Wedding { get; set; }
}