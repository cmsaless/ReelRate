using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Data.Migrations
{
    public partial class AddedMovieLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieListID",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MovieList",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieList", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieListID",
                table: "Movies",
                column: "MovieListID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieList_MovieListID",
                table: "Movies",
                column: "MovieListID",
                principalTable: "MovieList",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieList_MovieListID",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "MovieList");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieListID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieListID",
                table: "Movies");
        }
    }
}
