using Black_Memories_API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Black_Memories_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Template> Templates { get; set; }

    }
}
