using Microsoft.EntityFrameworkCore.Migrations;

namespace MASFlightAPI.Migrations
{
    public partial class modelsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "MASFlights",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "MASFlights");
        }
    }
}
