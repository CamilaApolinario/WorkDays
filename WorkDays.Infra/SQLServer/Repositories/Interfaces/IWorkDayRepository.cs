using WorkDays.Domain.WorkDays;

namespace WorkDays.Infra.SQLServer.Repositories.Interfaces
{
    public interface IWorkDayRepository
    {
        WorkDay GetById(int id);
        IEnumerable<WorkDay> GetAll();
        void Add(WorkDay workDay);
        void Update(WorkDay workDay);
        void Delete(int id);
    }
}
