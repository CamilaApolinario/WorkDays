using WorkDays.Domain.Projects;
using WorkDays.Infra.SQLServer.Repositories.Interfaces;

namespace WorkDays.Infra.SQLServer.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly WorkDaysDbContext _context;

        public ProjectRepository(WorkDaysDbContext context)
        {
            _context = context;
        }

        public void Add(Project project)
        {
            _context.Add(project);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public Project GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
