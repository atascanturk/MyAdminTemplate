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
    public class SocialMediaMap : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.FacebookLink).HasMaxLength(200);
            builder.Property(x => x.FacebookLink).IsRequired(true);
            builder.Property(x => x.InstagramLink).HasMaxLength(200);
            builder.Property(x => x.InstagramLink).IsRequired(true);
            builder.Property(x => x.TwitterLink).HasMaxLength(200);
            builder.Property(x => x.TwitterLink).IsRequired(true);
            builder.Property(x => x.YoutubeLink).HasMaxLength(200);
            builder.Property(x => x.YoutubeLink).IsRequired(true);
            builder.Property(x => x.LinkedInLink).HasMaxLength(200);
            builder.Property(x => x.LinkedInLink).IsRequired(true);
            builder.ToTable("SocialMediaLinks");
        }
    }
}
