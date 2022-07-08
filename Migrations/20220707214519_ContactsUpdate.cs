using Microsoft.EntityFrameworkCore.Migrations;

namespace Rekrutacja.Migrations
{
    public partial class ContactsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OtherCategory",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OtherCategory",
                table: "Contact");
        }
    }
}
