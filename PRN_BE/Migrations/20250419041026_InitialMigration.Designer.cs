﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRN_BE.Data;

#nullable disable

namespace PRN_BE.Migrations
{
    [DbContext(typeof(EasyBookingBEContext))]
    [Migration("20250419041026_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                            Id = "1",
                            ConcurrencyStamp = "72cf4a2d-dc7e-4c51-be94-f4540b26e63a",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "b8f77d85-abee-4a6c-bef2-a09e7f5c5556",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "c1c8bfac-7ddb-40ca-b98e-e3561bdba8dd",
                            Name = "Host",
                            NormalizedName = "HOST"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "0f248e63-e5d2-4482-a96a-96d115c0db45",
                            Name = "Support Staff",
                            NormalizedName = "SUPPORT STAFF"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PRN_BE.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<byte[]>("avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PRN_BE.Data.Booking", b =>
                {
                    b.Property<int>("booking_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("booking_id"), 1L, 1);

                    b.Property<int>("booking_status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("check_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("check_out")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("end_date_booking")
                        .HasColumnType("datetime2");

                    b.Property<int>("num_adults")
                        .HasColumnType("int");

                    b.Property<int>("num_children")
                        .HasColumnType("int");

                    b.Property<int>("payment_status")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<DateTime>("start_date_booking")
                        .HasColumnType("datetime2");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("booking_id");

                    b.HasIndex("booking_status");

                    b.HasIndex("payment_status");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("PRN_BE.Data.Booking_Room", b =>
                {
                    b.Property<int>("booking_id")
                        .HasColumnType("int");

                    b.Property<int>("room_id")
                        .HasColumnType("int");

                    b.HasKey("booking_id", "room_id");

                    b.HasIndex("room_id");

                    b.ToTable("Booking_Room");
                });

            modelBuilder.Entity("PRN_BE.Data.Booking_Status", b =>
                {
                    b.Property<int>("booking_status_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("booking_status_id"), 1L, 1);

                    b.Property<string>("booking_status_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("booking_status_id");

                    b.ToTable("Booking_Status");
                });

            modelBuilder.Entity("PRN_BE.Data.Feature", b =>
                {
                    b.Property<int>("feature_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("feature_id"), 1L, 1);

                    b.Property<string>("feature_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("feature_id");

                    b.ToTable("Feature");
                });

            modelBuilder.Entity("PRN_BE.Data.Floor", b =>
                {
                    b.Property<int>("floor_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("floor_id"), 1L, 1);

                    b.Property<string>("floor_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("floor_id");

                    b.ToTable("Floor");
                });

            modelBuilder.Entity("PRN_BE.Data.Location", b =>
                {
                    b.Property<int>("location_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("location_id"), 1L, 1);

                    b.Property<string>("location_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("location_id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("PRN_BE.Data.Media", b =>
                {
                    b.Property<int>("media_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("media_id"), 1L, 1);

                    b.Property<byte[]>("picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("room_id")
                        .HasColumnType("int");

                    b.HasKey("media_id");

                    b.HasIndex("room_id");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("PRN_BE.Data.Payment_Status", b =>
                {
                    b.Property<int>("payment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("payment_id"), 1L, 1);

                    b.Property<string>("payment_status_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("payment_id");

                    b.ToTable("Payment_Status");
                });

            modelBuilder.Entity("PRN_BE.Data.Region", b =>
                {
                    b.Property<int?>("district_id")
                        .HasColumnType("int");

                    b.Property<string>("district_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("province_id")
                        .HasColumnType("int");

                    b.Property<string>("province_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("region_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("region_id"), 1L, 1);

                    b.Property<int?>("ward_id")
                        .HasColumnType("int");

                    b.Property<string>("ward_name")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("PRN_BE.Data.Room", b =>
                {
                    b.Property<int>("room_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("room_id"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("num_bathrooms")
                        .HasColumnType("int");

                    b.Property<int>("num_beds")
                        .HasColumnType("int");

                    b.Property<double>("price_per_night")
                        .HasColumnType("float");

                    b.Property<string>("room_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("room_status_id")
                        .HasColumnType("int");

                    b.Property<byte[]>("thumbnail")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("room_id");

                    b.HasIndex("room_status_id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("PRN_BE.Data.Room_Feature", b =>
                {
                    b.Property<int>("room_id")
                        .HasColumnType("int");

                    b.Property<int>("feature_id")
                        .HasColumnType("int");

                    b.HasKey("room_id", "feature_id");

                    b.HasIndex("feature_id");

                    b.ToTable("Room_Feature");
                });

            modelBuilder.Entity("PRN_BE.Data.Room_Status", b =>
                {
                    b.Property<int>("room_status_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("room_status_id"), 1L, 1);

                    b.Property<string>("room_status_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("room_status_id");

                    b.ToTable("Room_Status");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PRN_BE.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PRN_BE.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN_BE.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PRN_BE.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PRN_BE.Data.Booking", b =>
                {
                    b.HasOne("PRN_BE.Data.Booking_Status", "Booking_Status")
                        .WithMany()
                        .HasForeignKey("booking_status")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN_BE.Data.Payment_Status", "Payment_Status")
                        .WithMany()
                        .HasForeignKey("payment_status")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking_Status");

                    b.Navigation("Payment_Status");
                });

            modelBuilder.Entity("PRN_BE.Data.Booking_Room", b =>
                {
                    b.HasOne("PRN_BE.Data.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("booking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN_BE.Data.Room", "Room")
                        .WithMany()
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("PRN_BE.Data.Media", b =>
                {
                    b.HasOne("PRN_BE.Data.Room", "Room")
                        .WithMany()
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("PRN_BE.Data.Room", b =>
                {
                    b.HasOne("PRN_BE.Data.Room_Status", "Room_Status")
                        .WithMany()
                        .HasForeignKey("room_status_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room_Status");
                });

            modelBuilder.Entity("PRN_BE.Data.Room_Feature", b =>
                {
                    b.HasOne("PRN_BE.Data.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("feature_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN_BE.Data.Room", "Room")
                        .WithMany()
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
