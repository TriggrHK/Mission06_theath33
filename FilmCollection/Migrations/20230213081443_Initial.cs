using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<string>(nullable: true),
                    Lent_To = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.FilmId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FilmId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Musical", "Michael Gracey", "no", null, "Mom's favorite movie", "PG", "The Greatest Showman", 2017 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FilmId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Fantasy", "David Yates", "yes", "Older Brother", null, "PG-13", "Harry Potter: The Deathly Hallows Pt. 2", 2011 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FilmId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Family", "John Stevenson, Mark Osborne", "no", null, null, "PG", "Kung Fu Panda", 2008 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
