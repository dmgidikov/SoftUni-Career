namespace StudentSystem.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> resource)
        {
            resource.HasKey(r => r.Id);

            resource
                .Property(r => r.Name)
                .HasMaxLength(50)
                .IsRequired(true)
                .IsUnicode(true);

            resource
                .Property(r => r.Url)
                .IsUnicode(false);

            resource
                .HasOne(r => r.Course)
                .WithMany(x => x.Resources)
                .HasForeignKey(r => r.CourseId);
        }
    }
}