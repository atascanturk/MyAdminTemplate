﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebsite.DataAccess.Concrete.EntityFramework.Contexts;

namespace MyWebsite.DataAccess.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220114213737_addedContactEntity")]
    partial class addedContactEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWebsite.Entities.Concrete.AdministrativeStaff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("AdministrativeStaffs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Admin",
                            ImagePath = "userImages/defaultThumbnail.jpg",
                            LastName = "Admin",
                            Title = "Title"
                        });
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Category1"
                        });
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Musics");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Newss");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                            CreatedDate = new DateTime(2022, 1, 15, 0, 37, 36, 457, DateTimeKind.Local).AddTicks(4581),
                            IsActive = true,
                            IsDeleted = false,
                            Thumbnail = "postImages/defaultThumbnail.jpg",
                            Title = "Test",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "1289ecb1-d66e-4b5b-a65e-ec3503673d44",
                            Name = "Category.Create",
                            NormalizedName = "CATEGORY.CREATE"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "0d88cded-b971-4cf1-ac94-2797d04dd8a6",
                            Name = "Category.Read",
                            NormalizedName = "CATEGORY.READ"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "06ba2577-472b-49e6-a304-418102349342",
                            Name = "Category.Update",
                            NormalizedName = "CATEGORY.UPDATE"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "465d41e7-59d0-4ed6-9e96-e88817b798ea",
                            Name = "Category.Delete",
                            NormalizedName = "CATEGORY.DELETE"
                        },
                        new
                        {
                            Id = 5,
                            ConcurrencyStamp = "1ae3b4d9-e96c-4b79-8321-21414ca42e0a",
                            Name = "News.Create",
                            NormalizedName = "NEWS.CREATE"
                        },
                        new
                        {
                            Id = 6,
                            ConcurrencyStamp = "b206dae5-f7b5-489f-a4bd-3448069fdfd3",
                            Name = "News.Read",
                            NormalizedName = "NEWS.READ"
                        },
                        new
                        {
                            Id = 7,
                            ConcurrencyStamp = "be1c1060-5285-46df-b44d-6980ec0e5d21",
                            Name = "News.Update",
                            NormalizedName = "NEWS.UPDATE"
                        },
                        new
                        {
                            Id = 8,
                            ConcurrencyStamp = "c74ae8ca-5374-49ac-8fdf-53d9437a4537",
                            Name = "News.Delete",
                            NormalizedName = "NEWS.DELETE"
                        },
                        new
                        {
                            Id = 9,
                            ConcurrencyStamp = "d5d816a6-7e82-493b-a404-410dc1d9f1f1",
                            Name = "User.Create",
                            NormalizedName = "USER.CREATE"
                        },
                        new
                        {
                            Id = 10,
                            ConcurrencyStamp = "4af8b7e7-e89d-41df-aea9-6be2738dff21",
                            Name = "User.Read",
                            NormalizedName = "USER.READ"
                        },
                        new
                        {
                            Id = 11,
                            ConcurrencyStamp = "b15fa69a-0bff-4b28-af21-f743bc730a84",
                            Name = "User.Update",
                            NormalizedName = "USER.UPDATE"
                        },
                        new
                        {
                            Id = 12,
                            ConcurrencyStamp = "6b47fb57-6677-4d66-930d-b69feb5a87df",
                            Name = "User.Delete",
                            NormalizedName = "USER.DELETE"
                        },
                        new
                        {
                            Id = 13,
                            ConcurrencyStamp = "a51d10bb-5a25-4b40-a27d-cef8f840ec91",
                            Name = "Role.Create",
                            NormalizedName = "ROLE.CREATE"
                        },
                        new
                        {
                            Id = 14,
                            ConcurrencyStamp = "bd8c14d6-49af-484a-9316-8ada502d393b",
                            Name = "Role.Read",
                            NormalizedName = "ROLE.READ"
                        },
                        new
                        {
                            Id = 15,
                            ConcurrencyStamp = "f77a1238-5f28-4f87-91e2-773d7c54fb8c",
                            Name = "Role.Update",
                            NormalizedName = "ROLE.UPDATE"
                        },
                        new
                        {
                            Id = 16,
                            ConcurrencyStamp = "9139f6e2-9b21-49ff-ba5d-0cd6d52bb519",
                            Name = "Role.Delete",
                            NormalizedName = "ROLE.DELETE"
                        },
                        new
                        {
                            Id = 17,
                            ConcurrencyStamp = "05f60820-2f2a-4750-8946-374ee695036a",
                            Name = "Announcement.Create",
                            NormalizedName = "ANNOUNCEMENT.CREATE"
                        },
                        new
                        {
                            Id = 18,
                            ConcurrencyStamp = "3e138084-2cf0-41e7-ab56-f5aba7bc7784",
                            Name = "Announcement.Read",
                            NormalizedName = "ANNOUNCEMENT.READ"
                        },
                        new
                        {
                            Id = 19,
                            ConcurrencyStamp = "c388e4ce-4b37-4e05-8768-76fd9d2b5111",
                            Name = "Announcement.Update",
                            NormalizedName = "ANNOUNCEMENT.UPDATE"
                        },
                        new
                        {
                            Id = 20,
                            ConcurrencyStamp = "cd95f09f-ab7d-4c64-8a6f-c07a55514bde",
                            Name = "Announcement.Delete",
                            NormalizedName = "ANNOUNCEMENT.DELETE"
                        },
                        new
                        {
                            Id = 21,
                            ConcurrencyStamp = "243dd9e9-f9cc-46cc-8732-0f477a26d70b",
                            Name = "AdminArea.Home.Read",
                            NormalizedName = "ADMINAREA.HOME.READ"
                        },
                        new
                        {
                            Id = 22,
                            ConcurrencyStamp = "558b2a56-a02a-486b-8117-121b3f20e259",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        });
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("SliderImages");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacebookLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("InstagramLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LinkedInLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TwitterLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("YoutubeLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("SocialMediaLinks");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Admin User of ProgrammersBlog",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8465607b-3013-453a-843b-35c1f074a25e",
                            Email = "adminuser@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINUSER@GMAIL.COM",
                            NormalizedUserName = "ADMINUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAEHDNpecRgNTdomKGo888K+lSvMF6adNjB98SN3YTIS572J8K4oGyUWl9pVh6/RHXRw==",
                            PhoneNumber = "+905555555555",
                            PhoneNumberConfirmed = true,
                            Picture = "/userImages/defaultUser.png",
                            SecurityStamp = "74ee0191-1484-4403-8e30-c6689eebb13a",
                            TwoFactorEnabled = false,
                            UserName = "adminuser"
                        },
                        new
                        {
                            Id = 2,
                            About = "Editor User of ProgrammersBlog",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e5525acf-f1be-4964-8301-134875073d3b",
                            Email = "editoruser@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "EDITORUSER@GMAIL.COM",
                            NormalizedUserName = "EDITORUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAEBPHHT1B/pMRTaYErNCGgHytlDiA429Fe0E5udzNRylcVgi1lTRakrS0oAucXytpmQ==",
                            PhoneNumber = "+905555555555",
                            PhoneNumberConfirmed = true,
                            Picture = "/userImages/defaultUser.png",
                            SecurityStamp = "5c1e0653-0270-4d20-bab9-06780f4db6d9",
                            TwoFactorEnabled = false,
                            UserName = "editoruser"
                        });
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 4
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 5
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 6
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 7
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 8
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 9
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 10
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 11
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 12
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 13
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 14
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 15
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 16
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 17
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 18
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 19
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 20
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 21
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 22
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 4
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 5
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 6
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 7
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 8
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 17
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 18
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 19
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 20
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 21
                        });
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Root")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Announcement", b =>
                {
                    b.HasOne("MyWebsite.Entities.Concrete.User", "User")
                        .WithMany("Announcements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.News", b =>
                {
                    b.HasOne("MyWebsite.Entities.Concrete.Category", "Category")
                        .WithMany("News")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWebsite.Entities.Concrete.User", "User")
                        .WithMany("News")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.RoleClaim", b =>
                {
                    b.HasOne("MyWebsite.Entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.UserClaim", b =>
                {
                    b.HasOne("MyWebsite.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.UserLogin", b =>
                {
                    b.HasOne("MyWebsite.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.UserRole", b =>
                {
                    b.HasOne("MyWebsite.Entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWebsite.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.UserToken", b =>
                {
                    b.HasOne("MyWebsite.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.Category", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("MyWebsite.Entities.Concrete.User", b =>
                {
                    b.Navigation("Announcements");

                    b.Navigation("News");
                });
#pragma warning restore 612, 618
        }
    }
}
