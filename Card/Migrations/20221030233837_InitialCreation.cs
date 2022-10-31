using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Card.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitleName = table.Column<string>(type: "TEXT", nullable: false),
                    CardNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Expiration = table.Column<int>(type: "INTEGER", nullable: false),
                    CVC = table.Column<string>(type: "TEXT", nullable: false),
                    Done = table.Column<bool>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NCard");
        }
    }
}
