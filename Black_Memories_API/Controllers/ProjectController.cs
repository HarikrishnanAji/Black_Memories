using Microsoft.AspNetCore.Mvc;

namespace Black_Memories_API.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
