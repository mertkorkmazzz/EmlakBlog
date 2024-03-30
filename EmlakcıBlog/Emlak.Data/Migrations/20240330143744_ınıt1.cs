using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emlak.Data.Migrations
{
    /// <inheritdoc />
    public partial class ınıt1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Adverts",
                table: "Adverts");

            migrationBuilder.RenameTable(
                name: "Adverts",
                newName: "Advertis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advertis",
                table: "Advertis",
                column: "AdvertId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Advertis",
                table: "Advertis");

            migrationBuilder.RenameTable(
                name: "Advertis",
                newName: "Adverts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adverts",
                table: "Adverts",
                column: "AdvertId");
        }
    }
}
