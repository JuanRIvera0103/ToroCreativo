using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class SeagregoIlustracionesyClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ApellidoCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    EstadoCliente = table.Column<string>(type: "nvarchar(13)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Ilustracions",
                columns: table => new
                {
                    IdIlustracion = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreIlustracion = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdGenero = table.Column<int>(nullable: false),
                    EstadoIlustracion = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    NombreImagen = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilustracions", x => x.IdIlustracion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Ilustracions");
        }
    }
}
