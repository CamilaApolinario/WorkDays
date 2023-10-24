using WorkDays.Domain.WorkDays;

namespace WorkDays.Core.Services.Interfaces
{
    public interface IWorkDayService
    {
        void PostWorkDay(WorkDay workDay);
    }
}
