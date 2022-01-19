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
    public class NewsMap : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.Title).HasMaxLength(100);
            builder.Property(n => n.Title).IsRequired(true);
            builder.Property(n => n.Content).IsRequired(true);
            builder.Property(n => n.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(n => n.IsDeleted).IsRequired(true);
            builder.Property(n => n.IsActive).IsRequired(true);           
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.News).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.News).HasForeignKey(a => a.UserId);
            builder.ToTable("Newss");

            builder.HasData(
                new News
                {
                    Id = 1,
                    CategoryId = 1,
                    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    Thumbnail = "postImages/defaultThumbnail.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 1,
                    IsActive = true,
                    IsDeleted = false,
                    Title = "Test"
                });


        }
    }
}
