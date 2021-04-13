using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class seagregoprecioytamaños : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    idPrecios = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Precio = table.Column<double>(nullable: false),
                    F_Inicio = table.Column<DateTime>(nullable: false),
                    F_Fin = table.Column<DateTime>(nullable: false),
                    Productos_idProductos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.idPrecios);
                });

            migrationBuilder.CreateTable(
                name: "tamaños",
                columns: table => new
                {
                    idTamaño = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tamaño = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Categoria_idCategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tamaños", x => x.idTamaño);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "tamaños");
        }
    }
}
