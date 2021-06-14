using Microsoft.EntityFrameworkCore.Migrations;

namespace KocDigitalWebAPI.Migrations
{
    public partial class addmigrationmydbsec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productStock",
                table: "ProductData",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productStock",
                table: "ProductData");
        }
    }
}
