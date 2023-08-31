#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace manyTOmany.Models;
public class Person
{
    [Key]
    public int PersonId { get; set; }    
    public string Name { get; set; }  

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();
}
