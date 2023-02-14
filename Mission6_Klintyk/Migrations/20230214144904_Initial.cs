using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_Klintyk.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    FilmID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_to = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.FilmID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FilmID", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Ryan Coogler", false, "Oliva Olred", "", "PG-13", "Black Panther", 2018 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FilmID", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Comedy", "Frank Coraci", true, "", "", "PG-13", "Blended", 2014 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FilmID", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "David Dobkin", false, "Carter Jenses", "", "PG-13", "Shanghai Knights", 2003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
