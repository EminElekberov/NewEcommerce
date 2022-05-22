using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceSite.Migrations
{
    public partial class sizes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SizeToProducts",
                columns: table => new
                {
                    SizeId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeToProducts", x => new { x.ProductId, x.SizeId });
                    table.ForeignKey(
                        name: "FK_SizeToProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeToProducts_sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "sizes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SizeToProducts_SizeId",
                table: "SizeToProducts",
                column: "SizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SizeToProducts");

            migrationBuilder.DropTable(
                name: "sizes");
        }
    }
}
