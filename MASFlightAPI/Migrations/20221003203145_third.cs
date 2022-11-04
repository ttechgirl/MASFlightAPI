using Microsoft.EntityFrameworkCore.Migrations;

namespace MASFlightAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Longtitude",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "RegionName",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "Location");

            migrationBuilder.AddColumn<int>(
                name: "Trip_Type",
                table: "MASFlights",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Airport",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Location",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "flightPayments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flightPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MASFlightAdmins",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    RoundTrip = table.Column<int>(nullable: false),
                    OneWay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MASFlightAdmins", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flightPayments");

            migrationBuilder.DropTable(
                name: "MASFlightAdmins");

            migrationBuilder.DropColumn(
                name: "Trip_Type",
                table: "MASFlights");

            migrationBuilder.DropColumn(
                name: "Airport",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Location");

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longtitude",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegionName",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeZone",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "latitude",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
