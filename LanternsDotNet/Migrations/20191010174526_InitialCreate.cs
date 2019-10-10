using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanternsDotNet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LakeTiles",
                columns: table => new
                {
                    LakeTileId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LakeTiles", x => x.LakeTileId);
                });

            migrationBuilder.CreateTable(
                name: "LanternCards",
                columns: table => new
                {
                    LanternCardId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanternCards", x => x.LanternCardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LakeTiles");

            migrationBuilder.DropTable(
                name: "LanternCards");
        }
    }
}
