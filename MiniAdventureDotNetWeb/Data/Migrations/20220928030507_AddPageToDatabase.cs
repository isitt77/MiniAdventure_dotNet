using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniAdventureDotNetWeb.Migrations
{
    public partial class AddPageToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    ActionCode = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Segment1 = table.Column<string>(type: "text", nullable: false),
                    Segment2 = table.Column<string>(type: "text", nullable: true),
                    Segment3 = table.Column<string>(type: "text", nullable: true),
                    Segment4 = table.Column<string>(type: "text", nullable: true),
                    Segment5 = table.Column<string>(type: "text", nullable: true),
                    OptionA = table.Column<string>(type: "text", nullable: false),
                    OptionB = table.Column<string>(type: "text", nullable: true),
                    OptionC = table.Column<string>(type: "text", nullable: true),
                    ActionA = table.Column<string>(type: "text", nullable: false),
                    ActionB = table.Column<string>(type: "text", nullable: true),
                    ActionC = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.ActionCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");
        }
    }
}
