using Microsoft.EntityFrameworkCore.Migrations;

namespace Card.Migrations
{
    public partial class InitialCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.RenameTable(
                name: "Todos",
                newName: "NCard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NCard",
                table: "NCard",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NCard",
                table: "NCard");

            migrationBuilder.RenameTable(
                name: "NCard",
                newName: "Todos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "Id");
        }
    }
}
