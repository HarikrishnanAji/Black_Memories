using Black_Memories_API.Data.Models;
using Black_Memories_API.Data.Repositories.Interfaces;

namespace Black_Memories_API.Services
{
    public class ProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository) 
        {
            _projectRepository = projectRepository;
        }
        public async Task<IEnumerable<Project>> GetProjectAllAsync() 
        {
            return await _projectRepository.GetProjectAllAsync();
        }
        public async Task<Project> AddProjectAsync(Project project) 
        {
            return await _projectRepository.AddProjectAsync(project);
        }
    }
}
