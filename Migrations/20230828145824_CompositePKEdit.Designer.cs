﻿// <auto-generated />
using System;
using FinalAssignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalAssignment.Migrations
{
    [DbContext(typeof(RoomBookingContext))]
    [Migration("20230828145824_CompositePKEdit")]
    partial class CompositePKEdit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalAssignment.Models.Booking", b =>
                {
                    b.Property<string>("RoomID")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("StaffID")
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoomID", "StaffID");

                    b.HasIndex("StaffID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("FinalAssignment.Models.Room", b =>
                {
                    b.Property<string>("RoomID")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("HasProjector")
                        .HasColumnType("bit");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("FinalAssignment.Models.Staff", b =>
                {
                    b.Property<string>("StaffID")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("MobilePhone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("StaffID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("FinalAssignment.Models.Booking", b =>
                {
                    b.HasOne("FinalAssignment.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalAssignment.Models.Staff", "Staff")
                        .WithMany("Bookings")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("FinalAssignment.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("FinalAssignment.Models.Staff", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}