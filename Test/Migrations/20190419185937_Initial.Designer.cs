﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Models;

namespace GrillBerWebApp.Migrations
{
    [DbContext(typeof(GrillBerContext))]
    [Migration("20190419185937_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Test.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "1", AccessFailedCount = 0, ConcurrencyStamp = "2012f5d5-65f9-45f1-9617-7b17e1f94679", Email = "janos@gmail.com", EmailConfirmed = false, LockoutEnabled = false, NormalizedEmail = "janos@gmail.com", NormalizedUserName = "janos@gmail.com", PasswordHash = "AQAAAAEAACcQAAAAECtCenyxeSGpTeXzwgQeESc9BiYlXq1Aw4BDWttDopnD6g8gEGH76Xw1DFHgyjAILQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "janos@gmail.com" },
                        new { Id = "2", AccessFailedCount = 0, ConcurrencyStamp = "45f5c3b8-e4cf-4eb2-bd24-6f76e91b3676", Email = "julia@hotmail.com", EmailConfirmed = false, LockoutEnabled = false, NormalizedEmail = "julia@hotmail.com", NormalizedUserName = "julia@hotmail.com", PasswordHash = "AQAAAAEAACcQAAAAEMkXw6Gw2GxgocSkr5231rkCPL+YVUu7NoF0dRi1av5gAHTiFwBnhdvewyUTGbDRBg==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "julia@hotmail.com" }
                    );
                });

            modelBuilder.Entity("Test.Models.GrillModel", b =>
                {
                    b.Property<int>("GrillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GrillDecription");

                    b.Property<int>("GrillPricePerHour");

                    b.Property<string>("GrillType")
                        .IsRequired();

                    b.HasKey("GrillId");

                    b.ToTable("Grills");

                    b.HasData(
                        new { GrillId = 1, GrillDecription = "in new condition", GrillPricePerHour = 1500, GrillType = "charcoal grill" },
                        new { GrillId = 2, GrillDecription = "red coloured grill", GrillPricePerHour = 2500, GrillType = "gas grill" },
                        new { GrillId = 3, GrillDecription = "brandnew grill with free towel", GrillPricePerHour = 3000, GrillType = "gas grill" }
                    );
                });

            modelBuilder.Entity("Test.Models.GrillReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GrillId");

                    b.Property<int>("ReservationId");

                    b.HasKey("Id");

                    b.HasIndex("GrillId");

                    b.HasIndex("ReservationId");

                    b.ToTable("GrillReservation");

                    b.HasData(
                        new { Id = 1, GrillId = 1, ReservationId = 1 },
                        new { Id = 2, GrillId = 3, ReservationId = 2 },
                        new { Id = 3, GrillId = 3, ReservationId = 3 }
                    );
                });

            modelBuilder.Entity("Test.Models.ReservationModel", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PhoneNum");

                    b.Property<string>("ReservationAddress")
                        .IsRequired();

                    b.Property<string>("ReservationComment");

                    b.Property<DateTime>("ReservationDate");

                    b.Property<string>("ReservatorName")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("ReservationId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new { ReservationId = 1, PhoneNum = 0, ReservationAddress = "Budapest 7. kerület Wesselényi utca 56.", ReservationDate = new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), ReservatorName = "Kiss Janos", UserId = "1" },
                        new { ReservationId = 2, PhoneNum = 0, ReservationAddress = "Budapest Újpest központi parkoló", ReservationDate = new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), ReservatorName = "Kiss Janos", UserId = "1" },
                        new { ReservationId = 3, PhoneNum = 0, ReservationAddress = "Bp 14. ker", ReservationDate = new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), ReservatorName = "Kiss Janos", UserId = "1" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Test.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Test.Models.GrillReservation", b =>
                {
                    b.HasOne("Test.Models.GrillModel", "grill")
                        .WithMany("ReservGrills")
                        .HasForeignKey("GrillId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Test.Models.ReservationModel", "reservation")
                        .WithMany("ReservGrills")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Test.Models.ReservationModel", b =>
                {
                    b.HasOne("Test.Models.AppUser", "User")
                        .WithMany("ReservationsOfUsers")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
