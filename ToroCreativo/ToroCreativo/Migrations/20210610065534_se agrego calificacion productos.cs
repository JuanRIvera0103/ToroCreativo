using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class seagregocalificacionproductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalificacionProductos",
                columns: table => new
                {
                    IdCalificacion = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<string>(type: "varchar(255)", nullable: true),
                    IdProducto = table.Column<int>(nullable: false),
                    Calificacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalificacionProductos", x => x.IdCalificacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalificacionProductos");
        }
    }
}
