using System.ComponentModel.DataAnnotations;

namespace Black_Memories_API.Data.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime Dc { get; set; }
        public DateTime Dd { get; set; }
        public DateTime Lu { get; set; }
        public int UserId { get; set; }

    }
}
