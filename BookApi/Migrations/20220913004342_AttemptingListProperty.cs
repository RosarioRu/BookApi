using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApi.Migrations
{
    public partial class AttemptingListProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Books",
                newName: "SingleRating");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SingleRating",
                table: "Books",
                newName: "Rating");
        }
    }
}
