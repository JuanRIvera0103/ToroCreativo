using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class seagregoambastablasdeimagenes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImagenIlustraciones",
                columns: table => new
                {
                    IdImagenIlustracion = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdIlustracion = table.Column<int>(nullable: false),
                    NombreImagen = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenIlustraciones", x => x.IdImagenIlustracion);
                });

            migrationBuilder.CreateTable(
                name: "ImagenProductos",
                columns: table => new
                {
                    IdImagenProducto = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdProducto = table.Column<int>(nullable: false),
                    NombreImagen = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenProductos", x => x.IdImagenProducto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenIlustraciones");

            migrationBuilder.DropTable(
                name: "ImagenProductos");
        }
    }
}
