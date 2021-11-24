using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusicA.Migrations
{
    public partial class AddCategoryID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Categories_CategoryID",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Songs",
                newName: "CategoryID1");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_CategoryID",
                table: "Songs",
                newName: "IX_Songs_CategoryID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Categories_CategoryID1",
                table: "Songs",
                column: "CategoryID1",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Categories_CategoryID1",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "CategoryID1",
                table: "Songs",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_CategoryID1",
                table: "Songs",
                newName: "IX_Songs_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Categories_CategoryID",
                table: "Songs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
