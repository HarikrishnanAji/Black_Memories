using System.ComponentModel.DataAnnotations;

namespace Black_Memories_API.Data.Models
{
    public class Template
    {
        [Key]
        public int TemplateId { get; set; }
        public string Description { get; set; }
        public string Style { get; set; }
        public bool Active { get; set; }
        public DateTime Dc { get; set; }
        public DateTime Dd { get; set; }
        public DateTime Lu { get; set; }
        public int UserId { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
