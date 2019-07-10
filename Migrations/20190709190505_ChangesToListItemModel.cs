using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class ChangesToListItemModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "MovieListItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "MovieList",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rank",
                table: "MovieListItem");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "MovieList");
        }
    }
}
