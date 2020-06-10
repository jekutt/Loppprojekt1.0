﻿// <auto-generated />
using System;
using Loppprojekt.Soft.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Loppprojekt.Soft.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Loppprojekt.Data.Cars.MarkData", b =>
            {
                b.Property<string>("Name")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Country")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("YearOfManufacture")
                    .HasColumnType("datetime2");

                b.HasKey("Name");

                b.ToTable("Marks");
            });

            modelBuilder.Entity("Loppprojekt.Data.Cars.ModelData", b =>
            {
                b.Property<string>("Name")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Country")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("MarkId")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("YearOfManufacture")
                    .HasColumnType("datetime2");

                b.HasKey("Name");

                b.ToTable("Models");
            });

            modelBuilder.Entity("Loppprojekt.Data.Cars.GenerationData", b =>
            {

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("MarkId")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ModelsId")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Country")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("BodyType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("DrivenWheel")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("YearOfManufacture")
                    .HasColumnType("datetime2");

                b.HasKey("Name");

                b.ToTable("Generations");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Name")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("NormalizedName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.HasKey("Name");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasName("RoleNameIndex")
                    .HasFilter("[NormalizedName] IS NOT NULL");

                b.ToTable("AspNetRoles");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Name")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Name");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
            {
                b.Property<string>("Name")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("bit");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("bit");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("NormalizedEmail")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

                b.Property<string>("NormalizedUserName")
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);

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
                    .HasColumnType("nvarchar(256)")
                    .HasMaxLength(256);
            });
        }
    }
}
