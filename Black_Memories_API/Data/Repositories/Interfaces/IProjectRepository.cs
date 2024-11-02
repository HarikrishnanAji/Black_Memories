using Black_Memories_API.Data.Models;

namespace Black_Memories_API.Data.Repositories.Interfaces
{
    public interface IProjectRepository
    {
       Task<IEnumerable<Project>> GetProjectAllAsync();
       Task<Project> AddProjectAsync(Project project);
    }
}
