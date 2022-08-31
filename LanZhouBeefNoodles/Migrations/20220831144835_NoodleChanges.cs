using Microsoft.EntityFrameworkCore.Migrations;

namespace LanZhouBeefNoodles.Migrations
{
    public partial class NoodleChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Noodles",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Noodles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Noodles");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Noodles",
                newName: "ImageURL");
        }
    }
}
