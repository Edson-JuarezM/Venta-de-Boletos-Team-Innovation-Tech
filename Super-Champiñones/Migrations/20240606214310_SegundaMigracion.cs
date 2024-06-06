using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Champiñones.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fecha_Hora",
                table: "Ventas",
                newName: "Fecha");

            migrationBuilder.AlterColumn<int>(
                name: "Sector",
                table: "Ventas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Costo",
                table: "Partidos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha_Hora",
                table: "Partidos",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "Fecha_Hora",
                table: "Partidos");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Ventas",
                newName: "Fecha_Hora");

            migrationBuilder.AlterColumn<string>(
                name: "Sector",
                table: "Ventas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
