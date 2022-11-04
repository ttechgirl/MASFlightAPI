using Microsoft.EntityFrameworkCore.Migrations;

namespace MASFlightAPI.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "flightPayments");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "flightPayments",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "flightPayments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "flightPayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Payment_options",
                table: "flightPayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "flightPayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Redirect_url",
                table: "flightPayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tx_ref",
                table: "flightPayments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phonenumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_flightPayments_CustomerId",
                table: "flightPayments",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_flightPayments_Customer_CustomerId",
                table: "flightPayments",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flightPayments_Customer_CustomerId",
                table: "flightPayments");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_flightPayments_CustomerId",
                table: "flightPayments");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "flightPayments");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "flightPayments");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "flightPayments");

            migrationBuilder.DropColumn(
                name: "Payment_options",
                table: "flightPayments");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "flightPayments");

            migrationBuilder.DropColumn(
                name: "Redirect_url",
                table: "flightPayments");

            migrationBuilder.DropColumn(
                name: "Tx_ref",
                table: "flightPayments");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "flightPayments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
