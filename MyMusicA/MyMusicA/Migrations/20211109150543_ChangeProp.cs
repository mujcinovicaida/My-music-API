using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusicA.Migrations
{
    public partial class ChangeProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Songs_SongID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SongID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SongID",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Songs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_CategoryID",
                table: "Songs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Categories_CategoryID",
                table: "Songs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Categories_CategoryID",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_CategoryID",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Songs");

            migrationBuilder.AddColumn<int>(
                name: "SongID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SongID",
                table: "Categories",
                column: "SongID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Songs_SongID",
                table: "Categories",
                column: "SongID",
                principalTable: "Songs",
                principalColumn: "SongID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
