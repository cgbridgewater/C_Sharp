using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace weddingPlanner.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rsvp_Users_UserId",
                table: "Rsvp");

            migrationBuilder.DropForeignKey(
                name: "FK_Rsvp_Weddings_WeddingId",
                table: "Rsvp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rsvp",
                table: "Rsvp");

            migrationBuilder.RenameTable(
                name: "Rsvp",
                newName: "Rsvps");

            migrationBuilder.RenameIndex(
                name: "IX_Rsvp_WeddingId",
                table: "Rsvps",
                newName: "IX_Rsvps_WeddingId");

            migrationBuilder.RenameIndex(
                name: "IX_Rsvp_UserId",
                table: "Rsvps",
                newName: "IX_Rsvps_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rsvps",
                table: "Rsvps",
                column: "RsvpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rsvps_Users_UserId",
                table: "Rsvps",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rsvps_Weddings_WeddingId",
                table: "Rsvps",
                column: "WeddingId",
                principalTable: "Weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rsvps_Users_UserId",
                table: "Rsvps");

            migrationBuilder.DropForeignKey(
                name: "FK_Rsvps_Weddings_WeddingId",
                table: "Rsvps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rsvps",
                table: "Rsvps");

            migrationBuilder.RenameTable(
                name: "Rsvps",
                newName: "Rsvp");

            migrationBuilder.RenameIndex(
                name: "IX_Rsvps_WeddingId",
                table: "Rsvp",
                newName: "IX_Rsvp_WeddingId");

            migrationBuilder.RenameIndex(
                name: "IX_Rsvps_UserId",
                table: "Rsvp",
                newName: "IX_Rsvp_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rsvp",
                table: "Rsvp",
                column: "RsvpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rsvp_Users_UserId",
                table: "Rsvp",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rsvp_Weddings_WeddingId",
                table: "Rsvp",
                column: "WeddingId",
                principalTable: "Weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
