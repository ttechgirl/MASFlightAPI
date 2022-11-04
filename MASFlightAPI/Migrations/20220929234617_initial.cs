using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MASFlightAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPAddress = table.Column<string>(nullable: true),
                    CountryName = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true),
                    CityName = table.Column<string>(nullable: true),
                    RegionName = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    TimeZone = table.Column<string>(nullable: true),
                    Longtitude = table.Column<string>(nullable: true),
                    latitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelerAges",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adult = table.Column<int>(nullable: false),
                    Children = table.Column<int>(nullable: false),
                    Infant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelerAges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MASFlights",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketName = table.Column<string>(nullable: true),
                    TicketDescription = table.Column<string>(nullable: true),
                    departure = table.Column<int>(nullable: false),
                    destination = table.Column<int>(nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false),
                    locationId = table.Column<long>(nullable: true),
                    flightCategories = table.Column<int>(nullable: false),
                    AgeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MASFlights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MASFlights_TravelerAges_AgeId",
                        column: x => x.AgeId,
                        principalTable: "TravelerAges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MASFlights_Location_locationId",
                        column: x => x.locationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MASFlights_AgeId",
                table: "MASFlights",
                column: "AgeId");

            migrationBuilder.CreateIndex(
                name: "IX_MASFlights_locationId",
                table: "MASFlights",
                column: "locationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MASFlights");

            migrationBuilder.DropTable(
                name: "TravelerAges");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
