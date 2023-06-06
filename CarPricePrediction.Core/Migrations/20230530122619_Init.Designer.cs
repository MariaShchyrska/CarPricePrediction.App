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
    [Migration("20230530122619_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarCompany", b =>
                {
                    b.Property<Guid>("CarsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompaniesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CarsId", "CompaniesId");

                    b.HasIndex("CompaniesId");

                    b.ToTable("CarCompany");
                });

            modelBuilder.Entity("CarFuel_type", b =>
                {
                    b.Property<Guid>("CarsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Fuel_TypesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CarsId", "Fuel_TypesId");

                    b.HasIndex("Fuel_TypesId");

                    b.ToTable("CarFuel_type");
                });

            modelBuilder.Entity("CarLabel", b =>
                {
                    b.Property<Guid>("CarsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LabelsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CarsId", "LabelsId");

                    b.HasIndex("LabelsId");

                    b.ToTable("CarLabel");
                });

            modelBuilder.Entity("CarLocation", b =>
                {
                    b.Property<Guid>("CarsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CarsId", "LocationsId");

                    b.HasIndex("LocationsId");

                    b.ToTable("CarLocation");
                });

            modelBuilder.Entity("CarPricePrediction.Core.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fuel_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kms_driven")
                        .HasColumnType("float");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c9671f9-d541-4d3e-99a6-d5963eb1e031"),
                            Name = "Ahmedabad"
                        },
                        new
                        {
                            Id = new Guid("fdcfd7d3-15a5-4c32-ba51-b8a652c7a5fa"),
                            Name = "Anand"
                        },
                        new
                        {
                            Id = new Guid("fc7d65c9-2589-48c8-a2e3-021b48f74947"),
                            Name = "Bangalore"
                        },
                        new
                        {
                            Id = new Guid("f9f92886-cad4-4edc-96c6-9920aacc5875"),
                            Name = "Bhubaneswar"
                        },
                        new
                        {
                            Id = new Guid("0712a3b6-405b-4e8d-871a-204c3ae6689a"),
                            Name = "Bilaspur"
                        },
                        new
                        {
                            Id = new Guid("1ce9c241-f4a9-4dc2-bfb2-412ab41d85cd"),
                            Name = "BoplpurSantiniketan"
                        },
                        new
                        {
                            Id = new Guid("3524eaa7-60c6-45ac-aba8-307485b7a779"),
                            Name = "Chandigarh"
                        },
                        new
                        {
                            Id = new Guid("18dc40e0-d8ef-4b6a-bd12-cd6e18454b87"),
                            Name = "Chennai"
                        },
                        new
                        {
                            Id = new Guid("dfa936af-d5e1-4e54-b563-fa24eab41577"),
                            Name = "Coimbatore"
                        },
                        new
                        {
                            Id = new Guid("92ee7a9d-1488-4236-ba0b-17e67d7d8fde"),
                            Name = "Delhi"
                        },
                        new
                        {
                            Id = new Guid("4dc5dad2-52b3-472e-a7d8-a83bdeb5a817"),
                            Name = "Dhanbad"
                        },
                        new
                        {
                            Id = new Guid("7d8c9561-cb01-4e98-8cbc-b2eb91da71dd"),
                            Name = "Dwarka"
                        },
                        new
                        {
                            Id = new Guid("15fd5a69-a653-494a-a13c-cc17a81134da"),
                            Name = "Faridabad"
                        },
                        new
                        {
                            Id = new Guid("61b0142a-2185-4e1e-9069-8076191284da"),
                            Name = "GirSomnath"
                        },
                        new
                        {
                            Id = new Guid("1332dde4-a65a-448d-9ed7-2be36115e8ff"),
                            Name = "Gurgaon"
                        },
                        new
                        {
                            Id = new Guid("8d469de5-5f12-4122-9bf2-00487a4f379c"),
                            Name = "Hyderabad"
                        },
                        new
                        {
                            Id = new Guid("39a6126e-d819-46e1-8813-efdeebba936e"),
                            Name = "Jagdalpur"
                        },
                        new
                        {
                            Id = new Guid("e299c079-692e-4296-aba1-5ff6aaa6d76a"),
                            Name = "Laipur"
                        },
                        new
                        {
                            Id = new Guid("2cf411d1-a1b2-4d4e-b3da-fdb5863bfc41"),
                            Name = "Kanchipuram"
                        },
                        new
                        {
                            Id = new Guid("e0e6e9aa-4ca3-4a74-9b51-af643c5f4c5f"),
                            Name = "Kochi"
                        },
                        new
                        {
                            Id = new Guid("71f1250f-acd3-4bee-991c-b504108a43fb"),
                            Name = "Kolkata"
                        },
                        new
                        {
                            Id = new Guid("8130e5a9-a7e1-4092-88db-b24bdedc9a05"),
                            Name = "Kozhikode"
                        },
                        new
                        {
                            Id = new Guid("58df1003-bf12-4170-942d-ecf2caa32656"),
                            Name = "Kurnool"
                        },
                        new
                        {
                            Id = new Guid("213301c0-af5a-4685-aa97-e546abe2a551"),
                            Name = "Lucknow"
                        },
                        new
                        {
                            Id = new Guid("9d5a4da1-50dc-44ca-a07b-d954727105b5"),
                            Name = "Madurai"
                        },
                        new
                        {
                            Id = new Guid("e347a0ce-f2fe-4bc8-aa0e-bfdb7641c96a"),
                            Name = "Mahasamund"
                        },
                        new
                        {
                            Id = new Guid("6ea60cfa-a1c5-4d20-845d-aae9c7d128ec"),
                            Name = "Malappuram"
                        },
                        new
                        {
                            Id = new Guid("6f739611-49cb-4010-934e-36f9181f389a"),
                            Name = "Mumbai"
                        },
                        new
                        {
                            Id = new Guid("110a9ee9-cb10-4131-8c51-c75526944734"),
                            Name = "Muzaffarnagar"
                        },
                        new
                        {
                            Id = new Guid("6a36d5c7-cc07-4cdf-9092-c0d0b08e8427"),
                            Name = "Nagpur"
                        },
                        new
                        {
                            Id = new Guid("b2b84cd7-7814-4924-8e61-575b7edf52c2"),
                            Name = "Nanded"
                        },
                        new
                        {
                            Id = new Guid("c186c1a2-231b-4bea-8fbe-c315d4ef8beb"),
                            Name = "NaviMumbai"
                        },
                        new
                        {
                            Id = new Guid("286ad5ab-cae2-4d0a-b500-9cc391132547"),
                            Name = "Pondicherry"
                        },
                        new
                        {
                            Id = new Guid("ccbc6aaf-a179-4a78-be10-69fd59abacb7"),
                            Name = "Pune"
                        },
                        new
                        {
                            Id = new Guid("cdb9598a-7be8-46a1-94b2-6934e5a0caf4"),
                            Name = "Surat"
                        },
                        new
                        {
                            Id = new Guid("166a8309-f1e1-4fa7-a36e-e0b9a67e9980"),
                            Name = "Thane"
                        },
                        new
                        {
                            Id = new Guid("17bbb716-51b1-496b-b6a6-0e256a2a7a2d"),
                            Name = "Trichy"
                        },
                        new
                        {
                            Id = new Guid("07869801-30ed-427b-a96b-720897a9ee15"),
                            Name = "Udaipur"
                        },
                        new
                        {
                            Id = new Guid("06073f5e-90d6-4103-a74c-3ea442e2047f"),
                            Name = "Uttarpara"
                        });
                });

            modelBuilder.Entity("CarCompany", b =>
                {
                    b.HasOne("CarPricePrediction.Core.Entities.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarPricePrediction.Core.Entities.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarFuel_type", b =>
                {
                    b.HasOne("CarPricePrediction.Core.Entities.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarPricePrediction.Core.Entities.Fuel_type", null)
                        .WithMany()
                        .HasForeignKey("Fuel_TypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarLabel", b =>
                {
                    b.HasOne("CarPricePrediction.Core.Entities.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarPricePrediction.Core.Entities.Label", null)
                        .WithMany()
                        .HasForeignKey("LabelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarLocation", b =>
                {
                    b.HasOne("CarPricePrediction.Core.Entities.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarPricePrediction.Core.Entities.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}