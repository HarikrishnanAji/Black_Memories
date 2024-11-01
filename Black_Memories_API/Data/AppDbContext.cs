using Microsoft.EntityFrameworkCore;

namespace Black_Memories_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
