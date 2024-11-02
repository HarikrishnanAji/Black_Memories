
using Black_Memories_API.Data.Models;
using Black_Memories_API.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Black_Memories_API.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProjectRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Project> AddProjectAsync(Project project)
        {
            await _appDbContext.Projects.AddAsync(project);
            _appDbContext.SaveChanges();
            return project;
        }
        public async Task<IEnumerable<Project>> GetProjectAllAsync()
        {
            return await _appDbContext.Projects.ToListAsync();
        }
    }
}
