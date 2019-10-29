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
                name: "LakeTileColor",
                columns: table => new
                {
                    LakeTileColorId = table.Column<Guid>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    LakeTileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LakeTileColor", x => x.LakeTileColorId);
                    table.ForeignKey(
                        name: "FK_LakeTileColor_LakeTiles_LakeTileId",
                        column: x => x.LakeTileId,
                        principalTable: "LakeTiles",
                        principalColumn: "LakeTileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LakeTileColor_LakeTileId",
                table: "LakeTileColor",
                column: "LakeTileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LakeTileColor");

            migrationBuilder.DropTable(
                name: "LakeTiles");
        }
    }
}
