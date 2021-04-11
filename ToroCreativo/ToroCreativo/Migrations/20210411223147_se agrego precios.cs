using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class seagregoprecios : Migration
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
                    F_Inicio = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    F_Fin = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Productos_idProductos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.idPrecios);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "precios");
        }
    }
}
