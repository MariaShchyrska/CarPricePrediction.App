﻿// <auto-generated />
using System;
using CarPricePrediction.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarPricePrediction.Core.Migrations
{
    [DbContext(typeof(CarsContext))]
    [Migration("20230606153119_Cars")]
    partial class Cars
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FuelTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Fuel_TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Kms_driven")
                        .HasColumnType("float");

                    b.Property<Guid?>("LabelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Fuel_TypeId");

                    b.HasIndex("LabelId");

                    b.HasIndex("LocationId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Fuel_type", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fuel_Types");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Label", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Car", b =>
                {
                    b.HasOne("CarPricePrediction.Core.Entities.Company", "Company")
                        .WithMany("Cars")
                        .HasForeignKey("CompanyId");

                    b.HasOne("CarPricePrediction.Core.Entities.Fuel_type", "Fuel_Type")
                        .WithMany("Cars")
                        .HasForeignKey("Fuel_TypeId");

                    b.HasOne("CarPricePrediction.Core.Entities.Label", "Label")
                        .WithMany("Cars")
                        .HasForeignKey("LabelId");

                    b.HasOne("CarPricePrediction.Core.Entities.Location", "Location")
                        .WithMany("Cars")
                        .HasForeignKey("LocationId");

                    b.Navigation("Company");

                    b.Navigation("Fuel_Type");

                    b.Navigation("Label");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Company", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Fuel_type", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Label", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Location", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
