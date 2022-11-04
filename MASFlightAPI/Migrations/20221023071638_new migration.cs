using Microsoft.EntityFrameworkCore.Migrations;

namespace MASFlightAPI.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BookingId",
                table: "MASFlights",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MASFlights",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "MASFlights");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MASFlights");
        }
    }
}
