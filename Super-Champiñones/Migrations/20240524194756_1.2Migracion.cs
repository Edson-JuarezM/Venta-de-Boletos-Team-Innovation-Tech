using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Champiñones.Migrations
{
    /// <inheritdoc />
    public partial class _12Migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Celular",
                table: "Miembro_Vips",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Miembro_Vips");
        }
    }
}
