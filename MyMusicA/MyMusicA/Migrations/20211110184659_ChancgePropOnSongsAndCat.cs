using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusicA.Migrations
{
    public partial class ChancgePropOnSongsAndCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Songs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
