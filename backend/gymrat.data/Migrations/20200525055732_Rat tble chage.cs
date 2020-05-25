using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymrat.Data.Migrations
{
    public partial class Rattblechage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rats",
                table: "Rats");

            migrationBuilder.RenameTable(
                name: "Rats",
                newName: "Rat");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rat",
                table: "Rat",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rat",
                table: "Rat");

            migrationBuilder.RenameTable(
                name: "Rat",
                newName: "Rats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rats",
                table: "Rats",
                column: "Id");
        }
    }
}
