using Microsoft.EntityFrameworkCore.Migrations;

namespace EricShop.Migrations
{
    public partial class AddingShopCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopCartItems",
                columns: table => new
                {
                    ShopCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopCartId = table.Column<string>(nullable: true),
                    AesopId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItems", x => x.ShopCartItemId);
                    table.ForeignKey(
                        name: "FK_ShopCartItems_Aesops_AesopId",
                        column: x => x.AesopId,
                        principalTable: "Aesops",
                        principalColumn: "AesopId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_AesopId",
                table: "ShopCartItems",
                column: "AesopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCartItems");
        }
    }
}
