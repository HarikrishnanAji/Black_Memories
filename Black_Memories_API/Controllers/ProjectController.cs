using Black_Memories_API.Data.Models;
using Black_Memories_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Black_Memories_API.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectService _projectService;
        public ProjectController(ProjectService projectService) 
        {
            _projectService = projectService;
        }
        [HttpGet]
        public async Task<IEnumerable<Project>> GetAllProjectAsync() 
        {
            return await _projectService.GetProjectAllAsync();
        }
        [HttpPost]
        public async Task<Project> AddProjectAsync(Project project)
        {
            return await _projectService.AddProjectAsync(project);
        }
    }
}
