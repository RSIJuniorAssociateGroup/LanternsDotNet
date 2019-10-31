using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanternsDotNet.Migrations
{
    public partial class LakeTileLakeTileColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LakeTileColor_LakeTiles_LakeTileId",
                table: "LakeTileColor");

            migrationBuilder.DropIndex(
                name: "IX_LakeTileColor_LakeTileId",
                table: "LakeTileColor");

            migrationBuilder.DropColumn(
                name: "LakeTileId",
                table: "LakeTileColor");

            migrationBuilder.AddColumn<int>(
                name: "LakeTileLakeTileColor",
                table: "LakeTiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "URl",
                table: "LakeTileColor",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LakeTileLakeTileColors",
                columns: table => new
                {
                    LakeTileId = table.Column<Guid>(nullable: false),
                    LakeTileColorId = table.Column<Guid>(nullable: false),
                    LakeTileLakeTileColorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LakeTileLakeTileColors", x => new { x.LakeTileColorId, x.LakeTileId });
                    table.ForeignKey(
                        name: "FK_LakeTileLakeTileColors_LakeTileColor_LakeTileColorId",
                        column: x => x.LakeTileColorId,
                        principalTable: "LakeTileColor",
                        principalColumn: "LakeTileColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LakeTileLakeTileColors_LakeTiles_LakeTileId",
                        column: x => x.LakeTileId,
                        principalTable: "LakeTiles",
                        principalColumn: "LakeTileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LakeTileLakeTileColors_LakeTileId",
                table: "LakeTileLakeTileColors",
                column: "LakeTileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LakeTileLakeTileColors");

            migrationBuilder.DropColumn(
                name: "LakeTileLakeTileColor",
                table: "LakeTiles");

            migrationBuilder.DropColumn(
                name: "URl",
                table: "LakeTileColor");

            migrationBuilder.AddColumn<Guid>(
                name: "LakeTileId",
                table: "LakeTileColor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LakeTileColor_LakeTileId",
                table: "LakeTileColor",
                column: "LakeTileId");

            migrationBuilder.AddForeignKey(
                name: "FK_LakeTileColor_LakeTiles_LakeTileId",
                table: "LakeTileColor",
                column: "LakeTileId",
                principalTable: "LakeTiles",
                principalColumn: "LakeTileId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
