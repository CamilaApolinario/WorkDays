using WorkDays.Core.Services.Interfaces;
using WorkDays.Domain.Projects;
using WorkDays.Infra.SQLServer.Repositories.Interfaces;

namespace WorkDays.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void PostProject(Project project)
        {
            _projectRepository.Add(project);
        }
    }
}
