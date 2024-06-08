using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Champiñones.Migrations
{
    /// <inheritdoc />
    public partial class TerceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlFotoA",
                table: "Partidos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlFotoB",
                table: "Partidos",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlFotoA",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "UrlFotoB",
                table: "Partidos");
        }
    }
}
