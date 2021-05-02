using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class SemodificoEntradas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "entradas");

            migrationBuilder.AddColumn<int>(
                name: "CantidadActual",
                table: "entradas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadInicial",
                table: "entradas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadActual",
                table: "entradas");

            migrationBuilder.DropColumn(
                name: "CantidadInicial",
                table: "entradas");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "entradas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
