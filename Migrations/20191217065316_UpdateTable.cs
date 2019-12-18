using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeetingID",
                table: "Assignment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConductingLeader = table.Column<string>(maxLength: 60, nullable: false),
                    OpeningSong = table.Column<string>(nullable: true),
                    OpeningPrayer = table.Column<string>(maxLength: 60, nullable: false),
                    SacramentSong = table.Column<string>(nullable: true),
                    IntermediateSong = table.Column<string>(nullable: true),
                    ClosingSong = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_MeetingID",
                table: "Assignment",
                column: "MeetingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Meeting_MeetingID",
                table: "Assignment",
                column: "MeetingID",
                principalTable: "Meeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Meeting_MeetingID",
                table: "Assignment");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Assignment_MeetingID",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "MeetingID",
                table: "Assignment");
        }
    }
}
