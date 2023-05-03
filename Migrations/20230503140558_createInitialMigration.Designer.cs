﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp.net_controller_api.DbContexts;

#nullable disable

namespace asp.net_controller_api.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230503140558_createInitialMigration")]
    partial class createInitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2");

            modelBuilder.Entity("asp.net_controller_api.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Addressline1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Addressline2")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Suburb")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("asp.net_controller_api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Address_Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address_Id = 1,
                            DateofBirth = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Keri",
                            LastName = "van der Westhuizen"
                        },
                        new
                        {
                            Id = 2,
                            Address_Id = 1,
                            DateofBirth = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Grant",
                            LastName = "van der Westhuizen"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
