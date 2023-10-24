using WorkDays.Domain.WorkDays;
using WorkDays.Infra.SQLServer.Repositories.Interfaces;

namespace WorkDays.Infra.SQLServer.Repositories
{
    public class WorkDayRepository : IWorkDayRepository
    {
        private readonly WorkDaysDbContext _context;

        public WorkDayRepository(WorkDaysDbContext context)
        {
            _context = context;
        }

        public void Add(WorkDay workDay)
        {
            _context.Add(workDay);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkDay> GetAll()
        {
            throw new NotImplementedException();
        }

        public WorkDay GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(WorkDay workDay)
        {
            throw new NotImplementedException();
        }
    }
}
