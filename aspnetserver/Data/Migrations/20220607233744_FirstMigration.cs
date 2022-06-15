using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100000, nullable: false),
                    VideoUrl = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Description", "Title", "VideoUrl" },
                values: new object[] { 1, "This is Song 1", "Song 1", "https://youtu.be/KNMbDIKJ6T0" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Description", "Title", "VideoUrl" },
                values: new object[] { 2, "This is Song 2", "Song 2", "https://youtu.be/KNMbDIKJ6T0" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Description", "Title", "VideoUrl" },
                values: new object[] { 3, "This is Song 3", "Song 3", "https://youtu.be/KNMbDIKJ6T0" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Description", "Title", "VideoUrl" },
                values: new object[] { 4, "This is Song 4", "Song 4", "https://youtu.be/KNMbDIKJ6T0" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Description", "Title", "VideoUrl" },
                values: new object[] { 5, "This is Song 5", "Song 5", "https://youtu.be/KNMbDIKJ6T0" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Description", "Title", "VideoUrl" },
                values: new object[] { 6, "This is Song 6", "Song 6", "https://youtu.be/KNMbDIKJ6T0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
