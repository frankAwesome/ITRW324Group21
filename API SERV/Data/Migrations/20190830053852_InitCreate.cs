using Microsoft.EntityFrameworkCore.Migrations;

namespace Four324.Data.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Article = table.Column<string>(nullable: true),
                    Day = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true),
                    Urlone = table.Column<string>(nullable: true),
                    Urltwo = table.Column<string>(nullable: true),
                    Urlthree = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Values");
        }
    }
}
