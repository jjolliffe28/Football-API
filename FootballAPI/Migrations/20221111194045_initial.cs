using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalYards = table.Column<int>(type: "int", nullable: false),
                    TotalTouchdowns = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "Position", "Team", "TotalTouchdowns", "TotalYards" },
                values: new object[,]
                {
                    { 1, "Jacoby Brisset", "QB", "Browns", 20, 200 },
                    { 2, "Nick Chubb", "RB", "Browns", 25, 1000 },
                    { 3, "Lamar Jackson", "QB", "Ravens", 32, 1738 },
                    { 4, "Justin Jefferson", "WR", "Vikings", 10, 756 },
                    { 5, "Mark Andrews", "TE", "Ravens", 15, 450 },
                    { 6, "Randy Moss", "WR", "Vikings", 33, 2219 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
