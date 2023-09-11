using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace weddingPlanner.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorUserId",
                table: "Weddings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rsvp",
                columns: table => new
                {
                    RsvpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WeddingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rsvp", x => x.RsvpId);
                    table.ForeignKey(
                        name: "FK_Rsvp_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rsvp_Weddings_WeddingId",
                        column: x => x.WeddingId,
                        principalTable: "Weddings",
                        principalColumn: "WeddingId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_CreatorUserId",
                table: "Weddings",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rsvp_UserId",
                table: "Rsvp",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rsvp_WeddingId",
                table: "Rsvp",
                column: "WeddingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weddings_Users_CreatorUserId",
                table: "Weddings",
                column: "CreatorUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weddings_Users_CreatorUserId",
                table: "Weddings");

            migrationBuilder.DropTable(
                name: "Rsvp");

            migrationBuilder.DropIndex(
                name: "IX_Weddings_CreatorUserId",
                table: "Weddings");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Weddings");
        }
    }
}
