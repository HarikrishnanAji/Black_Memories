using System.ComponentModel.DataAnnotations;

namespace Black_Memories_API.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime Dc { get; set; }
        public DateTime Dd { get; set; }
        public DateTime Lu { get; set; }
    }
}
