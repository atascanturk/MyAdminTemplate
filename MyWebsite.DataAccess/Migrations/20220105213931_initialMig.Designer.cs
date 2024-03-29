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
    [Migration("20220105213931_initialMig")]
    partial class initialMig
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
                            CreatedDate = new DateTime(2022, 1, 6, 0, 39, 30, 705, DateTimeKind.Local).AddTicks(8555),
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
                            ConcurrencyStamp = "8e94198e-4aa1-4cc0-b0fd-d45844151672",
                            Name = "Category.Create",
                            NormalizedName = "CATEGORY.CREATE"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "a2fc787d-acf3-4f6a-849e-bf8c078a0303",
                            Name = "Category.Read",
                            NormalizedName = "CATEGORY.READ"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "81c59327-cd34-46fe-abcd-6f136f1594a2",
                            Name = "Category.Update",
                            NormalizedName = "CATEGORY.UPDATE"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "94358321-f84f-4ff9-b03b-a897bc427aff",
                            Name = "Category.Delete",
                            NormalizedName = "CATEGORY.DELETE"
                        },
                        new
                        {
                            Id = 5,
                            ConcurrencyStamp = "140c7b31-db76-4638-b6f8-c45172580277",
                            Name = "News.Create",
                            NormalizedName = "NEWS.CREATE"
                        },
                        new
                        {
                            Id = 6,
                            ConcurrencyStamp = "d8e42361-1592-4cdf-8eb2-09b86bc0d992",
                            Name = "News.Read",
                            NormalizedName = "NEWS.READ"
                        },
                        new
                        {
                            Id = 7,
                            ConcurrencyStamp = "894dbcd9-bdec-4098-82a1-1c789f8cfda8",
                            Name = "News.Update",
                            NormalizedName = "NEWS.UPDATE"
                        },
                        new
                        {
                            Id = 8,
                            ConcurrencyStamp = "1f22b5ce-c23b-410b-9d2e-e8317ee24da0",
                            Name = "News.Delete",
                            NormalizedName = "NEWS.DELETE"
                        },
                        new
                        {
                            Id = 9,
                            ConcurrencyStamp = "7232250d-2fba-489d-88b8-be4d00b1d3d6",
                            Name = "User.Create",
                            NormalizedName = "USER.CREATE"
                        },
                        new
                        {
                            Id = 10,
                            ConcurrencyStamp = "3851a342-1644-482d-9be6-6dda8fe29f97",
                            Name = "User.Read",
                            NormalizedName = "USER.READ"
                        },
                        new
                        {
                            Id = 11,
                            ConcurrencyStamp = "01045028-415b-4756-96cf-d03c09c74575",
                            Name = "User.Update",
                            NormalizedName = "USER.UPDATE"
                        },
                        new
                        {
                            Id = 12,
                            ConcurrencyStamp = "25b085f3-eaba-481a-9c8b-276e4d4904ad",
                            Name = "User.Delete",
                            NormalizedName = "USER.DELETE"
                        },
                        new
                        {
                            Id = 13,
                            ConcurrencyStamp = "60087376-eed1-4027-8a11-9d0235d14bab",
                            Name = "Role.Create",
                            NormalizedName = "ROLE.CREATE"
                        },
                        new
                        {
                            Id = 14,
                            ConcurrencyStamp = "6312d116-ebd9-41f7-8642-d5e22f298bc2",
                            Name = "Role.Read",
                            NormalizedName = "ROLE.READ"
                        },
                        new
                        {
                            Id = 15,
                            ConcurrencyStamp = "1e609ad8-1c33-4976-8489-79c396f51783",
                            Name = "Role.Update",
                            NormalizedName = "ROLE.UPDATE"
                        },
                        new
                        {
                            Id = 16,
                            ConcurrencyStamp = "dd71439e-2c81-4589-8200-877761920cea",
                            Name = "Role.Delete",
                            NormalizedName = "ROLE.DELETE"
                        },
                        new
                        {
                            Id = 17,
                            ConcurrencyStamp = "33134444-c533-4353-966b-d55abcdd19b1",
                            Name = "Announcement.Create",
                            NormalizedName = "ANNOUNCEMENT.CREATE"
                        },
                        new
                        {
                            Id = 18,
                            ConcurrencyStamp = "442d647c-7cbc-484c-aa34-2b2a5bf1a68f",
                            Name = "Announcement.Read",
                            NormalizedName = "ANNOUNCEMENT.READ"
                        },
                        new
                        {
                            Id = 19,
                            ConcurrencyStamp = "a890677f-4a43-4dbd-9f39-b4349881e1c9",
                            Name = "Announcement.Update",
                            NormalizedName = "ANNOUNCEMENT.UPDATE"
                        },
                        new
                        {
                            Id = 20,
                            ConcurrencyStamp = "30697633-d701-4f74-9f23-a38395339fb6",
                            Name = "Announcement.Delete",
                            NormalizedName = "ANNOUNCEMENT.DELETE"
                        },
                        new
                        {
                            Id = 21,
                            ConcurrencyStamp = "c0b1c454-c247-4c22-8d62-009f4babb4eb",
                            Name = "AdminArea.Home.Read",
                            NormalizedName = "ADMINAREA.HOME.READ"
                        },
                        new
                        {
                            Id = 22,
                            ConcurrencyStamp = "5b52c658-7c3f-489c-8f7b-752a556740d7",
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
                            ConcurrencyStamp = "04d481cd-ba18-4441-b80f-3315bed6953c",
                            Email = "adminuser@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINUSER@GMAIL.COM",
                            NormalizedUserName = "ADMINUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAEDkEeQs0I/eI7cKJOmywMAV8zbt+otAT3ibC48lPATfmOLD3UyZk9thHOta5qKa81w==",
                            PhoneNumber = "+905555555555",
                            PhoneNumberConfirmed = true,
                            Picture = "/userImages/defaultUser.png",
                            SecurityStamp = "f99153aa-9a39-4975-a013-0275b5e40167",
                            TwoFactorEnabled = false,
                            UserName = "adminuser"
                        },
                        new
                        {
                            Id = 2,
                            About = "Editor User of ProgrammersBlog",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "16a8e8b6-1fda-4f54-aba6-e1559137b9a7",
                            Email = "editoruser@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "EDITORUSER@GMAIL.COM",
                            NormalizedUserName = "EDITORUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAEGUD9s7f4oyucPP0bscpuB2hrtIQ8JIWfE9O8NN4lPAh1bsL2qR0p96m/A+ZQWa9fg==",
                            PhoneNumber = "+905555555555",
                            PhoneNumberConfirmed = true,
                            Picture = "/userImages/defaultUser.png",
                            SecurityStamp = "b7eb5ea9-ef25-4def-8460-3772a2d94f1f",
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
