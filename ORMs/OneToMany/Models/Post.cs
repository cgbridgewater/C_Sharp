#pragma warning disable CS8618
namespace OneToMany.Models;
using System.ComponentModel.DataAnnotations;
public class Post
{    
    [Key]    
    public int PostId { get; set; }

    [Required]
    [MinLength(5, ErrorMessage="Must be at least 5 characters in length.")]  
    public string Content { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
    public int UserId { get; set; }
    // Our navigation property to track which User made this Post
    // It is VERY important to include the ? on the datatype or this won't work!
    public User? Creator { get; set; }
}