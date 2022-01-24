using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyWebsite.Core.Entities.Concrete;
using MyWebsite.Data.Concrete.EntityFramework.Mappings;
using MyWebsite.DataAccess.Concrete.EntityFramework.Mappings;
using MyWebsite.Entities.Concrete;
using System.Configuration;


namespace MyWebsite.DataAccess.Concrete.EntityFramework.Contexts
{
    
   public class MyDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {    
            

        public DbSet<News> Newss { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<SocialMedia> SocialMediaLinks { get; set; }
        public DbSet<Slider> SliderImages { get; set; }
        public DbSet<AdministrativeStaff> AdministrativeStaffs { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MaintenanceCheck> MaintenanceChecks { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<VisitorCount> VisitorCounts { get; set; }
        public DbSet<Seo> Seos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var str = GlobalProperties.DbConn;
            optionsBuilder.UseSqlServer(str);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdministrativeStaffMap());
            modelBuilder.ApplyConfiguration(new AnnouncementMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ImageMap());
            modelBuilder.ApplyConfiguration(new MusicMap());
            modelBuilder.ApplyConfiguration(new NewsMap());
            modelBuilder.ApplyConfiguration(new RoleClaimMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new SliderMap());
            modelBuilder.ApplyConfiguration(new SocialMediaMap());
            modelBuilder.ApplyConfiguration(new UserClaimMap());
            modelBuilder.ApplyConfiguration(new UserLoginMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserTokenMap());
            modelBuilder.ApplyConfiguration(new VideoMap());

        }
    }
}
