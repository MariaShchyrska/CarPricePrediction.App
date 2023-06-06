using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarPricePrediction.Core.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Kms_driven = table.Column<double>(type: "float", nullable: false),
                    Fuel_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuel_Types",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuel_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarCompany",
                columns: table => new
                {
                    CarsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompaniesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCompany", x => new { x.CarsId, x.CompaniesId });
                    table.ForeignKey(
                        name: "FK_CarCompany_Cars_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCompany_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarFuel_type",
                columns: table => new
                {
                    CarsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fuel_TypesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFuel_type", x => new { x.CarsId, x.Fuel_TypesId });
                    table.ForeignKey(
                        name: "FK_CarFuel_type_Cars_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarFuel_type_Fuel_Types_Fuel_TypesId",
                        column: x => x.Fuel_TypesId,
                        principalTable: "Fuel_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarLabel",
                columns: table => new
                {
                    CarsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LabelsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarLabel", x => new { x.CarsId, x.LabelsId });
                    table.ForeignKey(
                        name: "FK_CarLabel_Cars_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarLabel_Labels_LabelsId",
                        column: x => x.LabelsId,
                        principalTable: "Labels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarLocation",
                columns: table => new
                {
                    CarsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarLocation", x => new { x.CarsId, x.LocationsId });
                    table.ForeignKey(
                        name: "FK_CarLocation_Cars_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarLocation_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06073f5e-90d6-4103-a74c-3ea442e2047f"), "Uttarpara" },
                    { new Guid("0712a3b6-405b-4e8d-871a-204c3ae6689a"), "Bilaspur" },
                    { new Guid("07869801-30ed-427b-a96b-720897a9ee15"), "Udaipur" },
                    { new Guid("110a9ee9-cb10-4131-8c51-c75526944734"), "Muzaffarnagar" },
                    { new Guid("1332dde4-a65a-448d-9ed7-2be36115e8ff"), "Gurgaon" },
                    { new Guid("15fd5a69-a653-494a-a13c-cc17a81134da"), "Faridabad" },
                    { new Guid("166a8309-f1e1-4fa7-a36e-e0b9a67e9980"), "Thane" },
                    { new Guid("17bbb716-51b1-496b-b6a6-0e256a2a7a2d"), "Trichy" },
                    { new Guid("18dc40e0-d8ef-4b6a-bd12-cd6e18454b87"), "Chennai" },
                    { new Guid("1ce9c241-f4a9-4dc2-bfb2-412ab41d85cd"), "BoplpurSantiniketan" },
                    { new Guid("213301c0-af5a-4685-aa97-e546abe2a551"), "Lucknow" },
                    { new Guid("286ad5ab-cae2-4d0a-b500-9cc391132547"), "Pondicherry" },
                    { new Guid("2cf411d1-a1b2-4d4e-b3da-fdb5863bfc41"), "Kanchipuram" },
                    { new Guid("3524eaa7-60c6-45ac-aba8-307485b7a779"), "Chandigarh" },
                    { new Guid("39a6126e-d819-46e1-8813-efdeebba936e"), "Jagdalpur" },
                    { new Guid("4dc5dad2-52b3-472e-a7d8-a83bdeb5a817"), "Dhanbad" },
                    { new Guid("58df1003-bf12-4170-942d-ecf2caa32656"), "Kurnool" },
                    { new Guid("61b0142a-2185-4e1e-9069-8076191284da"), "GirSomnath" },
                    { new Guid("6a36d5c7-cc07-4cdf-9092-c0d0b08e8427"), "Nagpur" },
                    { new Guid("6c9671f9-d541-4d3e-99a6-d5963eb1e031"), "Ahmedabad" },
                    { new Guid("6ea60cfa-a1c5-4d20-845d-aae9c7d128ec"), "Malappuram" },
                    { new Guid("6f739611-49cb-4010-934e-36f9181f389a"), "Mumbai" },
                    { new Guid("71f1250f-acd3-4bee-991c-b504108a43fb"), "Kolkata" },
                    { new Guid("7d8c9561-cb01-4e98-8cbc-b2eb91da71dd"), "Dwarka" },
                    { new Guid("8130e5a9-a7e1-4092-88db-b24bdedc9a05"), "Kozhikode" },
                    { new Guid("8d469de5-5f12-4122-9bf2-00487a4f379c"), "Hyderabad" },
                    { new Guid("92ee7a9d-1488-4236-ba0b-17e67d7d8fde"), "Delhi" },
                    { new Guid("9d5a4da1-50dc-44ca-a07b-d954727105b5"), "Madurai" },
                    { new Guid("b2b84cd7-7814-4924-8e61-575b7edf52c2"), "Nanded" },
                    { new Guid("c186c1a2-231b-4bea-8fbe-c315d4ef8beb"), "NaviMumbai" },
                    { new Guid("ccbc6aaf-a179-4a78-be10-69fd59abacb7"), "Pune" },
                    { new Guid("cdb9598a-7be8-46a1-94b2-6934e5a0caf4"), "Surat" },
                    { new Guid("dfa936af-d5e1-4e54-b563-fa24eab41577"), "Coimbatore" },
                    { new Guid("e0e6e9aa-4ca3-4a74-9b51-af643c5f4c5f"), "Kochi" },
                    { new Guid("e299c079-692e-4296-aba1-5ff6aaa6d76a"), "Laipur" },
                    { new Guid("e347a0ce-f2fe-4bc8-aa0e-bfdb7641c96a"), "Mahasamund" },
                    { new Guid("f9f92886-cad4-4edc-96c6-9920aacc5875"), "Bhubaneswar" },
                    { new Guid("fc7d65c9-2589-48c8-a2e3-021b48f74947"), "Bangalore" },
                    { new Guid("fdcfd7d3-15a5-4c32-ba51-b8a652c7a5fa"), "Anand" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCompany_CompaniesId",
                table: "CarCompany",
                column: "CompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFuel_type_Fuel_TypesId",
                table: "CarFuel_type",
                column: "Fuel_TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_CarLabel_LabelsId",
                table: "CarLabel",
                column: "LabelsId");

            migrationBuilder.CreateIndex(
                name: "IX_CarLocation_LocationsId",
                table: "CarLocation",
                column: "LocationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCompany");

            migrationBuilder.DropTable(
                name: "CarFuel_type");

            migrationBuilder.DropTable(
                name: "CarLabel");

            migrationBuilder.DropTable(
                name: "CarLocation");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Fuel_Types");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
