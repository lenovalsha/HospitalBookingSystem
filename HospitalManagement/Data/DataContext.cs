using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace HospitalManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Models.Tasks> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLevel> UserLevels { get; set; }

        //this is for many to many table - I dont believe we have any
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany()
                .HasForeignKey(a => a.PatientHSN)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorUsername)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.AppointmentType)
                .WithMany()
                .HasForeignKey(a => a.AppointmentTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Tasks>()
                .HasOne(a => a.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorUsername)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Patient>()
               .HasOne(a => a.Doctor)
               .WithMany()
               .HasForeignKey(a => a.DoctorUsername)
               .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }





    }
}
