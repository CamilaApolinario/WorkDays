using Microsoft.EntityFrameworkCore;
using WorkDays.Domain.Companies;
using WorkDays.Domain.Projects;
using WorkDays.Domain.WorkDays;

namespace WorkDays.Infra
{
    public class WorkDaysDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }

        public WorkDaysDbContext(DbContextOptions<WorkDaysDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasOne(p => p.Company)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.CompanyId);

            modelBuilder.Entity<WorkDay>()
                .HasOne(w => w.Project)
                .WithMany(p => p.WorkDays)
                .HasForeignKey(w => w.ProjectId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
