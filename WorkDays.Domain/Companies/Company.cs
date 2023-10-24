using WorkDays.Domain.Projects;

namespace WorkDays.Domain.Companies;

public class Company
{
    public int Id { get; set; }

    public string Name { get; set; }

    // Navigation property

    public int ProjectId { get; set; }
    public List<Project> Projects { get; set; }

}
