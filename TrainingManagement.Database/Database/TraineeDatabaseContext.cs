using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Model;

namespace TrainingManagement.Database.Database
{
    public class TraineeDatabaseContext:DbContext
    {
        public TraineeDatabaseContext()
        {

        }
        public TraineeDatabaseContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTrainee> CourseTrainees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=DESKTOP-OF3VVDD\\SQLEXPRESS;Database=Trainee_Management;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTrainee>().HasKey(c => new {c.CourseId,c.TraineeId});
        }
    }
}
