using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class Pedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ApellidoCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    EstadoCliente = table.Column<string>(type: "nvarchar(13)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    FechaPedido = table.Column<DateTime>(nullable: false),
                    FechaVenta = table.Column<DateTime>(nullable: false),
                    Subtotal = table.Column<double>(nullable: false),
                    TotalIva = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    NombreImagen = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
