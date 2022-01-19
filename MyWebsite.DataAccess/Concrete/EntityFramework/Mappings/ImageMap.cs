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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Path).HasMaxLength(250);
            builder.Property(x => x.Path).IsRequired(true);
            builder.ToTable("Images");
        }
    }
}
