using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Configurations;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace P01_StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext()
        {
            
        }

        public StudentSystemDbContext(DbContextOptions options)
            : base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<Resource> Resources { get; set; }  

        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(ConnectionString.cnString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Birthday)
                    .IsRequired(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(e => e.Description)
                    .HasMaxLength(1000)                    
                    .IsRequired(false)
                    .IsUnicode(true);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.HasKey(e => e.HomeworkId);

                entity
                    .Property(e => e.Content)
                    .IsRequired(true);

                entity
                    .HasOne(e => e.Student)
                    .WithMany(s => s.HomeworkSubmissions)
                    .HasForeignKey(e => e.HomeworkId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity
                    .HasOne(e => e.Course)
                    .WithMany(c => c.HomeworkSubmissions)
                    .HasForeignKey(e => e.CourseId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(e => e.Url)
                    .IsUnicode(false);

                entity
                    .HasOne(e => e.Course)
                    .WithMany(c => c.Resources)
                    .HasForeignKey(e => e.CourseId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.CourseId });

                entity
                    .HasOne(e => e.Student)
                    .WithMany(s => s.CourseEnrollments)
                    .HasForeignKey(e => e.StudentId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity
                    .HasOne(e => e.Course)
                    .WithMany(c => c.StudentsEnrollments)
                    .HasForeignKey(e => e.CourseId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
