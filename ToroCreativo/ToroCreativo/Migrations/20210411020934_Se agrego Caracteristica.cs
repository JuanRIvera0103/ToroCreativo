using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class SeagregoCaracteristica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EstadoIlustracion",
                table: "Ilustracions",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.CreateTable(
                name: "caracteristicas",
                columns: table => new
                {
                    idCaracteristicas = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Productos_idProductos = table.Column<int>(nullable: false),
                    Tamaño_idUnidades_medidas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caracteristicas", x => x.idCaracteristicas);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "caracteristicas");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoIlustracion",
                table: "Ilustracions",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");
        }
    }
}
