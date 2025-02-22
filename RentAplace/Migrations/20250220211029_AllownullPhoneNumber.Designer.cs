﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentAplace.Data;

#nullable disable

namespace RentAplace.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250220211029_AllownullPhoneNumber")]
    partial class AllownullPhoneNumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("rentaplace")
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentAplace.Data.Entities.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeatureName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FeatureId");

                    b.ToTable("Features", "rentaplace");

                    b.HasData(
                        new
                        {
                            FeatureId = 1,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8596),
                            FeatureName = "WiFi"
                        },
                        new
                        {
                            FeatureId = 2,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8599),
                            FeatureName = "Parking"
                        },
                        new
                        {
                            FeatureId = 3,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8600),
                            FeatureName = "Swimming Pool"
                        },
                        new
                        {
                            FeatureId = 4,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8601),
                            FeatureName = "Gym"
                        },
                        new
                        {
                            FeatureId = 5,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8601),
                            FeatureName = "Balcony"
                        },
                        new
                        {
                            FeatureId = 6,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8602),
                            FeatureName = "Air Conditioning"
                        },
                        new
                        {
                            FeatureId = 7,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8603),
                            FeatureName = "Heating"
                        },
                        new
                        {
                            FeatureId = 8,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8604),
                            FeatureName = "Security System"
                        },
                        new
                        {
                            FeatureId = 9,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8604),
                            FeatureName = "Elevator"
                        },
                        new
                        {
                            FeatureId = 10,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8605),
                            FeatureName = "Fully Furnished"
                        });
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Image", "rentaplace");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Messages", "rentaplace");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("PropertyId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Properties", "rentaplace");

                    b.HasData(
                        new
                        {
                            PropertyId = 1,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8657),
                            Description = "A beautiful luxury apartment in the city center.",
                            IsDeleted = false,
                            Location = "Bandra, Mumbai",
                            OwnerId = 1,
                            Price = 120.50m,
                            PropertyTypeId = 1,
                            Title = "Luxury Apartment"
                        },
                        new
                        {
                            PropertyId = 2,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8664),
                            Description = "A peaceful villa with a stunning sea view.",
                            IsDeleted = false,
                            Location = "Diveaghar",
                            OwnerId = 1,
                            Price = 250.00m,
                            PropertyTypeId = 2,
                            Title = "Cozy Villa"
                        });
                });

            modelBuilder.Entity("RentAplace.Data.Entities.PropertyFeature", b =>
                {
                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("PropertyFeatures", "rentaplace");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.PropertyType", b =>
                {
                    b.Property<int>("PropertyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyTypeId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PropertyTypeId");

                    b.ToTable("PropertyType", "rentaplace");

                    b.HasData(
                        new
                        {
                            PropertyTypeId = 1,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8549),
                            IsDeleted = false,
                            TypeName = "Apartment"
                        },
                        new
                        {
                            PropertyTypeId = 2,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8552),
                            IsDeleted = false,
                            TypeName = "Villa"
                        },
                        new
                        {
                            PropertyTypeId = 3,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8553),
                            IsDeleted = false,
                            TypeName = "Studio"
                        },
                        new
                        {
                            PropertyTypeId = 4,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8554),
                            IsDeleted = false,
                            TypeName = "Townhouse"
                        });
                });

            modelBuilder.Entity("RentAplace.Data.Entities.RatingComment", b =>
                {
                    b.Property<int>("RatingCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingCommentId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RatingCommentId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("UserId");

                    b.ToTable("RatingComment", "rentaplace");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations", "rentaplace");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Role", "rentaplace");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8424),
                            IsDeleted = false,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8429),
                            IsDeleted = false,
                            RoleName = "Owner"
                        },
                        new
                        {
                            RoleId = 3,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8430),
                            IsDeleted = false,
                            RoleName = "Renter"
                        });
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StatusId");

                    b.ToTable("Status", "rentaplace");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8574),
                            IsDeleted = false,
                            StatusName = "Pending"
                        },
                        new
                        {
                            StatusId = 2,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8576),
                            IsDeleted = false,
                            StatusName = "Confirmed"
                        },
                        new
                        {
                            StatusId = 3,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8577),
                            IsDeleted = false,
                            StatusName = "Cancelled"
                        },
                        new
                        {
                            StatusId = 4,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8577),
                            IsDeleted = false,
                            StatusName = "Completed"
                        });
                });

            modelBuilder.Entity("RentAplace.Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users", "rentaplace");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8630),
                            Email = "Rohitsharma@gmail.com",
                            FullName = "Rohit Sharma",
                            IsDeleted = false,
                            PasswordHash = "Rohit123",
                            PhoneNumber = "7657890345",
                            ProfileImage = "profile1.jpg",
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2025, 2, 20, 21, 10, 26, 933, DateTimeKind.Utc).AddTicks(8636),
                            Email = "Viratk123",
                            FullName = "virat Kohli",
                            IsDeleted = false,
                            PasswordHash = "Virat@123",
                            PhoneNumber = "7657894545",
                            ProfileImage = "profile.jpg",
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Image", b =>
                {
                    b.HasOne("RentAplace.Data.Entities.Property", "Property")
                        .WithMany("Images")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Message", b =>
                {
                    b.HasOne("RentAplace.Data.Entities.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RentAplace.Data.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RentAplace.Data.Entities.User", null)
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("UserId");

                    b.HasOne("RentAplace.Data.Entities.User", null)
                        .WithMany("SentMessages")
                        .HasForeignKey("UserId1");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Property", b =>
                {
                    b.HasOne("RentAplace.Data.Entities.User", "Owner")
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RentAplace.Data.Entities.PropertyType", "PropertyType")
                        .WithMany("Properties")
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("PropertyType");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.PropertyFeature", b =>
                {
                    b.HasOne("RentAplace.Data.Entities.Feature", "Feature")
                        .WithMany("PropertyFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentAplace.Data.Entities.Property", "Property")
                        .WithMany("PropertyFeatures")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.RatingComment", b =>
                {
                    b.HasOne("RentAplace.Data.Entities.Property", "Property")
                        .WithMany("Ratings")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentAplace.Data.Entities.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Reservation", b =>
                {
                    b.HasOne("RentAplace.Data.Entities.Property", "Property")
                        .WithMany("Reservations")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentAplace.Data.Entities.Status", "Status")
                        .WithMany("Reservations")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentAplace.Data.Entities.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.User", b =>
                {
                    b.HasOne("RentAplace.Data.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Feature", b =>
                {
                    b.Navigation("PropertyFeatures");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Property", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("PropertyFeatures");

                    b.Navigation("Ratings");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.PropertyType", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.Status", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RentAplace.Data.Entities.User", b =>
                {
                    b.Navigation("Properties");

                    b.Navigation("Ratings");

                    b.Navigation("ReceivedMessages");

                    b.Navigation("Reservations");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
