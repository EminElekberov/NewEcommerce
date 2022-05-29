using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceSite.Migrations
{
    public partial class newhbd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippinandReturns",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Information",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShippinandReturns",
                table: "Products");
        }
    }
}
