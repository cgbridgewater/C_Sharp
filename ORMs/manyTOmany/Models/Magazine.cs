#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace manyTOmany.Models;
public class Magazine
{
    [Key]
    public int MagazineId { get; set; }
    public string Title { get; set; } 

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Subscription> Readers { get; set; } = new List<Subscription>();
}
