using Microsoft.EntityFrameworkCore.Migrations;

namespace EricShop.Migrations
{
    public partial class Username1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Aesops",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Aesops");
        }
    }
}
