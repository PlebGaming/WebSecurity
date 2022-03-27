using System.ComponentModel.DataAnnotations;

namespace WebSecurityMag.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? ForumMessage { get; set; }
    }
}
