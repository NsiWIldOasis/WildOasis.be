using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WildOasis.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddResort : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ResortId",
                table: "Cabins",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Resort",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resort", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cabins_ResortId",
                table: "Cabins",
                column: "ResortId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cabins_Resort_ResortId",
                table: "Cabins",
                column: "ResortId",
                principalTable: "Resort",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cabins_Resort_ResortId",
                table: "Cabins");

            migrationBuilder.DropTable(
                name: "Resort");

            migrationBuilder.DropIndex(
                name: "IX_Cabins_ResortId",
                table: "Cabins");

            migrationBuilder.DropColumn(
                name: "ResortId",
                table: "Cabins");
        }
    }
}
