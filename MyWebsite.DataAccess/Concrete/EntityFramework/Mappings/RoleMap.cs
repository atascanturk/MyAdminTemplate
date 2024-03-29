﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebsite.Entities.Concrete;

namespace MyWebsite.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasDatabaseName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("Roles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(100);
            builder.Property(u => u.NormalizedName).HasMaxLength(100);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<RoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(
                new Role
                {
                    Id = 1,
                    Name = "Category.Create",
                    NormalizedName = "CATEGORY.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 2,
                    Name = "Category.Read",
                    NormalizedName = "CATEGORY.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
            new Role
            {
                Id = 3,
                Name = "Category.Update",
                NormalizedName = "CATEGORY.UPDATE",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }
                ,
                new Role
                {
                    Id = 4,
                    Name = "Category.Delete",
                    NormalizedName = "CATEGORY.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
            new Role
                {
                    Id = 5,
                    Name = "News.Create",
                    NormalizedName = "NEWS.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
            new Role
            {
                Id = 6,
                Name = "News.Read",
                NormalizedName = "NEWS.READ",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new Role
                {
                    Id = 7,
                    Name = "News.Update",
                    NormalizedName = "NEWS.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
            new Role
                {
                    Id = 8,
                    Name = "News.Delete",
                    NormalizedName = "NEWS.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 9,
                    Name = "User.Create",
                    NormalizedName = "USER.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 10,
                    Name = "User.Read",
                    NormalizedName = "USER.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new Role
                {
                    Id = 11,
                    Name = "User.Update",
                    NormalizedName = "USER.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 12,
                    Name = "User.Delete",
                    NormalizedName = "USER.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 13,
                    Name = "Role.Create",
                    NormalizedName = "ROLE.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 14,
                    Name = "Role.Read",
                    NormalizedName = "ROLE.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new Role
                {
                    Id = 15,
                    Name = "Role.Update",
                    NormalizedName = "ROLE.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 16,
                    Name = "Role.Delete",
                    NormalizedName = "ROLE.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 17,
                    Name = "Announcement.Create",
                    NormalizedName = "ANNOUNCEMENT.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 18,
                    Name = "Announcement.Read",
                    NormalizedName = "ANNOUNCEMENT.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new Role
                {
                    Id = 19,
                    Name = "Announcement.Update",
                    NormalizedName = "ANNOUNCEMENT.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
                ,
                new Role
                {
                    Id = 20,
                    Name = "Announcement.Delete",
                    NormalizedName = "ANNOUNCEMENT.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new Role
                {
                    Id = 21,
                    Name = "AdminArea.Home.Read",
                    NormalizedName = "ADMINAREA.HOME.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
            new Role
                {
                    Id = 22,
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
            );
                
        }
    }
}
