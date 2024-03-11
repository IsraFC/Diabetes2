using Diabetes2.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Diabetes2.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<GlucoseMonitoring> GlucoseMonitorings { get; set; }
        public DbSet<HealthcareP> HealthcarePs { get; set; }
        public DbSet<MealPlanning> MealPlannings { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<ReminderAlert> reminderAlerts { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasOne(p => p.GlucoseMonitorings).WithOne(g => g.Patient).HasForeignKey<GlucoseMonitoring>(g => g.Id);
            modelBuilder.Entity<Patient>().HasOne(p => p.User).WithOne(u => u.Patient).HasForeignKey<User>(u => u.Id);
        }
    }
}
