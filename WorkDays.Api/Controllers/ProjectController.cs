using Microsoft.AspNetCore.Mvc;
using WorkDays.Core.Services.Interfaces;
using WorkDays.Domain.Projects;

namespace WorkDays.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectService _service;

        public ProjectController(ILogger<ProjectController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public IActionResult AddCompany([FromBody] Project project)
        {
            _service.PostProject(project);
            return Ok();
        }


    }
}
