using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDays.Domain.Projects;

namespace WorkDays.Core.Services.Interfaces
{
    public interface IProjectService
    {
        void PostProject(Project project);
    }
}
