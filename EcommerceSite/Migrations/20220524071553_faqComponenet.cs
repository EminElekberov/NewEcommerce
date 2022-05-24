using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceSite.Migrations
{
    public partial class faqComponenet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaqTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaqTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaqComponents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ToggleHref = table.Column<string>(nullable: true),
                    FaqTitleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaqComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaqComponents_FaqTitles_FaqTitleId",
                        column: x => x.FaqTitleId,
                        principalTable: "FaqTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FaqComponents_FaqTitleId",
                table: "FaqComponents",
                column: "FaqTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaqComponents");

            migrationBuilder.DropTable(
                name: "FaqTitles");
        }
    }
}
