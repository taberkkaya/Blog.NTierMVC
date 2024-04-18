﻿// <auto-generated />
using System;
using Blog.NTierMVC.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.NTierMVC.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240418125918_UserCreated")]
    partial class UserCreated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                            ConcurrencyStamp = "c6ec467e-3afe-4f1d-9565-ce9b9bee4f8a",
                            Name = "Superadmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                            ConcurrencyStamp = "5ed0af1d-26cb-41ff-aa8a-45450e0a2b9b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                            ConcurrencyStamp = "ec78d96b-7624-47bc-bb75-1260afa83426",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6cbe3601-f4cc-4315-8c97-18294172275c",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "DUMMYUSER",
                            LastName = "SUPERADMIN",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "superadmin@gmail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEO7zSdZS8gXYscFwK4GKSyX7SkZ1P3Qjr+214PrXruwdNfipQCLOemb3tBsGPCnBHQ==",
                            PhoneNumber = "+905439999999",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3ff22b24-dde0-4016-948d-3ac600398404",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "DUMMYUSER",
                            LastName = "ADMIN",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAIAAYagAAAAENBXoeXPqC4+Mq/lGtKd5blLokdrHr+jzUeE44QZe7o4lpLpvfDUHCm+oEhp6Cr+WA==",
                            PhoneNumber = "+905438888888",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                            RoleId = new Guid("c685c5ab-f989-4372-b46e-0bea49d44098")
                        },
                        new
                        {
                            UserId = new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                            RoleId = new Guid("97b28373-bf1c-4188-a833-03379fd3679f")
                        });
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c8342bd-9800-4694-80ea-ae74dfeb9fea"),
                            CategoryId = new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(8216),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "What is Lorem Ipsum?",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("506fc3d7-91ed-4799-a508-6a6e3730db92"),
                            CategoryId = new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                            Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(8221),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Why do we use it?",
                            ViewCount = 19
                        });
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(9171),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "What is Lorem Ipsum?"
                        },
                        new
                        {
                            Id = new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(9174),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Why do we use it?"
                        });
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(9914),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FileName = "Test",
                            FileType = "jpg",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(9927),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FileName = "Lorem_Ipsum",
                            FileType = "png",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("Blog.NTierMVC.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("Blog.NTierMVC.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("Blog.NTierMVC.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("Blog.NTierMVC.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.NTierMVC.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("Blog.NTierMVC.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.NTierMVC.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.NTierMVC.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.NTierMVC.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}