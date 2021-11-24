using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusicA.Migrations
{
    public partial class AddingNewProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Songs",
                newName: "SongUrl");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Songs",
                newName: "SongRating");

            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateEdited",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateEntered",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Favourite",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SongName",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "DateEdited",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "DateEntered",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Favourite",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "SongName",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "SongUrl",
                table: "Songs",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "SongRating",
                table: "Songs",
                newName: "Body");
        }
    }
}
