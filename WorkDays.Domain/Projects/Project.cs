using WorkDays.Domain.Companies;
using WorkDays.Domain.WorkDays;

namespace WorkDays.Domain.Projects;

public class Project
{
    public int ProjectId { get; set; }
    public string Name { get; set; }

    // Foreign key
    public int CompanyId { get; set; }

    // Navigation properties
    public Company Company { get; set; }
    public List<WorkDay> WorkDays { get; set; }
}
