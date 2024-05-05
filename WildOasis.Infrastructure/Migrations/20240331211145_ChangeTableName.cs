using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WildOasis.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_cabins",
                table: "cabins");

            migrationBuilder.RenameTable(
                name: "cabins",
                newName: "Cabins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cabins",
                table: "Cabins",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cabins",
                table: "Cabins");

            migrationBuilder.RenameTable(
                name: "Cabins",
                newName: "cabins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cabins",
                table: "cabins",
                column: "Id");
        }
    }
}
