using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class ImagenesIlustraciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreImagen",
                table: "Ilustracions");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoIlustracion",
                table: "Ilustracions",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Ilustracions",
                type: "nvarchar(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.CreateTable(
                name: "ImagenIlustraciones",
                columns: table => new
                {
                    IdImagenIlustracion = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdIlustracion = table.Column<int>(nullable: false),
                    NombreImagen = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenIlustraciones", x => x.IdImagenIlustracion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenIlustraciones");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoIlustracion",
                table: "Ilustracions",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Ilustracions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)");

            migrationBuilder.AddColumn<string>(
                name: "NombreImagen",
                table: "Ilustracions",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }
    }
}
