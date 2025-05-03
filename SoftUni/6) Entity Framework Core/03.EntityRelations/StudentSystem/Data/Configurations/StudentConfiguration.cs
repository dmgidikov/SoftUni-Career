namespace StudentSystem.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> student)
        {
            student.HasKey(st => st.Id);

            student
                .Property(st => st.Name)
                .HasMaxLength(100)
                .IsRequired(true)
                .IsUnicode(true);

            student
                .Property(st => st.PhoneNumber)
                .HasMaxLength(10)
                .IsRequired(false)
                .IsUnicode(false);

            student
                .Property(st => st.RegisteredOn)
                .IsRequired(true);

            student
                .Property(st => st.Birthday)
                .IsRequired(false);

            student
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students);                
        }
    }
}