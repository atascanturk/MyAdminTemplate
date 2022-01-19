using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AdministrativeStaffMap : IEntityTypeConfiguration<AdministrativeStaff>
    {
        public void Configure(EntityTypeBuilder<AdministrativeStaff> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).HasMaxLength(80);
            builder.Property(x => x.Title).IsRequired(true);
            builder.Property(x => x.FirstName).HasMaxLength(40);
            builder.Property(x => x.FirstName).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired(true);
            builder.Property(x => x.ImagePath).HasMaxLength(250);
            builder.Property(x => x.ImagePath).IsRequired(true);
            builder.ToTable("AdministrativeStaffs");
            builder.HasData(
                new AdministrativeStaff
                {
                    Id=1,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Title = "Title",
                    ImagePath = "userImages/defaultThumbnail.jpg"

                });
        }

        
    }
}
