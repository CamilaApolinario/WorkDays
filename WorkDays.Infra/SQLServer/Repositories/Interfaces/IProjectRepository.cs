using WorkDays.Domain.Projects;

namespace WorkDays.Infra.SQLServer.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Project GetById(int id);
        IEnumerable<Project> GetAll();
        void Add(Project project);
        void Update(Project project);
        void Delete(int id);
    }
}
