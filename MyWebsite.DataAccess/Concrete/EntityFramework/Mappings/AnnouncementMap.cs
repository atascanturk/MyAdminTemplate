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
    public class AnnouncementMap : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Title).IsRequired(true);
            builder.Property(x => x.Content).IsRequired(true);
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.HasOne<User>(a => a.User).WithMany(c => c.Announcements).HasForeignKey(a => a.UserId);
            builder.ToTable("Announcements");
        }
    }
}
