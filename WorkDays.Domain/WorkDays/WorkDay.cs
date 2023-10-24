using WorkDays.Domain.Projects;

namespace WorkDays.Domain.WorkDays
{
    public class WorkDay
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int HoursWorked { get; set; }

        // Foreign key
        public int ProjectId { get; set; }

        // Navigation property
        public Project Project { get; set; }
    }
}