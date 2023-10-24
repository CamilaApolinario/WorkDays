using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDays.Core.Services.Interfaces;
using WorkDays.Domain.WorkDays;
using WorkDays.Infra.SQLServer.Repositories.Interfaces;

namespace WorkDays.Core.Services
{
    public class WorkDayService : IWorkDayService
    {
        private readonly IWorkDayRepository _repository;

        public WorkDayService(IWorkDayRepository repository)
        {
            _repository = repository;
        }

        public void PostWorkDay(WorkDay workDay)
        {
            _repository.Add(workDay);
        }
    }
}
